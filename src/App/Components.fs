module Components

open Browser.Types
open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<JSX.Component>]
let Div (classes: string list) children =
    Html.div [
        Attr.classes classes
        Html.children [
            Html.propsChildren children
        ]
    ]

[<JSX.Component>]
let Counter() =
    let count, setCount = Solid.createSignal(0)
    let doubled() = count() * 2
    let quadrupled() = doubled() * 2

    Html.fragment [
        Html.p $"{count()} * 2 = {doubled()}"
        Html.p $"{doubled()} * 2 = {quadrupled()}"
        Html.br []
        Html.button [
            Attr.className "button"
            Ev.onClick(fun _ -> count() + 1 |> setCount)
            Html.children [
                Html.text $"Click me!"
            ]
        ]
    ]

[<JSX.Component>]
let Styles() =
    let num, setNum = Solid.createSignal(0)
    let _ = JS.setInterval (fun () -> num() + 1 % 255 |> setNum) 30

    Html.div [
        Attr.style [
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
    let App(initialSide: float) =
        let gridSideLength, setGridSideLength = Solid.createSignal(initialSide)
        let gridTemplateString = Solid.createMemo(fun () ->
            $"repeat({gridSideLength()}, {maxGridPixelWidth / gridSideLength()}px)")

        Html.fragment [
            Html.div [
                Attr.style [ Css.marginBottom 10 ]
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
                Attr.style [
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

module TodoMVC =
    open System

    type Todo =
        { Id: Guid
          Description: string
          Editing: string option
          Completed: bool }

    type State =
        { Todos: Todo list }

    type Msg =
        | AddNewTodo of string
        | DeleteTodo of Guid
        | ToggleCompleted of Guid
        | CancelEdit
        | ApplyEdit of string
        | StartEditingTodo of Guid

    let init () =
        { Todos =
            [ { Id = Guid.NewGuid()
                Description = "Learn F#"
                Completed = false
                Editing = None }
              { Id = Guid.NewGuid()
                Description = "Learn Elmish"
                Completed = true
                Editing = None } ] }

    let update (msg: Msg) (state: State) =
        match msg with
        | AddNewTodo txt ->
            let nextTodo =
                { Id = Guid.NewGuid()
                  Description = txt
                  Completed = false
                  Editing = None }
            { state with
                Todos = nextTodo::state.Todos }

        | DeleteTodo todoId ->
            state.Todos
            |> List.filter (fun todo -> todo.Id <> todoId)
            |> fun todos -> { state with Todos = todos }

        | ToggleCompleted todoId ->
            state.Todos
            |> List.map
                (fun todo ->
                    if todo.Id = todoId then
                        let completed = not todo.Completed
                        { todo with
                            Completed = completed }
                    else
                        todo)
            |> fun todos -> { state with Todos = todos }

        | StartEditingTodo todoId ->
            state.Todos |> List.map (fun t ->
                match t.Editing with
                | _ when t.Id = todoId -> { t with Editing = Some t.Description }
                | Some _ -> { t with Editing = None }
                | _ -> t)
            |> fun todos -> { state with Todos = todos }

        | CancelEdit ->
            state.Todos |> List.map (fun t ->
                if Option.isSome t.Editing
                then { t with Editing = None }
                else t)
            |> fun todos -> { state with Todos = todos }

        | ApplyEdit txt ->
            state.Todos |> List.map (fun t ->
                match t.Editing with
                | Some _ ->
                    { t with Description = txt; Editing = None }
                | None -> t)
            |> fun todos -> { state with Todos = todos }

    let onEnterOrEscape dispatchOnEnter dispatchOnEscape (ev: KeyboardEvent) =
        let el = ev.target :?> HTMLInputElement

        match ev.key with
        | "Enter" ->
            dispatchOnEnter el.value
            el.value <- ""
        | "Escape" ->
            dispatchOnEscape()
            el.value <- ""
            el.blur ()
        | _ -> ()

    [<JSX.Component>]
    let InputField (dispatch: Msg -> unit) =
        let inputRef = Solid.createRef<HTMLInputElement>()
        Div [ "field"; "has-addons" ] [
           Div [ "control"; "is-expanded" ] [
                Html.input [
                    Solid.ref inputRef
                    Attr.classes [ "input"; "is-medium" ]
                    Ev.onKeyUp (onEnterOrEscape (AddNewTodo >> dispatch) ignore)
                ]
            ]

           Div [ "control" ] [
                Html.button [
                    Attr.classes [
                        "button"
                        "is-primary"
                        "is-medium"
                    ]
                    Ev.onClick (fun _ ->
                        let txt = inputRef.Value.value
                        inputRef.Value.value <- ""
                        txt |> AddNewTodo |> dispatch)
                    Html.children [
                        Html.i [
                            Attr.classes [ "fa"; "fa-plus" ]
                        ]
                    ]
                ]
            ]
        ]

    [<JSX.Component>]
    let Button isVisible dispatch classes (iconClasses: string list) =
        Html.button [
            Attr.classes [
                true, "button"
                not(isVisible()), "is-invisible"
                yield! classes
            ]
            Attr.style [
                Css.marginRight(length.px 4)
            ]
            Ev.onClick (fun ev ->
                ev.preventDefault()
                dispatch())
            Html.children [
                Html.i [
                    Attr.classes iconClasses
                ]
            ]
        ]

    [<JSX.Component>]
    let TodoEl (todo: Todo) dispatch =
        let inputRef = Solid.createRef<HTMLInputElement>()
        let isEditing() = Option.isSome todo.Editing
        let isNotEditing() = Option.isNone todo.Editing

        Solid.createEffect(fun () ->
            if isEditing() then
                inputRef.Value.select()
                inputRef.Value.focus())

        Html.li [
            Attr.className "box"

            Html.children [
                Div [ "columns" ] [
                    Div [ "column"; "is-7" ] [
                        Solid.Show(todo.Editing, (fun editing ->
                            Html.input [
                                Solid.ref inputRef
                                Attr.classes [ "input"; "is-medium" ]
                                Attr.value editing
                                Ev.onKeyUp (onEnterOrEscape (ApplyEdit >> dispatch) (fun _ -> dispatch CancelEdit))
                                Ev.onBlur (fun _ -> dispatch CancelEdit)
                            ]),
                            fallback = Html.p [
                                Attr.className "subtitle"
                                Ev.onDblClick (fun _ -> dispatch (StartEditingTodo todo.Id))
                                Attr.style [
                                    Css.userSelectNone
                                    Css.cursorPointer
                                ]
                                Html.children [
                                    Html.text todo.Description
                                ]
                            ])
                    ]

                    Div [ "column"; "is-4" ] [
                        Button isEditing (fun () -> ApplyEdit inputRef.Value.value |> dispatch)
                            [ true, "is-primary" ]
                            [ "fa"; "fa-save" ]

                        Button isNotEditing (fun () -> ToggleCompleted todo.Id |> dispatch)
                            [ todo.Completed, "is-success" ]
                            [ "fa"; "fa-check" ]

                        Button isNotEditing (fun () -> StartEditingTodo todo.Id |> dispatch)
                            [ true, "is-primary" ]
                            [ "fa"; "fa-edit" ]

                        Button isNotEditing (fun () -> DeleteTodo todo.Id |> dispatch)
                            [ true, "is-danger" ]
                            [ "fa"; "fa-times" ]
                    ]
                ]
            ]
        ]

    open Elmish.Solid

    [<JSX.Component>]
    let App() =
        let init() = init(), []
        let update msg model = update msg model, []
        let model, dispatch = Solid.createElmishStore(init, update)

        Html.fragment [
            Html.p [
                Attr.className "title"
                Html.children [
                    Html.text "Elmish.Solid To-Do List"
                ]
            ]

            InputField dispatch

            Html.ul [
                Html.children [
                    Solid.For(model.Todos, fun todo _ ->
                        TodoEl todo dispatch)
                ]
            ]
        ]

