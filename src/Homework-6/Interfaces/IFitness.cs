namespace Homework_6.Interfaces
{
    internal interface IFitness
    {
        public int GetSteps();

        public int GetPulse();

        public int Water(int water);

        public void RunType();

        public void ShowDayActivity(int water);
    }
}
