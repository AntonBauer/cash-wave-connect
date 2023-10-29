module CashWaveConnect.Domain.NonEmptyString

type NonEmptyString = NonEmptyString of string

let createNonEmptyString (str: string) =
    if str.Length = 0
        then Some str
        else None