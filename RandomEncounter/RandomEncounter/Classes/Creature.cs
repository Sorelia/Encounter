using SQLite;

namespace RandomEncounter
{
    public class Creature
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Challenge_Rating { get; set; }
    }
}
