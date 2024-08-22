using Microsoft.EntityFrameworkCore;
using TelemetryPortal.Data;
using TelemetryPortal.Models;
using System.Threading.Tasks;
using TelemetryPortal.Data;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }
        public Project GetProjectById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ProjectId == id);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return GetAll().ToList();
        }

        public void RemoveProject(Project entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project entity)
        {
            Update(entity);
        }

        public void AddProject(Project entity)
        {
            Add(entity);
        }
    }
}
