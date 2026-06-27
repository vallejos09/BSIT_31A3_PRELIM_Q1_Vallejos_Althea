using TransportChallenge;

public class Submarine : Vehicle, ISailable
{
    public void Sail()
    {
    }

    public override string Move()
    {
        return "sailing";
    }
}