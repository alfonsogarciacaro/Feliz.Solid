namespace global

open System
open Fable.Core
open Fable.Core.JsInterop

type Solid =
    [<ImportMember("solid-js/web")>]
    static member render(f: unit -> JSX.Element, el: Browser.Types.Element): unit = jsNative

    static member renderDisposable(f: unit -> JSX.Element, el: Browser.Types.Element): IDisposable =
        // HACK Solid.render actually returns a disposable function
        let disp: unit->unit = !!Solid.render(f, el)
        { new IDisposable with
            member _.Dispose() = disp() }

    [<ImportMember("solid-js")>]
    static member createSignal(value: 'T): (unit -> 'T) * ('T -> unit) = jsNative

    [<ImportMember("solid-js")>]
    static member createMemo(value: unit -> 'T): (unit -> 'T) = jsNative

    [<ImportMember("solid-js")>]
    static member createEffect(effect: unit -> unit): unit = jsNative

    [<ImportMember("solid-js")>]
    static member createEffect(effect: 'T -> 'T, initialValue: 'T): unit = jsNative

    static member createRef<'El when 'El :> Browser.Types.Element>(): 'El ref = ref Unchecked.defaultof<'El>

    static member inline ref<'El when 'El :> Browser.Types.Element>(f: 'El -> unit): JSX.Prop = "ref", f

    static member inline ref<'El when 'El :> Browser.Types.Element>(r: 'El ref): JSX.Prop = "ref", box(fun el -> r.Value <- el)

    [<ImportMember("solid-js")>]
    static member onMount(value: unit -> unit): unit = jsNative

    [<ImportMember("solid-js")>]
    static member onCleanup(value: unit -> unit): unit = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Index(each: 'T[], child: (unit -> 'T) -> int -> JSX.Element, ?fallback: JSX.Element): JSX.Element = jsNative

    static member inline Index(each: 'T list, child, ?fallback) =
        Solid.Index(List.toArray each, child, ?fallback=fallback)

    [<ImportMember("solid-js"); JSX.Component>]
    static member For(each: 'T[], child: 'T -> (unit -> int) -> JSX.Element, ?fallback: JSX.Element): JSX.Element = jsNative

    static member inline For(each: 'T list, child, ?fallback) =
        Solid.For(List.toArray each, child, ?fallback=fallback)

    [<ImportMember("solid-js"); JSX.Component>]
    static member Show(``when``: bool, child: JSX.Element): JSX.Element = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Show(``when``: 'T option, child: 'T -> JSX.Element, ?fallback: JSX.Element): JSX.Element = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Switch(children: JSX.Element list, ?fallback: JSX.Element): JSX.Element = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Match(``when``: bool, child: JSX.Element): JSX.Element = jsNative

    [<ImportMember("solid-js"); JSX.Component>]
    static member Match(``when``: 'T option, child: 'T -> JSX.Element): JSX.Element = jsNative

    [<ImportMember("solid-js/store")>]
    static member createStore(store: 'T): 'T * ('T -> unit) = jsNative

    [<ImportMember("solid-js/store")>]
    static member reconcile(store: 'T): 'T = jsNative

    [<ImportMember("solid-js/store")>]
    static member unwrap(store: 'T): 'T = jsNative
