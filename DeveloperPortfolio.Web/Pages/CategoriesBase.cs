using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.Design.Serialization;

namespace DeveloperPortfolio.Web.Pages
{
    public class CategoriesBase : ComponentBase
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<ProjectDto> Projects { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            Categories = await CategoryService.GetAllCategories();
            Projects = await ProjectService.GetAllProjects();
        }

        protected IEnumerable<ProjectDto> GetProjectsInThisCategory(int categoryId)
        {
            return from project in Projects
                   where project.CategoryId == categoryId
                   select project;
        }

        protected async Task DeleteCategory_Click(int id)
        {
            var categoryDto = await CategoryService.DeleteCategory(id);
            Categories = Categories.Where(c => c.Id != id);
        }

        protected async Task EditCategory_Click(int id)
        {
            NavigationManager.NavigateTo($"/UpdateCategory/{id}");
        }
    }
}
