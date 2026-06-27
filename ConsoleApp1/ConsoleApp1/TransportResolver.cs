namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {
        input = input.ToLower();

        if (input == "car")
            return new Car();

        if (input == "plane")
            return new Airplane();

        if (input == "boat")
            return new Boat();

        if (input == "helicopter")
            return new Helicopter();

        return null;
    }
}