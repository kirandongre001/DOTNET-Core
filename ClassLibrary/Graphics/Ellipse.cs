namespace ClassLibrary.Drawing;
using Hardware;
public class Ellipse: Shape,IPrinter{
    Points Startpoint{set;get;}
    Points Endpoint{set;get;}

    public Ellipse():base(){
        this.Startpoint=new Points(0,0);
        this.Endpoint=new Points(0,0);
    }
    public Ellipse(Points p1,Points p2,string c,int w):base(c,w){
        this.Startpoint=p1;
        this.Endpoint=p2;
    }

    public override void draw(){
        Console.WriteLine("------------");
        Console.WriteLine(this);
    }

    public override string ToString(){
        return base.ToString()+" Ellipse: "+this.Startpoint+"    "+this.Endpoint;
    }

    void IPrinter.print(){//public void print()
        Console.WriteLine(this);
    }
}