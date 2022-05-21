module App

open Browser
open Feliz.JSX
open Fable.Core
open Components

// Entry point must be in a separate file
// for Vite Hot Reload to work

[<JSX.Component>]
let Tab(tab: string, activeTab, setActiveTab) =
    Html.li [
        Attr.classes [tab = activeTab(), "is-active"]
        Html.children [
            Html.a [
                Ev.onClick (fun ev ->
                    ev.preventDefault()
                    tab |> setActiveTab
                )
                Html.children [
                    Html.text tab
                ]
            ]
        ]
    ]

[<JSX.Component>]
let Tabs() =
    let activeTab, setActiveTab = Solid.createSignal("Sketch")
    Html.fragment [
        Html.div [
            Attr.className "tabs"
            Attr.style [
                Css.marginBottom (length.rem 0.5)
            ]
            Html.children [
                Html.ul [
                    Html.children [
                        Tab("Counter", activeTab, setActiveTab)
                        Tab("Styles", activeTab, setActiveTab)
                        Tab("Sketch", activeTab, setActiveTab)
                        Tab("TodoMVC", activeTab, setActiveTab)
                    ]
                ]
            ]
        ]
        Html.div [
            Attr.style [
                Css.margin (length.zero, length.auto)
                Css.maxWidth 800
                Css.padding 20
            ]
            Html.children [
                Solid.Switch([
                    Solid.Match(activeTab() = "Counter", Counter())
                    Solid.Match(activeTab() = "Styles", Styles())
                    Solid.Match(activeTab() = "Sketch", Sketch.App(10.))
                    Solid.Match(activeTab() = "TodoMVC", TodoMVC.App())
                ])
            ]
        ]
    ]

Solid.render(Tabs, document.getElementById("app-container"))
