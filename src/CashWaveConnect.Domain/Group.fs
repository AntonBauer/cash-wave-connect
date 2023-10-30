module CashWaveConnect.Domain.Group

open CashWaveConnect.Domain.Helpers.NonEmptyString

type Group = {
  Name: NonEmptyString
}