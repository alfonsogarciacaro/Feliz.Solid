module Components

open Browser
open Browser.Types
open Feliz
open Feliz.Solid
open Fable.Core
open Fable.Core.JsInterop

[<JSX.Component>]
let Counter() =
    let count, setCount = Solid.createSignal(0)
    let doubled() = count() * 2
    let quadrupled() = doubled() * 2

    Html.fragment [
        Html.button [
            Ev.onClick(fun _ -> count() + 1 |> setCount)
            Html.children [
                Html.text "Click me !"
            ]
        ]
        Html.p $"{count()} * 2 = {doubled()}"
        Html.p $"{doubled()} * 2 = {quadrupled()}"
    ]

[<JSX.Component>]
let ReactiveStyles() =
    let num, setNum = Solid.createSignal(0)
    let _ = JS.setInterval (fun () -> num() + 1 % 255 |> setNum) 30

    Html.div [
        Html.style [
            Css.color $"rgb({num()}, 180, {num()})"
            Css.fontWeight 800
            Css.fontSize (length.px(num()))
        ]
        Html.children [
            Html.text $"Number is {num()}"
        ]
    ]

module Sketch =
    let setStyle (el: HTMLElement) ((key, value): string * string) =
        el?style?(key) <- value

    let maxGridPixelWidth = 500.

    let randomHexColorString(): string =
        let v = JS.Math.random() * 16777215. |> int
        "#" + System.Convert.ToString(v, 16)

    let clampGridSideLength(newSideLength) =
        min (max newSideLength 0.) 100.

    [<JSX.Component>]
    let Component(initialSide: float) =
        let gridSideLength, setGridSideLength = Solid.createSignal(initialSide)
        let gridTemplateString = Solid.createMemo(fun () ->
            $"repeat({gridSideLength()}, {maxGridPixelWidth / gridSideLength()}px)")

        Html.fragment [
            Html.div [
                Html.style [ Css.marginBottom 10 ]
                Html.children [
                    Html.label "Grid Side Length: "
                    Html.input [
                        Attr.typeNumber
                        Attr.value (gridSideLength().ToString())
                        Ev.onInput(fun e ->
                            (e.currentTarget :?> HTMLInputElement).valueAsNumber
                            |> clampGridSideLength
                            |> setGridSideLength
                        )
                    ]
                ]
            ]

            Html.div [
                Html.style [
                    Css.displayGrid
                    Css.gridTemplateRows [gridTemplateString() |> grid.ofString]
                    Css.gridTemplateColumns [gridTemplateString() |> grid.ofString]
                ]
                Html.children [
                    Solid.Index(
                        each = (Array.init (gridSideLength() ** 2 |> int) id),
                        fallback = (Html.text "Input a grid side length."),
                        child = (fun _ _ ->
                            Html.div [
                                Attr.className "cell"
                                Ev.onMouseEnter(fun ev ->
                                    let el = ev.currentTarget :?> HTMLElement
                                    Css.backgroundColor(randomHexColorString()) |> setStyle el
                                    JS.setTimeout (fun () ->
                                        Css.backgroundColor "initial" |> setStyle el) 500
                                    |> ignore
                                )
                            ]
                        ))
                ]
            ]
        ]

