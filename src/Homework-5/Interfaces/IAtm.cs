using Homework_5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Interfaces
{
    interface IAtm
    {
        public void ShowBalance(Card card);
        public void GetCash(Card card, int amount);
        public void AddCash(Card card, int putmoney);
        public void BlockCard(Card card);
    }
}
