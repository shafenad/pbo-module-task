
class Laptop
{
    private string merk;
    private string tipe;

    public Laptop(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }

    public string GetMerk()
    {
        return merk;
    }

    public string GetTipe()
    {
        return tipe;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {GetMerk()} {GetTipe()} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {GetMerk()} {GetTipe()} mati");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {GetMerk()} {GetTipe()} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Predator : Laptop
{
    private string vga;
    private string processor;

    public Predator(string merk, string tipe, string vga, string processor) : base(merk, tipe)
    {
        this.vga = vga;
        this.processor = processor;
    }

    public string GetVga()
    {
        return vga;
    }

    public string GetProcessor()
    {
        return processor;
    }
}

class Program
{
    static void Main()
    {
        Laptop laptop1 = new Laptop("Vivobook", "Core i5");
        Laptop laptop2 = new Laptop("IdeaPad", "Ryzen");


        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();


        laptop2.BermainGame();

        Predator predator = new Predator("Predator", "Core i7", "AMD", "Core i7");


        Console.WriteLine($"Merk: {predator.GetMerk()}");
        Console.WriteLine($"Tipe: {predator.GetTipe()}");
        Console.WriteLine($"VGA: {predator.GetVga()}");
        Console.WriteLine($"Processor: {predator.GetProcessor()}");
    }
}
