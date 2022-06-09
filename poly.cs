using System;
class program
{
    public class Printer
       
    {
        public virtual void show()
        {
            Console.WriteLine("Display dimension: ");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer printing");
        }
    }
    public class epson : Printer
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer printing.....");
        }
    }
    public class canon: Printer
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Canon printer printing.....");
        }
    }
    public class laserjet : Printer
    {
        public override void show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public override void print()
        {
            Console.WriteLine("Laserjet printer printing.....");
        }
    }
    static void Main(string[] args)
    {
        Printer printer = new Printer() ;

        Console.WriteLine("Pilih Printer: ");
        Console.WriteLine("1. Epson: ");
        Console.WriteLine("2. Canon: ");
        Console.WriteLine("3. Laserjet: ");

        Console.WriteLine("Nomor printer[1..3]: ");
        int nomorprinter = Convert.ToInt32(Console.ReadLine());

        if (nomorprinter == 1)
            printer = new epson();
        else if (nomorprinter == 2)
            printer = new canon();
        else if (nomorprinter == 3)
            printer = new laserjet();
        else
            Console.WriteLine("Pilihan tidak tersedia!");
        printer.show();
        printer.print();

        Console.ReadKey();
    }
}
