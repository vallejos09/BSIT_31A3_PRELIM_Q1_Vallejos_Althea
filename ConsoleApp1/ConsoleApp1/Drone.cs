using TransportChallenge;

public class Drone : Vehicle, IFlyable
{
    public void Fly()
    {
    }

    public override string Move()
    {
        return "flying";
    }
}