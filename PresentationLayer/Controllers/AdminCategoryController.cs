using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("Kategori")]
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [Route("Liste")]
        public IActionResult List()
        {
            return View(_categoryService.TGetAll());
        }
        [Route("Ekle")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("Ekle")]
        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Liste", "Kategori", "");
        }
        [Route("Guncelle/{id:int}")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_categoryService.TGetByID(id));
        }
        [Route("Guncelle")]
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Liste", "Kategori", "");
        }
        [Route("Sil/{id:int}")]
        public IActionResult Delete(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Liste", "Kategori", "");
        }
    }
}