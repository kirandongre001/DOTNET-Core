namespace ClassLibrary.Drawing;
public abstract class Shape{
    string Color{get;set;}
    int Width{get;set;}
    public Shape(){
        this.Color="Black";
        this.Width=10;
    }

    public Shape(string c,int w){
        this.Color=c;
        this.Width=w;
    }

    public abstract void draw();

    public override string ToString(){
        return "color:  "+this.Color+"  Width: "+this.Width;
    }
}