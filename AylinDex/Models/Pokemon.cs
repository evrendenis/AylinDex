namespace AylinDex;

public class Pokemon
{
    public int height { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public Sprites sprites { get; set; }
    public List<Stat> stats { get; set; }
    public List<Type> types { get; set; }
    public int weight { get; set; }
}
