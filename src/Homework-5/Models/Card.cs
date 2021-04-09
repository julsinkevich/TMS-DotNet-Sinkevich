using Homework_5.Enums;
using System;

namespace Homework_5.Models
{
    public class Card
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public PaymentSystemType CardType { get; set; }
        public DateTime ExpirationDate { get; set; }
        public User Owner { get; set; }
        public decimal Balance { get; set; }
        public CurrencyType Currency { get; set; }
        public bool IsActive { get; set; }
    }
}
