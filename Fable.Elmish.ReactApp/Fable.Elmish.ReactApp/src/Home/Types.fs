module Home.Types

type Model=  { 
  Name: string
  Shout: string
}

type Msg =
  | DoubleStr of string
  | ChangeStr of string
