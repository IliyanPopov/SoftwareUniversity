public static class FoodFactory
{
    public static Food CreateFood(string foodName)
    {
        switch (foodName.ToLower())
        {
            case "cram":
                return new Cram();
            case "lembas":
                return new Lembas();
            case "apple":
                return new Apple();
            case "melon":
                return new Melon();
            case "honeycake":
                return new HoneyCake();
            case "mushrooms":
                return new Mushroom();
            default:
                return new EverythingElse();
        }
    }
}

