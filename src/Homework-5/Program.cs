using Homework_5.Enums;
using Homework_5.Managers;
using Homework_5.Models;
using System;
using System.Runtime.CompilerServices;

namespace Homework_5
{
    public class Program
    {
        public static AtmManager atmManager = new AtmManager();
        public static Card CreateCard(User owner, decimal balance, CurrencyType currency = CurrencyType.Byn, PaymentSystemType cardtype = PaymentSystemType.MasterCard)
        {
            var card = new Card();

            card.ExpirationDate = DateTime.Now.AddDays(365);
            card.Balance = balance;
            card.Currency = currency;
            card.Owner = owner;
            card.CardType = cardtype;

            return card;
        }
        public static User CreateOwner(string name, string surname)
        {
            var owner = new User();

            owner.Name = name;
            owner.Surname = surname;

            return owner;
        }
        public static void Main(string[] args)
        {

            ShowMenu();
            
            Console.ReadKey();
        }
        public static void Operations(Card card)
        {
            ShowCardOperation();
            int.TryParse(Console.ReadLine(), out int userInput1);
            switch (userInput1)
            {
                case 0:
                    {
                        Environment.Exit(0);
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Введите снимаемую сумму:");
                        int withdrawnamount = Convert.ToInt32(Console.ReadLine());
                        Subscription();
                        atmManager.GetCash(card, withdrawnamount);
                        atmManager.ShowBalance(card);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Введите добавляемую сумму:");
                        int putmoney = Convert.ToInt32(Console.ReadLine());
                        Subscription();
                        atmManager.AddCash(card, putmoney);
                        atmManager.ShowBalance(card);
                    }
                    break;
                case 3:
                    {
                        ShowMenu();
                    }
                    break;
            }
        }
        public static void Subscription()
        {
            EventsAction();
            int.TryParse(Console.ReadLine(), out int userInput3);
            switch (userInput3)
            {
                case 0:
                    {
                        Environment.Exit(0);
                    }
                    break;
                case 1:
                    {
                        atmManager.Notify -= ShowMessage;

                    }
                    break;
                case 2:
                    {
                        atmManager.Notify += ShowMessage;
                    }
                    break;
            }
        }
        private static void ShowMenu()
        {
            Console.WriteLine("Выберите карту:");
            Console.WriteLine("Карта 1.");
            Console.WriteLine("Карта 2.");
            Console.WriteLine("Карта 3.");
            Console.WriteLine("0.Выход.");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out int userInput);

            var owner = CreateOwner("Vladimir", "Stsko");
            
            switch (userInput)
            {
                case 0:
                    {
                        Environment.Exit(0);
                    }
                    break;
                case 1:
                    {
                        var card = CreateCard(owner, 10);
                        atmManager.ShowInfo(card, owner);
                        atmManager.ShowBalance(card);
                        Operations(card);
                    }
                   break;
               case 2:
                    {
                        var card = CreateCard(owner, 100, CurrencyType.Euro, PaymentSystemType.MasterCard);
                        atmManager.ShowInfo(card, owner);
                        atmManager.ShowBalance(card);
                        Operations(card);
                    }
                    break;
                case 3:
                    {
                        var card = CreateCard(owner, 77, CurrencyType.Usd, PaymentSystemType.Visa);
                        atmManager.ShowInfo(card, owner);
                        atmManager.ShowBalance(card);
                        Operations(card);
                    }
                    break;
                }
            }
        private static void ShowCardOperation()
        {
            Console.WriteLine();
            Console.WriteLine("Операции:");
            Console.WriteLine("1.Снять деньги.");
            Console.WriteLine("2.Добавить сумму.");
            Console.WriteLine("3.Вернуться в главное меню.");
            Console.WriteLine("0.Выход.");
            Console.WriteLine();
        }
        public static void ShowMessage(string message) 
        {
            Console.WriteLine(message);
        }
        private static void EventsAction()
        {
            Console.WriteLine();
            Console.WriteLine("1.Отказаться от получения сообщения об изменении остатка.");
            Console.WriteLine("2.Подписаться от получения сообщения об изменении остатка.");
            Console.WriteLine("0.Выход.");
            Console.WriteLine();
        }
    }
}
