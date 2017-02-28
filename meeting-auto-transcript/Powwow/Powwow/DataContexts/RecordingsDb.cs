using Powwow.Models.Recordings;
using System.Data.Entity;

namespace Powwow.DataContexts
{
    public class RecordingsDb : DbContext
    {
        public RecordingsDb()
            : base("RecordingsDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RecordingsDb>());
        }

        public DbSet<Recording> Recordings { get; set; }
        public DbSet<SalesforceUser> SalesforceUsers { get; set; }
        public DbSet<RecordingText> RecordingTexts { get; set; }
        public DbSet<AudioBinary> AudioBinarys { get; set; }
    }
}