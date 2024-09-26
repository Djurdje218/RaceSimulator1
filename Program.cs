using RaceSimulator.Entities;
using RaceSimulator.Races;
using System.Text;

namespace RaceSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int RaceType, MaxVehicles, VehicleType;
            bool Choice;
            int ChoiceInput;
            double distance;
            string CustomName = null;
            double CustomSpeed = 0;
            Race race;



            Console.WriteLine("Выберите тип гонки:" +
                "\n1 -> Наземная + Воздушная гонка" +
                "\n2 -> Наземная гонка" +
                "\n3 -> Воздушная гонка\n");
            RaceType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Напишите дистанцу гонки: ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сколько траснспортных средства хотите выбрать? ");
            MaxVehicles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (RaceType)
            {
                case 1:
                    race = new Race(distance);
                    break;
                case 2:
                    race = new GroundR(distance);
                    break;
                case 3:
                    race = new AirR(distance);
                    break;
                default:
                    throw new InvalidOperationException(" Error, invalid RaceType");
            }

            Console.WriteLine("Список транспортных средств ");
            Console.WriteLine("1 - Ступа Бабы Яги \t\t(Наземные)");
            Console.WriteLine("2 - Метла \t\t\t(Воздушные)");
            Console.WriteLine("3 - Сапоги-скороходы \t\t(Наземные)");
            Console.WriteLine("4 - Карета-тыква \t\t(Наземные)");
            Console.WriteLine("5 - Ковер-самолет \t\t(Воздушные)");
            Console.WriteLine("6 - Избушка на курьих ножках \t(Наземные)");
            Console.WriteLine("7 - Кентавр \t\t\t(Наземные)");
            Console.WriteLine("8 - Летучий корабль \t\t(Воздушные)\n");

            Console.WriteLine("Вы можете выбрать своё имя для каждого транспортного средства и его скорость \n ");


            for (int i = 0; i < MaxVehicles; i++)
            {
                Console.WriteLine($"Выберите транспортное средство номер {i + 1}");
                VehicleType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Хотите изменить имя и определить скорость? (1 -> Да, 0 -> Нет) ");

                ChoiceInput = Convert.ToInt32(Console.ReadLine());
                if (ChoiceInput == 1)
                {
                    Choice = true;
                    Console.WriteLine(" Напишите имя");
                    CustomName = Console.ReadLine();
                    Console.WriteLine("Напишите скорость");
                    CustomSpeed = Convert.ToDouble(Console.ReadLine());
                }
                else Choice = false;



                switch (VehicleType)
                {

                    case 1:
                        if (Choice) race.RegisterV(new BabaYagasMortar(CustomName, CustomSpeed));
                        else race.RegisterV(new BabaYagasMortar());
                        break;

                    case 2:
                        if (Choice) race.RegisterV(new Broom(CustomName, CustomSpeed));
                        else race.RegisterV(new Broom());
                        break;

                    case 3:
                        if (Choice) race.RegisterV(new SevenLeageBoots(CustomName, CustomSpeed));
                        else race.RegisterV(new SevenLeageBoots());
                        break;

                    case 4:
                        if (Choice) race.RegisterV(new PumpkinCar(CustomName, CustomSpeed));
                        else race.RegisterV(new PumpkinCar());
                        break;

                    case 5:
                        if (Choice) race.RegisterV(new FlyingCarpet(CustomName, CustomSpeed));
                        else race.RegisterV(new FlyingCarpet());
                        break;

                    case 6:
                        if (Choice) race.RegisterV(new ChickenHouse(CustomName, CustomSpeed));
                        else race.RegisterV(new ChickenHouse());
                        break;


                    case 7:
                        if (Choice) race.RegisterV(new Centaur(CustomName, CustomSpeed));
                        else race.RegisterV(new Centaur());
                        break;

                    case 8:
                        if (Choice) race.RegisterV(new FlyingShip(CustomName, CustomSpeed));
                        else race.RegisterV(new FlyingShip());
                        break;
                }

            }
            Console.WriteLine("\n\n\n");

            Entities.Common.Vehicle winner = race.BeginRace();

            // Console.WriteLine($" Race type is {RaceType}");

            Console.ReadLine();
        }
    }
}
