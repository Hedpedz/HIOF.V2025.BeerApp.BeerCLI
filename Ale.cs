namespace HIOF.V2025.BeerApp.BeerCLI
{
    public class Ale : Beer
    {
        public Ale(string name) 
        : base(name)
        {
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Type: Ale");
        }
    }
}
