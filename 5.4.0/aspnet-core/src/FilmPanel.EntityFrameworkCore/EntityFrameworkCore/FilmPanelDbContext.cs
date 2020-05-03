using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FilmPanel.Authorization.Roles;
using FilmPanel.Authorization.Users;
using FilmPanel.MultiTenancy;

namespace FilmPanel.EntityFrameworkCore
{
    public class FilmPanelDbContext : AbpZeroDbContext<Tenant, Role, User, FilmPanelDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FilmPanelDbContext(DbContextOptions<FilmPanelDbContext> options)
            : base(options)
        {
        }
    }
}
