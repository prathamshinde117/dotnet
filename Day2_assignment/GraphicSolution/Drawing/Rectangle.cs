namespace Drawing;
public class Rectangle:Shape,IPrintable{
    public Point  Startpoint{get; set;}
    public Point  Endpoint{get; set;}

    public Rectangle(){
        this. Startpoint=new Point(0,0);
        this. Endpoint=new Point(0,0);
    }
    public Rectangle(Point p1,Point p2){
        this.Startpoint=p1;
        this. Endpoint=p2;
    }
    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type: "+t.Name);
        Console.WriteLine("("+this.Startpoint+","+this.Endpoint+")");
    }
    public void Print(){
        Console.WriteLine("Type: "+this.GetType().Name);
        Console.WriteLine("This rectangle is having only two points so we will draw it by considering it as Diagonal");
        Console.WriteLine("("+this.Width+","+Color+")");
    }

}