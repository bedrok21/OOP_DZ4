using Task4_2;

namespace Task4_2
{
    internal class Program
    {
        private static bool AddObject(List<IGeographicObject> objects, string? type)
        {
            try
            {
                switch (type)
                {
                    case "River":
                        River river = new River();
                        double speed;
                        double length;
                        double highPoint;
                        InputGeneralInfo(river);
                        Console.Write("Input Stream Speed: ");
                        if (double.TryParse(Console.ReadLine(), out speed)) river.SetStreamSpeed(speed);
                        else throw new InvalidDataException();
                        Console.Write("Input River Length: ");
                        if (double.TryParse(Console.ReadLine(), out length)) river.SetRiverLength(length);
                        else throw new InvalidDataException();
                        objects.Add(river);
                        return true;
                    case "Mount":
                        Mount mount = new Mount();
                        InputGeneralInfo(mount);
                        Console.Write("Input Highest Point: ");
                        if (double.TryParse(Console.ReadLine(), out highPoint)) mount.SetHighestPoint(highPoint);
                        else throw new InvalidDataException();
                        objects.Add(mount);
                        return true;
                    default:
                        Console.WriteLine("Not valid type");
                        return false;
                }
            }
            catch (InvalidDataException)
            {
                Console.WriteLine("Input double value!");
                return false;
            }
        }
        private static void InputGeneralInfo(IGeographicObject geographicObject)
        {
            double x;
            double y;
            Console.WriteLine("Input Coordinates:");
            Console.Write("X = ");
            if (double.TryParse(Console.ReadLine(), out x)) geographicObject.SetCoordinateX(x);
            else throw new InvalidDataException();
            Console.Write("Y = ");
            if (double.TryParse(Console.ReadLine(), out y)) geographicObject.SetCoordinateY(y);
            else throw new InvalidDataException();
            Console.Write("Input Name: ");
            geographicObject.SetName(Console.ReadLine());
            Console.Write("Input Description: ");
            geographicObject.SetDescription(Console.ReadLine());
        }
        private static void Main(string[] args)
        {
            List<IGeographicObject> objects = new List<IGeographicObject>();
            bool flag1 = true;
            bool flag2;
            string? comand;
            string? type;
            while (flag1)
            {
                flag2 = true;
                Console.Write("Input comand (Add,Show,End): ");
                comand = Console.ReadLine();
                switch (comand)
                {
                    case "Add":
                        while (flag2)
                        {
                            Console.Write("Input object type (River, Mount): ");
                            type = Console.ReadLine();
                            flag2 = !AddObject(objects, type);
                        }
                        break;
                    case "Show":
                        foreach (IGeographicObject g_object in objects)
                        {
                            g_object.GetInfo();
                            Console.WriteLine();
                        }
                        break;
                    case "End":
                        flag1 = false;
                        break;
                    default:
                        Console.WriteLine("Not valid comand");
                        break;
                }
            }
        }
    }
}