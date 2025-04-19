// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

Classes();
Structs();
Records();

static void Classes()
{
    Console.WriteLine("=================Classes=================");
    CPoint p1 = new CPoint { X = 7, Y = 3 };
    CPoint p2 = p1;
    p2.X = 8;
    Console.WriteLine($"P1 = P2: {p1 == p2}.");

    CPoint p3 = new CPoint { X = 7, Y = 3 };

    Console.WriteLine($"P1 = P3: {p1 == p3}.");
    Console.WriteLine();

    // classes are compared for the reference
}

static void Structs()
{
    Console.WriteLine("=================Structs=================");
    SPoint p1 = new SPoint { X = 7, Y = 3 };
    SPoint p2 = p1;

    Console.WriteLine($"P1 = P2: {p1.Equals(p2)}.");

    SPoint p3 = new SPoint { X = 7, Y = 3 };

    Console.WriteLine($"P1 = P3: {p1 == p3}.");
    Console.WriteLine();

    // structs are compared for the value
}

static void Records()
{
    Console.WriteLine("=================Records=================");
    RPoint p1 = new RPoint(7, 3);
    RPoint p2 = p1;

    Console.WriteLine($"P1 = P2: {p1 == p2}.");

    RPoint p3 = new RPoint(7, 3);

    Console.WriteLine($"P1 = P3: {p1 == p3}.");

    // The records follow that value equality by default as structs. So their operator for
    // the equality check or inequality check is value-based not reference-based as in classes.
}