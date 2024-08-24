using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TelemetryPortal.Models;
using TelemetryPortal.Services;

namespace TelemetryPortal.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectService _projectService;

        public ProjectController(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return View(projects);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.AddProjectAsync(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Project project)
        {
            if (id != project.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _projectService.UpdateProjectAsync(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Project project)
        {
            await _projectService.RemoveProjectAsync(project);
            return RedirectToAction(nameof(Index));
        }
    }
}
