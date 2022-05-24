module Elmish.Solid

open Elmish

type Solid with
    /// Initialize a SolidJS store using an Elmish program: https://www.solidjs.com/tutorial/stores_nested_reactivity
    /// SolidJS can optimize updates for plain JS objects and arrays in the store, so you can provide a projection
    /// to do this transformation (e.g. convert records into anonymous records and lists into arrays)
    static member createElmishStore(program: Program<unit, 'Model, 'Msg, unit>, projection: 'Model -> 'ViewModel): 'ViewModel * ('Msg -> unit) =
        let mutable dispatch' = Unchecked.defaultof<_>
        let model, cmd = Program.init program ()
        let store, setStore = model |> projection |> Solid.createStore

        program
        |> Program.map (fun _ _ -> model, cmd) id id id id id
        |> Program.withSetState (fun model dispatch ->
            dispatch' <- dispatch
            model |> projection |> Solid.reconcile |> setStore.Update)
        |> Program.run

        store.Value, dispatch'

    /// Initialize a SolidJS store using an Elmish program: https://www.solidjs.com/tutorial/stores_nested_reactivity
    /// SolidJS can optimize updates for plain JS objects and arrays in the store, so you can provide a projection
    /// to do this transformation (e.g. convert records into anonymous records and lists into arrays)
    static member createElmishStore(init: unit -> 'Model * Cmd<'Msg>, update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>, projection: 'Model -> 'ViewModel) =
        Solid.createElmishStore(Program.mkProgram init update (fun _ _ -> ()), projection)
