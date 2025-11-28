using System;
using System.Collections.Generic;

class Sphere : IComparable<Sphere>
{
    private double radius;

    public double Radius
    {
        get => radius;
        set
        {
            if (value <= 0) throw new ArgumentException("Radius must be positive.");
            radius = value;
        }
    }

    public double Diameter
    {
        get => 2 * radius;
        set
        {
            if (value <= 0) throw new ArgumentException("Diameter must be positive.");
            radius = value / 2;
        }
    }

    public Sphere(double radius) => Radius = radius;

    public double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    public double SurfaceArea => 4 * Math.PI * Math.Pow(Radius, 2);

    public override string ToString() =>
        $"Sphere: Radius = {Radius:F2}, Diameter = {Diameter:F2}, Volume = {Volume:F2}, Surface Area = {SurfaceArea:F2}";

    public static Sphere operator +(Sphere a, Sphere b) => new Sphere(a.Radius + b.Radius);
    public static bool operator >(Sphere a, Sphere b) => a.Volume > b.Volume;
    public static bool operator <(Sphere a, Sphere b) => a.Volume < b.Volume;
    public static bool operator ==(Sphere a, Sphere b) => a?.Radius == b?.Radius;
    public static bool operator !=(Sphere a, Sphere b) => !(a == b);

    public override bool Equals(object obj) => obj is Sphere s && this.Radius == s.Radius;
    public override int GetHashCode() => Radius.GetHashCode();

    public int CompareTo(Sphere other) => this.Radius.CompareTo(other.Radius);

    public void Scale(double factor)
    {
        if (factor <= 0) throw new ArgumentException("Scale factor must be positive.");
        Radius *= factor;
    }
}

class Program
{
    static void Main()
    {
        List<Sphere> spheres = new List<Sphere>
        {
            new Sphere(3),
            new Sphere(5),
            new Sphere(2)
        };

        spheres.ForEach(s => Console.WriteLine(s));

        Sphere sumSphere = spheres[0] + spheres[1];
        Console.WriteLine($"\nSum of first two spheres: {sumSphere}");

        Console.WriteLine($"\nSphere 1 > Sphere 2? {spheres[0] > spheres[1]}");
        Console.WriteLine($"Sphere 1 == Sphere 3? {spheres[0] == spheres[2]}");

        spheres[0].Scale(2);
        Console.WriteLine($"\nScaled Sphere 1 by 2: {spheres[0]}");
        spheres.Sort();
        Console.WriteLine("\nSpheres sorted by radius:");
        spheres.ForEach(s => Console.WriteLine(s));
    }
}
