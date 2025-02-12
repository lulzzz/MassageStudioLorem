﻿namespace MassageStudioLorem.Areas.Admin.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    using Models;
    using Services;
    using Services.Models;

    using static Global.GlobalConstants.ErrorMessages;
    using static Global.GlobalConstants.Notifications;

    public class CategoriesController : AdminController
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService) 
            => this._categoriesService = categoriesService;

        public IActionResult Index() => this.View();

        public IActionResult AddCategory() => this.View();

        [HttpPost]
        public IActionResult AddCategory(AddCategoryFormModel model)
        {
            if (!this._categoriesService
                .CheckIfCategoryIsAddedSuccessfully(model.Name))
            {
                this.ModelState.AddModelError(String.Empty, CategoryNameExists);
                return this.View();
            }

            this.TempData[SuccessfullyAddedCategoryKey] =
                SuccessfullyAddedCategory;

            return this.RedirectToAction(nameof(this.AddCategory));
        }

        public IActionResult All()
        {
            var allCategoriesModels = this._categoriesService.GetAllCategories();

            if (CheckIfNull(allCategoriesModels)) 
                this.ModelState.AddModelError(String.Empty, NoCategoriesFound);

            return this.View(new AllCategoriesViewModel() 
                {Categories = allCategoriesModels});
        }

        public IActionResult DeleteCategory(AllCategoriesViewModel categoriesModel)
        {
            var deleteCategoryModel = this._categoriesService
                .GetCategoryDataForDelete(categoriesModel.CategoryId);

            if (CheckIfNull(deleteCategoryModel))
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);

            return this.View(nameof(this.DeleteCategory), deleteCategoryModel);
        }

        [HttpPost]
        public IActionResult Delete(string categoryId)
        {
            if (!this._categoriesService
                .CheckIfCategoryDeletedSuccessfully(categoryId))
            {
                this.ModelState.AddModelError(String.Empty, SomethingWentWrong);
                return this.View(nameof(this.DeleteCategory));
            }

            this.TempData[SuccessfullyDeletedCategoryKey] =
                SuccessfullyDeletedCategory;

            return this.RedirectToAction(nameof(this.All));
        }

        private static bool CheckIfNull(object obj)
            => obj == null;
    }
}
