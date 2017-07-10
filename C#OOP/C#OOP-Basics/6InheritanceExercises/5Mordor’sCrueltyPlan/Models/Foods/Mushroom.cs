public class Mushroom : Food
{
    private const int MushroomDefaultPointsOfHappiness = -10;

    public override int PointsOfHappiness
    {
        get { return MushroomDefaultPointsOfHappiness; }
    }
}