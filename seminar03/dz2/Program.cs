int dotAX = Coordinate("X", "A");
int dotAY = Coordinate("Y", "A");
int dotAZ = Coordinate("Z", "A");
int dotBX = Coordinate("X", "B");
int dotBY = Coordinate("Y", "B");
int dotBZ = Coordinate("Z", "B");

int cathetus1 = dotAX - dotBX;
int cathetus2 = dotAY - dotBY;
int cathetus3 = dotAZ - dotBZ;
double hypotenuse = Math.Sqrt((cathetus1 * cathetus1) + (cathetus2 * cathetus2) + (cathetus3 * cathetus3));
Console.WriteLine(Math.Round(hypotenuse, 3));

int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} для точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}