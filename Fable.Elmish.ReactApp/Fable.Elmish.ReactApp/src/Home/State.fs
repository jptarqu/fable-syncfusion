module Home.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  {Name = ""; Shout = "" }, []

let update msg model : Model * Cmd<Msg> =
  match msg with
  | ChangeStr str ->
      { model with Name = str } , []
  | DoubleStr str ->
      { model with Shout = str.ToUpper() }  , []
