namespace _14CatLady
{
    public class StreetExtraordinaire : Cat
    {
        public double DecibelsOfMeows { get; set; }

        public override string BreedName => "StreetExtraordinaire";

        public override string ToString()
        {
            return $"{this.BreedName} {this.Name} {this.DecibelsOfMeows}";
        }
    }
}