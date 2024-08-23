using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Services;

namespace TelemetryPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: api/project
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projects = _projectService.GetAllProjects();
            return Ok(projects);
        }

        // GET: api/project/{id}
        [HttpGet("{id}")]
        public ActionResult<Project> GetProjectById(Guid id)
        {
            var project = _projectService.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        // POST: api/project
        [HttpPost]
        public ActionResult<Project> AddProject(Project project)
        {
            if (project == null)
            {
                return BadRequest("Project cannot be null");
            }

            _projectService.AddProject(project);
            return CreatedAtAction(nameof(GetProjectById), new { id = project.ProjectId }, project);
        }

        // PUT: api/project/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProject(Guid id, Project project)
        {
            if (id != project.ProjectId)
            {
                return BadRequest("Project ID mismatch");
            }

            var existingProject = _projectService.GetProjectById(id);
            if (existingProject == null)
            {
                return NotFound();
            }

            _projectService.UpdateProject(project);
            return NoContent();
        }

        // DELETE: api/project/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProject(Guid id)
        {
            var project = _projectService.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }

            _projectService.RemoveProject(project);
            return NoContent();
        }
    }
}
