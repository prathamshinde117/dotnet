namespace Drawing;
public class Circle :Shape,IPrintable{
    public Point center{get; set;}
    public int radius{get; set;}

    public Circle(Point p1,int r){
        this.center=p1;
        this.radius=r;
    }
    public Circle(){
        this.center=new Point(0,0);
        this.radius=5;
    }
    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type: "+t.Name);
        Console.WriteLine("Center("+this.center+")"+" radius="+this.radius);
    }
    public void Print(){
        Type t=this.GetType();
        Console.WriteLine("Type: "+t.Name);
        Console.WriteLine("learning interface of dotnet using class Circle");
    }
}