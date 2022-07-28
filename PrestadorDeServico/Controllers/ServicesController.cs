using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prestadores_App.Interfaces;
using Prestadores_App.Models;

namespace PrestadorDeServico.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServicesService _serviceServices;


        public ServicesController(IServicesService serviceServices)
        {
            _serviceServices = serviceServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _serviceServices.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Price,Id,DateHourRegister,DateHourChange")] ServiceViewModel service)
        {
            if (ModelState.IsValid)
            {
                await _serviceServices.Add(service);
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var result = await _serviceServices.Edit(id);
            if(result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Price,Id,DateHourRegister,DateHourChange")] ServiceViewModel service)
        {
         
            if (ModelState.IsValid)
            {
                try
                {
                     var result = await _serviceServices.Edit(id, service);
                    if(result == null)
                    {
                        return NotFound();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }
    }
}
