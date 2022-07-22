using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prestadores_App.Interfaces;
using Prestadores_App.Models;
using Prestadores_Domain.Interfaces;

namespace PrestadorDeServico.Controllers
{
    public class PrestadorsController : Controller
    {
        private readonly IPrestadorService _PrestadorService;
        private readonly IUnitOfWork _Uow; 

        public PrestadorsController(IPrestadorService prestadorService, IUnitOfWork uow)
        {
            _PrestadorService = prestadorService;
            _Uow = uow;
        }

        // GET: Prestadors
        public async Task<IActionResult> Index()
        {
            return View(await _PrestadorService.GetAll()); 
        }

        // GET: Prestadors/Create
        public IActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,PhoneNumber,City,Service")] PrestadorViewModel prestador)
        {
            if (ModelState.IsValid)
            {
                await _PrestadorService.Add(prestador);

                if (await _Uow.Commit())
                    return RedirectToAction(nameof(Index));
            }

            return View(prestador);
        }

        // GET: Prestadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var result = await _PrestadorService.Edit(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,PhoneNumber,City,Service")] PrestadorViewModel prestador)
        {
            if (ModelState.IsValid)
            {
                await _PrestadorService.Edit(id, prestador);
                if (await _Uow.Commit());
                    return RedirectToAction(nameof(Index));
            }
            return View(prestador);
        }

     
    }
}
