using System;

class Program
{
    static void Main(string[] args)
    {
        List<RoundShape> mylist = new List<RoundShape>();

        mylist.Add(new Circle(1.0));
        mylist.Add(new Cylinder(1.0,2.0));
        mylist.Add(new Sphere(1.0));

        foreach (RoundShape shape in mylist)
        {
            Console.WriteLine(shape.Area());
        }
    }
}