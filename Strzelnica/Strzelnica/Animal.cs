namespace Strzelnica
{
    public class Animal
    {
        public string Type { get; set; }
        public int Hunted { get; set; }
    

        public void Hunt (int amount)
        {
            this.Hunted = this.Hunted + amount;
        }
    }
}
