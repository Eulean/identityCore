using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using identityCore.Data;
using Microsoft.EntityFrameworkCore;

namespace identityCore.Extensions
{
    public static class MigrationExtensions 
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        context.Database.Migrate();
    }
    }
}