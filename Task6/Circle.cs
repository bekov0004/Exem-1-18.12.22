public class Circle
{
    double S,D,C,R,r;
    private const double PI=3.14; 
    
    public Circle(double r)
    {
     this.r = r;
    }
public double GetArea()
{
  return PI * r*2;

}
public double GetDiameter()
{
return 2 * r;
 
}
public double GetCircumference()
{
return 2* PI * r;
 
}
public double GetRadius()
{
return ((2*r)/2);
 
}

}