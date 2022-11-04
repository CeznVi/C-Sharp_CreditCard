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

            Console.WriteLine();
            monoBank.ToKnowCVV();
            monoBank.ToKnowPincode();

            Console.WriteLine("\nПриватна інформація");
            monoBank.PrintPrivate();
            Console.WriteLine();

            CreditCard monobank1 = monoBank + 100;
            monobank1.PrintBalance();

            monobank1 += 123.11f;
            monobank1.PrintBalance();
            monobank1 -= 100.06f;
            monobank1.PrintBalance();
            
            monoBank.ToKnowCVV();

            if(monoBank == 123)
                Console.WriteLine("Ви вгадали CVV код");
            else
                Console.WriteLine("Ви не вгадали CVV код");

            if (monoBank != 123)
                Console.WriteLine("CVV код не дорівнює 123");
            else
                Console.WriteLine("CVV код дорівнює 123");

            if (monoBank > 123.43f)
                Console.WriteLine("Баланс на картці монобанку більше 123.43");
            else
                Console.WriteLine("Баланс на картці монобанку менше 123.43");

            if (monoBank < 200)
                Console.WriteLine("Баланс на картці монобанку менше 200");
            else
                Console.WriteLine("Баланс на картці монобанку більше 200");

            if(monoBank > monobank1)
                Console.WriteLine("Баланс на картці монобанку більше ніж на картці монобанк1");

            if (monoBank < monobank1)
                Console.WriteLine("Баланс на картці монобанку менше ніж на картці монобанк1");

            if (monoBank.Equals(monobank1))
                Console.WriteLine("баланс картоки монобанк == монобанк1");
            else
                Console.WriteLine("баланс карточки монобанк != монобанк1");
        }
    }
}
