using System;
using System.ComponentModel;
public class Car
{
    String name;
    String brand;
    int topspeed;
    int score;

    public Car(string name, string brand, int topspeed)
    {
        this.name = name;
        this.brand = brand;
        this.topspeed = topspeed;
    }
    public string GetName()
    {
        return name;
    }

    public string GetBrand()
    {
        return brand;
    }
    public int GetTopSpeed()
    {
        return topspeed;
    }
    public int GetScore()
    {
        return score;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetBrand(string brand)
    {
        this.brand = brand;
    }
    public void SetTopSpeed(int topSpeed)
    {
        this.topspeed = topSpeed;
    }

    public void AddPoints(int p)
    {
        score = score + p;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Auto: " + name + " Merk: " + brand + " Topsnelheid: " + topspeed + "Km/u" + " Punten: " + score);
    }
}
class NardoGrey
{
    public static void Main()
    {
        Car c1 = new Car("biheshPuller", "Mercedes", 312);
        Car c2 = new Car("mathiasUmbutu", "Toyota", 223);
        Car c3 = new Car("Ginga", "Citroën", 100);
        Car c4 = new Car("Ninga", "Dodge", 311);

        List<Car> carList = new List<Car> { c1, c2, c3, c4 };
        Console.WriteLine(carList);

        List<Race> races = new List<Race> { new Race(), new Race(), new Race(), new Race(), new Race() };
        races[0].StartRace(carList[0], carList[1]);
        races[1].StartRace(carList[2], carList[1]);
        races[2].StartRace(carList[1], carList[3]);
        races[3].StartRace(carList[3], carList[0]);
        races[4].StartRace(carList[2], carList[0]);

        NardoGrey ng = new NardoGrey();
        ng.ShowScoreboard(carList);
    }
    private void ShowScoreboard(List<Car> cars)
    {
        List<Car> sortedList = cars.OrderByDescending(o=>o.GetScore()).ToList();
        for (int i = 0; i < cars.Count; i++)
        {
            cars[i].ShowInfo();
        }
    }
}
