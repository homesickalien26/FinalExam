
namespace FinalExam
{
    internal class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;

        }
        public string getName() { return Name; }
        public double getWeight() { return Weight; }

    }
}
