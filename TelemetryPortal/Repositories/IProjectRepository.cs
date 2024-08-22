using TelemetryPortal.Models;
using System.Threading.Tasks;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Project GetProjectById(Guid? id);
        IEnumerable<Project> GetAllProjects();
        void RemoveProject(Project entity);
        void UpdateProject(Project entity);
        void AddProject(Project entity);
    }
}
