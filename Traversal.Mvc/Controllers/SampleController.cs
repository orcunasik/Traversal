using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Models.Concrete;
using Traversal.Core.Services;

namespace Traversal.Mvc.Controllers
{
    public class SampleController : Controller
    {
        private readonly IAboutService _service;

        public SampleController(IAboutService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();
            return View(result);
        }
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(About about)
        {
            await _service.AddAsync(about);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Update(About about)
        {
            await _service.UpdateAsync(about);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(result);
            return RedirectToAction(nameof(Index));
        }
    }
}
