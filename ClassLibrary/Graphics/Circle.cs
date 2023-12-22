namespace ClassLibrary.Drawing;
using Hardware;
public class Circle: Shape,IPrinter{
    Points Center{set;get;}
    int Radius{set;get;}

    public Circle():base(){
        this.Center=new Points(0,0);
        this.Radius=10;
    }
    public Circle(Points p1,int r,string c,int w):base(c,w){
        this.Center=p1;
        this.Radius=r;
    }

    public override void draw(){
        Console.WriteLine("Drawing circle ");
        Console.WriteLine(this);
    }

    public override string ToString(){
        return base.ToString()+" Line: "+this.Center+"    "+this.Radius;
    }

    void IPrinter.print(){//public void print()
        Console.WriteLine(this);
    }
}