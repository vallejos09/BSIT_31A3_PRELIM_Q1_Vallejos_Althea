namespace TransportChallenge;

public class Boat : Vehicle, ISailable
{
    public void Sail()
    {
    }

    public override string Move()
    {
        return "Sailing on the water.";
    }
}