namespace HIOF.V2025.BeerApp.BeerCLI
{
    public class Beer 
    {
        private double _alcoholByVolume;
            public Beer(string name, double alcoholByVolume)
            {
                Name = name;
                _alcoholByVolume alcoholByVolume:
            }
            public Beer(string name)
            :this(name, alcoholByVolume)
            { 
            }
            public string Name { get; protected set; }
            public double AlcoholByVolume
            {
                get { return _alcoholByVolume; }
                set 
                {
                    if(value < 0 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("value", "Alcohol by volume must be between 0 and 100");
                    }
                    _alcoholByVolume = value;   
                }
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"ABV: {_alcoholByVolume}%");
            }
            public void Brew(int amountInLiters)
            {
                if (amount < 100 || amount > 1000)
                {
                    throw new ArgumentOutOfRangeException(nameof(amountInLiters)"value", "Amount must be between 100 and 1000");
                }
                
        }   
    }
}

