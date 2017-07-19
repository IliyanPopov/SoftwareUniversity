namespace OOPExamMinedCraft.Models.Models
{
    public abstract class Alien
    {
        private string _id;

        protected Alien(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get { return this._id; }
            private set { this._id = value; }
        }
    }
}