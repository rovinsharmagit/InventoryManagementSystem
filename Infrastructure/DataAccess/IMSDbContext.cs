using Application.Extensions.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class IMSDbContext(DbContextOptions<IMSDbContext> options) :
        IdentityDbContext<ApplicationUser>(options)
    {
    }
}
