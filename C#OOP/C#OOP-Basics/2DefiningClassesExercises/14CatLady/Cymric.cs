namespace _14CatLady
{
    public class Cymric : Cat
    {
        public double FurLenght { get; set; }

        public override string BreedName => "Cymric";

        public override string ToString()
        {
            return $"{this.BreedName} {this.Name} {this.FurLenght:F2}";
        }
    }
}