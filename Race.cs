public class Race
{
    public void StartRace(Car firstRaceCar, Car secondRaceCar)
    {
        Random random = new Random();
        double decider = random.Next();
        if (firstRaceCar.GetTopSpeed() < secondRaceCar.GetTopSpeed())
        {
            secondRaceCar.AddPoints(10);
            Console.WriteLine("Auto 2 heeft gewonnen.");
        }
        else
        {
            firstRaceCar.AddPoints(10);
            Console.WriteLine("Auto 1 heeft gewonnen.");
        }
    }
}