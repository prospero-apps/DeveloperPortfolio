﻿using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Components
{
    public class DisplayProjectsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProjectDto> Projects { get; set; }
        
        [Inject]
        public IProjectService ProjectService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task DeleteProject_Click(int id)
        {
            var projectDto = await ProjectService.DeleteProject(id);
            Projects = Projects.Where(p => p.Id != id);
        }

        protected async Task EditProject_Click(int id)
        {
            NavigationManager.NavigateTo($"/UpdateProject/{id}");
        }
    }
}
