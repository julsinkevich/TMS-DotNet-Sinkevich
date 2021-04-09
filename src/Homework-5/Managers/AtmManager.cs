using Homework_5.Interfaces;
using Homework_5.Models;
using System;

namespace Homework_5.Managers
{
    public class AtmManager : IAtm
    {
        public delegate void AccountHandler(string message);

        public event AccountHandler Notify;

        public void ShowBalance(Card card)
        {
            if (card.Balance >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ваш баланс: {card.Balance} {card.Currency}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недостаточно средств.");
                Console.ResetColor();
            }
        }

        public void ShowInfo(Card card, User owner)
        {
            Console.WriteLine($"Добрый день, {owner.Name} {owner.Surname} " +
                $"\nCрок действия вашей карты истекает {card.ExpirationDate}" +
                $"\nТип Вашей карты {card.CardType}" +
                $"\nВаша карта: {card.IsActive.StatusToString()}");
        }

        public void GetCash(Card card, int amount)
        {
            card.Balance -= amount;
            Notify?.Invoke($"Со счета снято: {amount}.");
        }

        public void AddCash(Card card, int putmoney)
        {
            card.Balance += putmoney;
            Notify?.Invoke($"На счет поступило: {putmoney}.");
        }

        public void ToggleBlockCard(Card card)
        {
            if (!card.IsActive)
            {
                card.IsActive = true;
            }
            else
            {
                card.IsActive = false;
            }
            Console.WriteLine($"Операция выполнена успешно.");
        }

        public bool CanUserCard(Card card)
        {
            return card.IsActive;
        }
    }

    public static class ConvertStatus
    {
        public static string StatusToString(this bool status)
        {
            if (!status)
            {
                return "Неактива";
            }
            return "Активна";
        }
    }
}
