namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard()
        {

        }
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou um feitiço";

        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.Name + " lançou um feitiço forte com bonus de ataque de " + bonus;
            }
            else
            {
                return this.Name + " lançou um feitiço fraco com bonus de ataque de " + bonus;

            }

        }
    }
}