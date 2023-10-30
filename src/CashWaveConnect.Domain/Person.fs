module CashWaveConnect.Domain.Person

open CashWaveConnect.Domain.Helpers.NonEmptyString


type PersonName = {
 FirstName: NonEmptyString
 LastName: NonEmptyString
}

type Person = {
 Name: PersonName
}
