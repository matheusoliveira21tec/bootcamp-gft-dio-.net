namespace RPG.src.Entities
{
    public class Hero
    {
        public Hero()
        {

        }
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public int Level;
        public string HeroType;
        public string Name;
        public override string ToString()
        {
            return this.Name + " " + this.HeroType + " " + this.Level;
        }
        public virtual string Attack(){
            return this.Name + " atacou com sua espada";
        }

    }
}