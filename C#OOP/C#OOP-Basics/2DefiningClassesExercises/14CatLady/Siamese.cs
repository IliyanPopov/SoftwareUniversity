namespace _14CatLady
{
    public class Siamese : Cat
    {
        public double EarSize { get; set; }
        public override string BreedName => "Siamese";

        public override string ToString()
        {
            return $"{this.BreedName} {this.Name} {this.EarSize}";
        }
    }
}