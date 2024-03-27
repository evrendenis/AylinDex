namespace AylinDex;

public class PokeUtil
{
    public const string Pokeball = "/img/pokeball.png";
    public const string Greatball = "/img/great.png";
    public const string Ultraball = "/img/ultra.png";
    public const string Masterball = "/img/master.png";

    public static string GetRandomPokeBall()
    {
        var random = new Random();
        var balls = new List<string> { Pokeball, Greatball, Ultraball, Masterball };
        return balls[random.Next(0, balls.Count)];

    }

    public static double GetPokemonHeightInMeters(int height)
    {
        return height / 10.0;
    }

    public static double GetPokemonWeightInKg(int weight)
    {
        return weight / 10.0;
    }
}