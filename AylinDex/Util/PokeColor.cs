namespace AylinDex;

public class PokeColor
{
    public static string GetTypeColor(string type)
    {
        string color = type switch
        {
            "normal" => "#a8a878",
            "fire" => "#f08030",
            "water" => "#6890f0",
            "electric" => "#f8d030",
            "grass" => "#78c850",
            "ice" => "#98d8d8",
            "fighting" => "#c03028",
            "poison" => "#a040a0",
            "ground" => "#e0c068",
            "flying" => "#a890f0",
            "psychic" => "#f85888",
            "bug" => "#a8b820",
            "rock" => "#b8a038",
            "ghost" => "#705898",
            "dragon" => "#7038f8",
            "dark" => "#705848",
            "steel" => "#b8b8d0",
            "fairy" => "#ee99ac",
            _ => "#black"
        };
        return color;
    }
    public static string GetStatColor(string stat)
    {
        string color = stat switch
        {
            "hp" => "#FF0000",            // Sağlık Puanı için kırmızı
            "attack" => "#FFA500",        // Saldırı için turuncu
            "defense" => "#FFFF00",       // Savunma için sarı
            "special-attack" => "#7FFFD4",// Özel Saldırı için akvaryum mavisi
            "special-defense" => "#008000", // Özel Savunma için yeşil
            "speed" => "#0000FF",         // Hız için mavi
            _ => "#000000"                // Varsayılan olarak siyah
        };
        return color;

    }

}
