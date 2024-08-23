using System;
using System.Collections.Generic;
using System.Linq;
using TelemetryPortal.Models;
using TelemetryPortal.Repositories;

namespace TelemetryPortal.Services
{
    public class ProjectService: IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddProject(Project entity)
        {
            _projectRepository.Add(entity);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectRepository.GetAll().ToList();
        }

        public Project GetProjectById(Guid? id)
        {
            return _projectRepository.GetAll().FirstOrDefault(x => x.ClientId == id);
        }

        public void RemoveProject(Project entity)
        {
            _projectRepository.Remove(entity);
        }

        public void UpdateProject(Project entity)
        {
            _projectRepository.Update(entity);
        }
    }
}
