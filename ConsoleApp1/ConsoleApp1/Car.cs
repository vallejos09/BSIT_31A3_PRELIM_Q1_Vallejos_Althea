namespace TransportChallenge;

public class Car : Vehicle, IDriveable
{
    public void Drive()
    {
    }

    public override string Move()
    {
        return "Driving on the road.";
    }
}