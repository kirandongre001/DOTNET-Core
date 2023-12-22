namespace ClassLibrary.Drawing;

public class Points
{
    int X{set;get;}
    int Y{set;get;}

    public Points(){
        this.X=0;
        this.Y=0;
    }
    public Points(int x,int y){
        this.X=x;
        this.Y=y;
    }

    public override string ToString(){
        return "Point:"+"("+this.X+","+this.Y+")";
    }

}
