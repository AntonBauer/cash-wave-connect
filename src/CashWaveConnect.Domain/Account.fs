module CashWaveConnect.Domain.Account

open CashWaveConnect.Domain.Helpers.Email

type Iban = Iban of string

type BankAccount = {
   Iban: Iban
}

type PayPal = {
   Email: Email
}

type Account =
   | BankAccount
   | PayPal