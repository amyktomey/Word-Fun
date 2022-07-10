using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=Story.db");
    }
   
   public DbSet<Story>? Story {get;set;}
   
   public DbSet<StoryB>? StoryB { get; set; }

}