namespace TransportChallenge;

public class Airplane : Vehicle, IFlyable
{
    public void Fly()
    {
    }

    public override string Move()
    {
        return "Flying in the sky.";
    }
}