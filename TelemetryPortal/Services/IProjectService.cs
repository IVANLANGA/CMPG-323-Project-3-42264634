using TelemetryPortal.Models;
using System;
using System.Collections.Generic;

namespace TelemetryPortal.Services
{
    public interface IProjectService
    {
        Project GetProjectById(Guid? id);
        IEnumerable<Project> GetAllProjects();
        void RemoveProject(Project entity);
        void UpdateProject(Project entity);
        void AddProject(Project entity);
    }
}
