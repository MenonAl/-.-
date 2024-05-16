using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class Car
{
    // Поля.
    int seats;
    int maxSpeed;
    string name;
    public Car(int seats, int maxSpeed, string name)
    {
        
        this.seats = seats;
        this.maxSpeed = maxSpeed;
        this.name = name;
        // место для вашего кода
    }

    public void copy(Car from)
    {
            this.seats = from.seats;
            this.maxSpeed = from.maxSpeed;  
            this.name = from.name;
        // место для вашего кода
    }

    public int getSeats()
    {
        
        // место для вашего кода
        return seats;
    }

    public string getName()
    {
        // место для вашего кода
        return name;
    }

    public void addSeat()
    {
        seats += 1;
        // место для вашего кода
    }
    public int getMaxSpeed() 
    {
        return maxSpeed;
    }
}

class Pickup : Car
{
    private int baggageVolume;
    private int additionalWheels;
    // Поля.
    public Pickup(int seats, int maxSpeed, string name, int baggageVolume, int additionalWheels) : base(seats, maxSpeed, name)
    {
       this.additionalWheels = additionalWheels;
       this.baggageVolume = baggageVolume;
       //Console.WriteLine(additionalWheels);
    }
    public int GetbaggageVolume() 
    {
        return baggageVolume;
    }
    public int GetadditionalWheels() 
    {
        return additionalWheels;
    }

}

class MotorCar : Car
{
    // Поля.
    string bodyType = null;
    public MotorCar(int seats, int maxSpeed, string name, string bodyType) : base(seats, maxSpeed, name)
    {
        this.bodyType = bodyType;
    }
    public string getBodyType()
    {
        return bodyType;
    }
   
}

class CarWorkshop
{
    Car[] carsArray;
    int size;

    public CarWorkshop(int sizeBorder)
    {
        size = sizeBorder;
        carsArray = new Car[size];
        // место для вашего кода
    }

    public bool addCar(int index, Car carToAdd)
    {
        if (carsArray[index-1] != null)
        {
            carsArray[index-1] = null;//пересраховался
        }
        if (carToAdd.GetType().ToString() == "Pickup")
        {
            carsArray[index - 1] = (Pickup)carToAdd;
        }
        else 
        {
            carsArray[index - 1] =(MotorCar)carToAdd;
        }
        // место для вашего кода
        return false;
    }

    public void addCarSeat(int index)
    {
        carsArray[index-1].addSeat();
        // место для вашего кода
    }

    public void printCars()
    {
        for (int i = 0; i < carsArray.Length; ++i) 
        {
            if (carsArray[i] == null)
            {
                Console.WriteLine("The place is vacant");
            }
            else
            {
                if (carsArray[i].GetType().ToString() == "Pickup")
                {
                    Pickup car_new = (Pickup)carsArray[i];
                    Console.WriteLine(carsArray[i]);
                    Console.WriteLine(carsArray[i].getMaxSpeed());
                    Console.WriteLine(carsArray[i].getName());
                    Console.WriteLine(carsArray[i].getSeats());
                    Console.WriteLine(car_new.GetbaggageVolume());
                    Console.WriteLine(car_new.GetadditionalWheels());
                }
                else
                {
                    MotorCar car_new = (MotorCar)carsArray[i];
                    Console.WriteLine(carsArray[i]);
                    Console.WriteLine(carsArray[i].getMaxSpeed());
                    Console.WriteLine(carsArray[i].getName());
                    Console.WriteLine(carsArray[i].getSeats());
                    Console.WriteLine(car_new.getBodyType());
                }
            }
        }
        // место для вашего кода
    }
}

class Program
{
    static bool test0()
    {
        try 
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "not_speedy", "sedan");
            Console.WriteLine(car1.getSeats());
            return true;
        }
        catch {  return false; }
    }
    static bool test1()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            Console.WriteLine(car1.getSeats());
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            return true;
        }
        catch { return false; }
    }
    static bool test2()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            Console.WriteLine(car1.getSeats());
            car1.addSeat();
            Console.WriteLine(car2.getSeats());
            car2.addSeat();
            car2.addSeat();
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getSeats());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            return true;
        }
        catch { return false; }
    }
    static bool test3()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getSeats());
            Console.WriteLine(car1.GetType().ToString());
            Console.WriteLine(car2.GetType().ToString());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            return true;
        }
        catch { return false; }
    }
    static bool test4()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            Console.WriteLine(car1.GetType().ToString());
            Console.WriteLine(car2.GetType().ToString());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            return true;
        }
        catch { return false; }
    }
    static bool test5()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            MotorCar car3 = new MotorCar(8, 90, "vety_slow", "bus");
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            workshop.addCarSeat(4);
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.GetType().ToString());
            Console.WriteLine(car2.GetType().ToString());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            workshop.printCars();
            return true;
        }
        catch { return false; }
    }
    static bool test6()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            MotorCar car3 = new MotorCar(8, 90, "vety_slow", "bus");
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            workshop.addCarSeat(4);
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.GetType().ToString());
            Console.WriteLine(car2.GetType().ToString());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            workshop.addCar(4, car3);
            workshop.printCars();
            return true;
        }
        catch { return false; }
    }
    static bool test7()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            MotorCar car3 = new MotorCar(8, 90, "vety_slow", "bus");
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            workshop.addCarSeat(4);
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            workshop.addCar(4, car3);
            workshop.printCars();
            car1.getMaxSpeed();
            car2.getMaxSpeed();
            car3.getMaxSpeed();
            return true;
        }
        catch { return false; }
    }
    static bool test8()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            MotorCar car3 = new MotorCar(8, 90, "vety_slow", "bus");
            Pickup car4 = new Pickup(10, 120, "pickup", 100, 5);
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            workshop.addCarSeat(4);
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            workshop.addCar(4, car3);
            workshop.printCars();
            car1.getMaxSpeed();
            car2.getMaxSpeed();
            car3.getMaxSpeed();
            return true;
        }
        catch { return false; }
    }
    static bool test9()
    {
        try
        {
            Pickup car1 = new Pickup(5, 220, "not_speedy", 200, 2);
            MotorCar car2 = new MotorCar(5, 220, "speedy", "sedan");
            MotorCar car3 = new MotorCar(8, 90, "vety_slow", "bus");
            Pickup car4 = new Pickup(10, 120, "pickup", 100, 5);
            Car car5 = new Car(2,300,"urus");
            Car car6 = new Car(0,0,null);
            car6.copy(car5);
            car1.addSeat();
            car2.addSeat();
            car2.addSeat();
            CarWorkshop workshop = new CarWorkshop(5);
            workshop.addCar(4, car1);
            workshop.addCar(5, car2);
            workshop.addCarSeat(4);
            Console.WriteLine(car2.getSeats());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getName());
            workshop.addCar(4, car3);
            workshop.printCars();
            car1.getMaxSpeed();
            car2.getMaxSpeed();
            car3.getMaxSpeed();
            return true;
        }
        catch { return false; }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(test0());
        Console.WriteLine(test1());
        Console.WriteLine(test2());
        Console.WriteLine(test3());
        Console.WriteLine(test4());
        Console.WriteLine(test5());
        Console.WriteLine(test6());
        Console.WriteLine(test7());
        Console.WriteLine(test8());
        Console.WriteLine(test9());
        Console.ReadLine();
    }
}
