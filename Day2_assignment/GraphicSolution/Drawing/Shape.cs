namespace Drawing;
public enum Color{RED,GREEN,BLUE};
public abstract class Shape{
    public int Width{get; set;}
    public Color Color{get; set;}
    public abstract void Draw();
}