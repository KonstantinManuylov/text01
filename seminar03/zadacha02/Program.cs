// вход координаты X и Y двух точек. выход - расстояние между ними.
// А (3, 6), В (2, 1) -> 5.09; А (7, -5), В (1, -1) -> 7.21;
int dotAX = Coordinate("X",  "A");
int dotAY = Coordinate("Y",  "A");
int dotBX = Coordinate("X",  "B");
int dotBY = Coordinate("Y",  "B");
int cathetus1 = dotAX - dotBX;
int cathetus2 = dotAY - dotBY;
double hypotenuse = Math.Sqrt((cathetus1 * cathetus1) + (cathetus2 * cathetus2));
Console.WriteLine(Math.Round(hypotenuse, 3));

int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} для точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}