module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fable.Import.SyncFusion.Calendar

let root model dispatch =
  
  div
    [ ]
    [ p
        [ ClassName "control" ]
        [ input
            [ ClassName "input"
              Type "text"
              Placeholder "Type your name"
              DefaultValue model.Name
              Value model.Name
              AutoFocus true
              OnChange (fun ev -> !!ev.target?value |> ChangeStr |> dispatch ) ] 
          input
            [ ClassName "input"
              Type "text"
              Placeholder "Type your shout"
              DefaultValue model.Shout
              AutoFocus true
              OnChange (fun ev -> !!ev.target?value |> DoubleStr |> dispatch ) ]             
              ]
      DatePickerComponent [Id "lolo"] []           
      br [ ]
      span
        [ ClassName "myCT" ]
        [ str (sprintf "hola %s , %s!!! time %s" (model.Name) (model.Shout) (System.DateTime.Now.ToString("HH:mm ss")) ) ] ]
