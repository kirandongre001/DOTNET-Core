namespace Hardware;

public class HPprinter:IPrinter,IScanner{
    public void print(){
        Console.WriteLine("Printing!!!!!!");
    }

    public void scan(){
        Console.WriteLine("Scanning!!!!!");
    }
}