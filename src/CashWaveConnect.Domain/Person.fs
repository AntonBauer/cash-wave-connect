module CashWaveConnect.Domain.Person

open CashWaveConnect.Domain.NonEmptyString

type PersonName = {
 FirstName: NonEmptyString
 LastName: NonEmptyString
}

type Person = {
 Name: PersonName
}
