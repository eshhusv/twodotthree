using twodotthree;

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());

Solution solution = new Solution(x, y);

Console.WriteLine(solution.isPointLies());