// ts2fable 0.6.1
module rec Fable.Import.SyncFusion.Calendar
open System
open Fable.Core
open Fable.Import.JS
open Fable.AST.Fable
open Fable.Helpers.React
open Fable.Import.React
open Fable.Core.JsInterop

type CalendarProps =
  | Id of string


let inline DatePickerComponent (props : CalendarProps list) (elems : ReactElement list) : ReactElement =
    import "DatePickerComponent" "@syncfusion/ej2-react-calendars" (keyValueList CaseRules.LowerFirst props) elems