using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Services
{
    // Service for handling business logic related to Project entities
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        // Constructor injecting the project repository
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // Adds a new Project entity
        public async Task AddProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _projectRepository.AddProjectAsync(entity);
        }

        // Retrieves all Project entities
        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllProjectsAsync();
        }

        // Retrieves a Project by its ID
        public async Task<Project> GetProjectByIdAsync(Guid? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await _projectRepository.GetProjectByIdAsync(id);
        }

        // Updates an existing Project entity
        public async Task UpdateProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _projectRepository.UpdateProjectAsync(entity);
        }

        // Removes a Project entity
        public async Task RemoveProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await _projectRepository.RemoveProjectAsync(entity);
        }
    }
}
