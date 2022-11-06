using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Microsoft.DSX.ProjectTemplate.Data
{
    public class ProjectTemplateDbContextFactory : IDesignTimeDbContextFactory<ProjectTemplateDbContext>
    {
        public ProjectTemplateDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectTemplateDbContext>();
            optionsBuilder.UseSqlServer("Data Source=(local);Min Pool Size=5;Max Pool Size=3000;Pooling=true;Initial Catalog=ProjectTemplate;Integrated Security=True");
            return new ProjectTemplateDbContext(optionsBuilder.Options);
        }
    }
}
