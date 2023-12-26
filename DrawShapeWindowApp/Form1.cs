namespace DrawShapeWindowApp;
using System.Drawing;
using ClassLibrary.Drawing;
using Hardware;

public partial class Form1 : Form
{
    Points Startpoint;
    Points Endpoint;
    public Form1()
    {
        InitializeComponent();

        //Paint += new System.Windows.Forms.PaintEventHandler(onPaint);
        MouseDown +=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp += new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

    // public void onPaint(object sender, PaintEventArgs e){
    //     // Point p1= new Point(1,2);
    //     // Point p2=new Point(2,3);
    //     // Line l= new Line(p1,p2,"blue",200);


    //     // //Pen pen=new Pen(Color.Black);
    //     // Pen pen=new Pen(Color.FromArgb(255,255,0,0));

    //     // e.Graphics.DrawLine(pen,2000,300,300,100);
    // }
    public void onMouseDown(object sender, MouseEventArgs e){
        Startpoint=new Points(e.X,e.Y);
    }

    public void onMouseUp(object sender,MouseEventArgs e){
        Endpoint=new Points(e.X,e.Y);

        Line l=new Line(Startpoint,Endpoint,"black",30);

        Pen pen=new Pen(Color.FromArgb(255,0,0,0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen, l.Startpoint.X, l.Startpoint.Y, l.Endpoint.X, l.Endpoint.Y);

    }
}
