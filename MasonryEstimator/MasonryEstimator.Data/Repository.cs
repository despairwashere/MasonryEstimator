using MasonryEstimator.Core.Models;

namespace MasonryEstimator.Data
{
    public class Repository
    {
        public IEnumerable<Project> GetProjects()
        {
            using var db = new MasonryContext();
            return db.Projects
                     .OrderBy(p => p.Id)
                     .ToList();
        }

        public void AddProject(Project project)
        {
            using var db = new MasonryContext();
            db.Projects.Add(project);
            db.SaveChanges();
        }
    }
}
