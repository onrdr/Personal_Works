using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._4_Need_For_Speed_Exercism
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new RemoteControlCar(100, 60);
            car.Drive();
            Console.WriteLine(car.BatteryDrained());

            Console.ReadLine();
        }
    }
    class RemoteControlCar
    {
        int battery = 100;
        int distance = 0;

        private readonly int speed;
        private readonly int batteryDrain;
        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
        }

        public bool BatteryDrained()
        {
            if (battery > 0)
            {
                return false;
            }
            return true;
        }

        public int DistanceDriven()
        {
            return distance;
        }

        public void Drive()
        {
            if (BatteryDrained())
                return;

            battery -= batteryDrain;

            if (battery < 0)
                return;
            distance += speed;
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }

    class RaceTrack
    {
        private readonly int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool CarCanFinish(RemoteControlCar car)
        {
            for (; ; )
            {
                car.Drive();
                if (car.DistanceDriven() >= this.distance)
                    return true;
                if (car.BatteryDrained())
                    return false;
            }
        }
    }
}
