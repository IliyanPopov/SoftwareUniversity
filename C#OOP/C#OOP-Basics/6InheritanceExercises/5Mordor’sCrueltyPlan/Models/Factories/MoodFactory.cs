public static class MoodFactory
{
    private const int AngryMoodRequiredPointsBelowThisNumber = -5;
    private const int SadMoodRequiredPointsBottom = -5;
    private const int SadMoodRequiredPointsUpper = 0;
    private const int HappyMoodRequiredPointsBottom = 1;
    private const int HappyMoodRequiredPointsUpper = 15;
    private const int JavaScriptMoodRequiredPointsAboveThisNumber = 15;

    public static BaseMood CreateMood(int pointsOfHappiness)
    {
        if (pointsOfHappiness < AngryMoodRequiredPointsBelowThisNumber)
        {
            return new Angry();
        }
        if (pointsOfHappiness >= SadMoodRequiredPointsBottom && pointsOfHappiness <= SadMoodRequiredPointsUpper)
        {
            return new Sad();
        }
        if (pointsOfHappiness >= HappyMoodRequiredPointsBottom && pointsOfHappiness <= HappyMoodRequiredPointsUpper)
        {
            return new Happy();
        }
        return new Javascript();
    }
}