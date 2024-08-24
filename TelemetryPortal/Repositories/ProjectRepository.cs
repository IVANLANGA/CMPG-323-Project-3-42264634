using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelemetryPortal.Data;
using TelemetryPortal.Models;

namespace TelemetryPortal.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }

        // Asynchronous method to get a project by ID
        public async Task<Project> GetProjectByIdAsync(Guid? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await GetByIdAsync(id.Value);
        }

        // Asynchronous method to get all projects
        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await GetAllAsync();
        }

        // Asynchronous method to add a project
        public async Task AddProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await AddAsync(entity);
        }

        // Asynchronous method to update a project
        public async Task UpdateProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await UpdateAsync(entity);
        }

        // Asynchronous method to remove a project
        public async Task RemoveProjectAsync(Project entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            await RemoveAsync(entity);
        }
    }
}
