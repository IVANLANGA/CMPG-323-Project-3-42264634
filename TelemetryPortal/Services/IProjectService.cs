using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Models;

namespace TelemetryPortal.Services
{
    public interface IProjectService
    {
        Task AddProjectAsync(Project entity);
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(Guid? id);
        Task UpdateProjectAsync(Project entity);
        Task RemoveProjectAsync(Project entity);
    }
}
