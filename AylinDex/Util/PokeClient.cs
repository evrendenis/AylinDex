using System.Text.Json;

namespace AylinDex;

public class PokeClient
{
    public HttpClient Client { get; set; }
    public PokeClient(HttpClient client)
    {
        Client = client;
    }

    public async Task<Pokemon> GetPokemon(string id)
    {
        // id 125 is the pokemon Picachu
        var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
        return null;

    }

}
