namespace ClassLibrary.Drawing;
using Hardware;
public class Line: Shape,IPrinter{
    Points Startpoint{set;get;}
    Points Endpoint{set;get;}

    public Line():base(){
        this.Startpoint=new Points(0,0);
        this.Endpoint=new Points(0,0);
    }
    public Line (Points p1,Points p2,string c,int w):base(c,w){
        this.Startpoint=p1;
        this.Endpoint=p2;
    }

    public override void draw(){
        Console.WriteLine("------------");
        Console.WriteLine(this);
    }

    //void IPrinter.print(){
    public void print(){
        Console.WriteLine(this);
    }

    public override string ToString(){
        return base.ToString()+" Line: "+this.Startpoint+"    "+this.Endpoint;
    }
}