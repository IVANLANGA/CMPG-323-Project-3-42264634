using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Models;

namespace TelemetryPortal.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Task<Project> GetProjectByIdAsync(Guid? id);
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task AddProjectAsync(Project entity);
        Task UpdateProjectAsync(Project entity);
        Task RemoveProjectAsync(Project entity);
    }
}
