using TransportChallenge;

public class Motorcycle : Vehicle, IDriveable
{
    public void Drive()
    {
    }

    public override string Move()
    {
        return "driving";
    }
}