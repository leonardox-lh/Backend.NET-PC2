using NewSchool.api.u202124304.api.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace NewSchool.api.u202124304.api.Shared.Persistence.Contexts;

public class AppDbContext : DbContext
{
    
    

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //aqui se definen los nombres de las columnas en la BD que seran de CategoryLL y TutorialLL respectivamente.
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        

        builder.UseSnakeCaseNamingConvention();
    }
}