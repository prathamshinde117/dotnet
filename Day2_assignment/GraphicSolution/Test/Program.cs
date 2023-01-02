using Drawing;
Point p1=new Point(10,15);
Point p2=new Point(25,30);
Point p3=new Point(120,140);
Point p4=new Point(180,250);
Shape shape1=new Line(p1,p2);
Shape shape2=new Rectangle(p3,p4);
Shape shape3=new Circle(p1,5);

List<Shape> shapes=new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);
foreach(Shape s in shapes){
    s.Draw();
    IPrintable obj=(IPrintable)s;
    obj.Print();
}





