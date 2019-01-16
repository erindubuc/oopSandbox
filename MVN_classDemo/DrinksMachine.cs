using System;
namespace MVN_demo
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = _location;
            this.Make = _make;
            this.Model = _model;
        }

        private string _location;
        private string _make;
        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        // statements to declare public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeEspresso()
        {
            // Method logic goes here
        }
    }
}
