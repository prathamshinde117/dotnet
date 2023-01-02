namespace Drawing;
public class Line:Shape,IPrintable
{
      public Point  Startpoint{get; set;}
    public Point  Endpoint{get; set;}

    public Line(){
        this. Startpoint=new Point(0,0);
        this. Endpoint=new Point(0,0);
    }
    public Line(Point p1,Point p2){
        this.Startpoint=p1;
        this. Endpoint=p2;
    }
    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type:"+t.Name);
        Console.WriteLine("("+Startpoint+","+Endpoint+")");
    }
    public void Print(){
        Console.WriteLine("Type "+this.GetType().Name);
        Console.WriteLine("Its Line bro!!!");

    }

}
