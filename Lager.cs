namespace HIOF.V2025.BeerApp.BeerCLI
{
    public class Lager : Beer
    {
        public Lager(string name, double alcoholByVolume)
            : base(name, alcoholByVolume)
        {
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Type: Lager");
        }
    }
}
