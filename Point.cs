namespace Assignment_1._1._4;

public struct Point
{
    public double X;
    public double Y;
    
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public string CompareTwoPoints(Point otherPoint)
    {
        if (X > otherPoint.X)
        {
            return "Point 1 is is to the RIGHT of Point 2 on the X-Axis";
        }
        else if (X < otherPoint.X)
        {
            return "Point 1 is is to the LEFT of Point 2 on the X-Axis";
        }
        else
        {
            return "Point 1 and Point 2 are at the same vertical location on the X-Axis";
        }
    }
}