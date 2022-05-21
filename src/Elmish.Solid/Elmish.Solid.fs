module Elmish.Solid

open Elmish

// TODO: Return a termination handle

type Solid with
    /// Initialize a SolidJS store using an Elmish program: https://www.solidjs.com/tutorial/stores_nested_reactivity
    /// SolidJS can optimize updates for plain JS objects and arrays in the store, so you can provide a projection
    /// to do this transformation (e.g. convert records into anonymous records and lists into arrays)
    static member createElmishStore(program: Program<'Arg, 'Model, 'Msg, unit>, projection: 'Model -> 'ViewModel, arg: 'Arg) =
        let mutable dispatch' = Unchecked.defaultof<_>
        let model, cmd = Program.init program arg
        let store, setStore = model |> projection |> Solid.createStore

        program
        |> Program.map (fun _ _ -> model, cmd) id id id id id
        |> Program.withSetState (fun model dispatch ->
            dispatch' <- dispatch
            model |> projection |> Solid.reconcile |> setStore)
        |> Program.runWith arg

        store, dispatch'

    /// Initialize a SolidJS store using an Elmish program: https://www.solidjs.com/tutorial/stores_nested_reactivity
    /// SolidJS can optimize updates for plain JS objects and arrays in the store, so you can provide a projection
    /// to do this transformation (e.g. convert records into anonymous records and lists into arrays)
    static member createElmishStore(init: 'Arg -> 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>, projection, arg: 'Arg) =
        Solid.createElmishStore(Program.mkProgram init update (fun _ _ -> ()), projection, arg)

    /// Initialize a SolidJS store using an Elmish program: https://www.solidjs.com/tutorial/stores_nested_reactivity
    /// SolidJS can optimize updates for plain JS objects and arrays in the store, so you can provide a projection
    /// to do this transformation (e.g. convert records into anonymous records and lists into arrays)
    static member createElmishStore(init: unit -> 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>, projection) =
        Solid.createElmishStore(Program.mkProgram init update (fun _ _ -> ()), projection, ())
