using LexiconMDB.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace LexiconMDB.DAL
{
    internal sealed class DatabaseContextInitializer : DropCreateDatabaseAlways<LexiconMDBContext>
    {
        protected override void Seed(LexiconMDBContext context)
        {
            context.Movies.AddRange(new List<Movie> {
                new Movie { Title = "New Movie", Genre = "Horror", Length = 95 },
                new Movie { Title = "Horror Movie", Genre = "Horror", Length = 90 },
                new Movie { Title = "New Movie II", Genre = "Comedy", Length = 110 },
                new Movie { Title = "Revenge of New Movie", Genre = "Drama", Length = 85 },
            });
        }
    }
}