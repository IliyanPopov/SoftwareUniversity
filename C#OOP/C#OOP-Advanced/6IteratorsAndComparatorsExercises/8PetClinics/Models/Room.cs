namespace _8PetClinics.Models
{
    public class Room
    {
        public Room()
        {
            this.HasPet = false;

        }

        public bool HasPet { get; set; }

        public Pet Pet { get; private set; }

        public void AddPet(Pet pet)
        {
            this.Pet = pet;
            this.HasPet = true;
        }

        public void RemovePet()
        {
            this.HasPet = false;
            this.Pet = null;
        }

        public override string ToString()
        {
            if (this.HasPet)
            {
                return $"{this.Pet.Name} {this.Pet.Age} {this.Pet.Kind}";
            }
            else
            {
                return $"Room empty";
            }
        }
    }
}