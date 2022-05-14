
namespace FinalExam
{
    internal class Elevator
    {

        private double MaxWeight;
        private Elevator[] Occupants;


        public Elevator(double maxWeight, int maxOccupants)
        {

            this.MaxWeight = maxWeight;
            this.Occupants = new Elavator[maxOccupants];
        }
        public AddOccupent(Passenger passenger, int index);

        public GetCurrentWeight() { return; }

        IsOverMaxCapacity(double maxWeight) { return MaxWeight}

    }
}