using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace RandomEncounter.Classes
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Creature>().Wait();
        }

        public Task<List<Creature>> GetCreaturesAsync()
        {
            return _database.Table<Creature>().ToListAsync();
        }

        public Task<int> SaveCreatureAsync(Creature creature)
        {
            return _database.InsertAsync(creature);
        }

        public Task<int> DeleteCreaturesAsync()
        {
            return _database.DeleteAllAsync<Creature>();
        }
    }
}
