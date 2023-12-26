namespace DrawShapeWindowApp;
using Hardware;
using ClassLibrary.Drawing;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        Point p1= new Point(1,2);
        Point p2=new Point(2,3);

        Line l= new Line(p1,p2,"blue",200);

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}