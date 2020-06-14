using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models
{
    public class CommandContext : DbContext
    {
        DbSet<Command> CommadItems {get;set;}

        public CommandContext(DbContextOptions<CommandContext> options) : base(options) { }
    }
}