using System;

namespace Credit_card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard monoBank = new CreditCard();
            monoBank.name = "Петро";
            monoBank.surname = "Запорожець";
            monoBank.bankName = "MonoBank";
            monoBank.cardNum = 5433334498090202;
            monoBank.SetMonth(1);
            monoBank.SetYear(23);
            monoBank.SetBalance(2.34f);
            monoBank.Print();
            monoBank.ToKnowCVV();
            monoBank.ToKnowPincode();

            Console.WriteLine("\n\nПриватна інформація");
            monoBank.PrintPrivate();

        }
    }
}
