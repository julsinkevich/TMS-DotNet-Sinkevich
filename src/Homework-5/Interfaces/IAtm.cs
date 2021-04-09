using Homework_5.Models;

namespace Homework_5.Interfaces
{
    internal interface IAtm
    {
        public void ShowBalance(Card card);

        public void GetCash(Card card, int amount);

        public void AddCash(Card card, int putmoney);

        public void ToggleBlockCard(Card card);

        public bool CanUserCard(Card card);
    }
}
