module Elmish.Solid

open Elmish

type Solid with
    static member createElmishStore(program: Program<'Arg, 'Model, 'Msg, unit>, arg: 'Arg) =
        let mutable storeAndDispatch = None

        program
        |> Program.withSetState (fun model dispatch ->
            match storeAndDispatch with
            | None ->
                let store, setStore = Solid.createStore(model)
                storeAndDispatch <- Some(store, setStore, dispatch)
            | Some (_store, setStore, _dispatch) ->
                Solid.reconcile model |> setStore)
        |> Program.runWith arg

        let (store, _setStore, dispatch) = Option.get storeAndDispatch
        store, dispatch

    static member createElmishStore(program: Program<unit, 'Model, 'Msg, unit>) =
        Solid.createElmishStore(program, ())

    static member createElmishStore(init: 'Arg -> 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>, arg: 'Arg) =
        Solid.createElmishStore(Program.mkProgram init update (fun _ _ -> ()), arg)

    static member createElmishStore(init: unit -> 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>) =
        Solid.createElmishStore(Program.mkProgram init update (fun _ _ -> ()))

    static member createElmishStore(init: 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>) =
        Solid.createElmishStore(Program.mkProgram (fun () -> init) update (fun _ _ -> ()))