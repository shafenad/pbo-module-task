
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
        laptop1.Ngoding();


        laptop2.BermainGame();

        Predator predator = new Predator("Predator", "Core i7", "AMD", "Core i7");
        predator.BermainGame();



        Console.WriteLine($"Merk: {predator.GetMerk()}");
        Console.WriteLine($"Tipe: {predator.GetTipe()}");
        Console.WriteLine($"VGA: {predator.GetVga()}");
        Console.WriteLine($"Processor: {predator.GetProcessor()}");
    }
}



// code nomor 3
class Laptop
{
    private string merk;
    private string tipe;
    private string vga;
    private string processor;

    public Laptop(string merk, string tipe, string vga, string processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public string GetMerk()
    {
        return merk;
    }

    public string GetTipe()
    {
        return tipe;
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
        // Membuat objek laptop1 dan mengisi spesifikasi
        Laptop laptop1 = new Laptop("Vivobook", "Core i5", "Nvidia", "Intel Core i5");

        // Menampilkan spesifikasi laptop1
        Console.WriteLine($"Merk: {laptop1.GetMerk()}");
        Console.WriteLine($"VGA: {laptop1.GetVga()}");
        Console.WriteLine($"Merk Processor: {laptop1.GetProcessor()}");
        Console.WriteLine($"Tipe Processor: {laptop1.GetTipe()}");
    }
}
