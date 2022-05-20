namespace global

open System
open Fable.Core
open Fable.Core.JsInterop

type Signal<'T> = unit -> 'T

type Solid =
    // [<ImportDefault("solid-js/h")>]
    // static member h(tag: obj, attrs: obj, [<ParamSeq>] children: JSX.Element seq): JSX.Element = jsNative

    // static member inline text(text: string): JSX.Element = unbox text

    [<ImportMember("solid-js/web")>]
    static member render(f: unit -> JSX.Element, el: Browser.Types.Element): unit = jsNative

    static member renderDisposable(f: unit -> JSX.Element, el: Browser.Types.Element): IDisposable =
        // HACK Solid.render actually returns a disposable function
        let disp: unit->unit = !!Solid.render(f, el)
        { new IDisposable with
            member _.Dispose() = disp() }

    [<ImportMember("solid-js")>]
    static member createSignal(value: 'T): Signal<'T> * ('T -> unit) = jsNative

    [<ImportMember("solid-js")>]
    static member createMemo(value: unit -> 'T): Signal<'T> = jsNative

    [<ImportMember("solid-js")>]
    static member onCleanup(value: unit -> unit): unit = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Index(each: 'T[], fallback: JSX.Element, child: (unit -> 'T) -> int -> JSX.Element): JSX.Element = jsNative

    // [<ImportMember("solid-js")>]
    // static member For: obj = jsNative
