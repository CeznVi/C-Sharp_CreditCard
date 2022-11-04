using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Credit_card
{
    internal class CreditCard
    {
        //публічні змінні
        public string name { get; set; }
        public string surname { get; set; }
        public string bankName { get; set; }
        public long cardNum { get; set; }
        public bool isBlock { get; set; } = false;
        //приватні змінні
        private int month;
        private int year;
        private int cvv;
        public int pincode;
        private float balance;

        //конструктор без параметрів
        public CreditCard()
        {
            balance = 0;
            cvv = SetCvv();
            pincode = SetPincode();
        }

        //Метод приватні генерації 
        static private int SetCvv()
        {
            Random rand = new Random();
            int c = rand.Next(100, 999);
            return c;
        }
        static private int SetPincode()
        {
           
            Random rand = new Random();
            int t = rand.Next(1000, 9999);           
            return t;
        }

        //Cетери публічних полів
        public void SetMonth(int m)
        {
            if (m >= 1 && m <= 12)
                month = m;
            else
                month = -1;
        }
        public void SetYear(int m)
        {
            if (m >= 1 && m <= 99)
                year = m;
            else
                year = -1;
        }
        public void SetBalance(float m) { balance = m; }

        //Гетери приватних полів
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
        public float GetBalance() { return balance; }

        //Метод перевірки балансу на картці
        public void CheckBalance() { Console.WriteLine($"Баланс на картці: {GetBalance()}"); }
        //Метод дізнатися СVV
        public void ToKnowCVV()
        {
            Console.WriteLine("Нікому не давайте цєй код");
            Console.WriteLine($"СVV: {cvv}");
        }
        //Метод дізнатися pincode
        public void ToKnowPincode()
        {
            Console.WriteLine("Нікому не давайте цєй код");
            Console.WriteLine($"Pincode: {pincode}");
        }

        //Метод показати інформацію публічну
        public void Print()
        {
            Console.WriteLine($"Банк : {bankName}");
            Console.WriteLine($"Номер кредитної карти : {cardNum}");
        }
        //Метод показати ВСЮ інформацію публічну + приватну
        public void PrintPrivate()
        {
            Print();
            Console.WriteLine($"Срок дії: {month}/{year}");
            Console.WriteLine($"Заблокована: {isBlock}");
            Console.WriteLine($"Баланс на карті: {balance}");
            Console.WriteLine($"Власник: {name} {surname}");
        }
        //Метод друку балансу по карті
        public void PrintBalance()
        {
            Console.WriteLine($"Баланс на карті: {balance}");
        }

        ////Перевантаження операторів
        //+ (для збільшення суми грошей на вказану кількість),
        public static CreditCard operator +(CreditCard card, int i)
        {
            return new CreditCard() { balance = card.balance + i };
        }
        public static CreditCard operator +(CreditCard card, float f)
        {
            return new CreditCard() { balance = card.balance + f };
        }
        //– (для зменшення суми грошей на вказану кількість),
        public static CreditCard operator -(CreditCard card, int i)
        {
            return new CreditCard() { balance = card.balance - i };
        }
        public static CreditCard operator -(CreditCard card, float f)
        {
            return new CreditCard() { balance = card.balance - f };
        }
        //== !=(перевірка на рівність CVV коду), Equals
        public static bool operator ==(CreditCard card1, int cvv)
        {
            return (card1.cvv == cvv);
        }
        public static bool operator !=(CreditCard card1, int cvv)
        {
            return !(card1.cvv == cvv);
        }
        public bool Equals(CreditCard card1)
        {
            return (card1.balance == balance);
        }
        public override bool Equals(object obj)
        {
            return  (obj as CreditCard).balance == balance;
        }

        //< і > (перевірка на меншу чи більшу кількість суми грошей)
        public static bool operator <(CreditCard card1, int balance)
        {
            return (card1.balance < balance);
        }
        public static bool operator >(CreditCard card1, int balance)
        {
            return (card1.balance > balance);
        }
        public static bool operator <(CreditCard card1, float balance)
        {
            return (card1.balance < balance);
        }
        public static bool operator >(CreditCard card1, float balance)
        {
            return (card1.balance > balance);
        }
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return (card1.balance < card2.balance);
        }
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return (card1.balance > card2.balance);
        }

    }
}
