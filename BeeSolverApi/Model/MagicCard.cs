namespace BeeSolverApi.Model
{
    public class MagicCard
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string[]? Names { get; set; }
        public string? ManaCost { get; set; }
        public string Cmc { get; set; }
        public string[] Colors { get; set; }
        public string[]? ColorIdentity { get; set; }
        public string? Type { get; set; }
        public string[]? Supertypes { get; set; }
        public string[]? Types { get;}
        public string[]? SubTypes { get; set; }
        public string? Rarity { get; set; }
        public string? Set { get; set; }
        public string? Text { get; set; }
        public string? Artist { get; set; }
        public string? Number { get; set; }
        public string? Power { get; set; }
        public string? Toughness { get; set; }
        public string? Layout { get;}
        public int Multiverseid { get; set; }
        public string? ImageUrl { get; set; }
    }
}
