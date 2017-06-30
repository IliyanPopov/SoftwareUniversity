namespace _12Google
{
    using System;

    public class Car
    {
        public Car(string model, long speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; set; }

        public long Speed { get; set; }

        public override string ToString()
        {
            return $"{Environment.NewLine} {this.Model} {this.Speed}";
        }
    }
}