using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fiap.Web.BridgeTechnology.Hotel.Models;

namespace Fiap.Web.BridgeTechnology.Hotel.Controllers
{
    public class HotelController : Controller
    {
        private static List<Hootel> _banco = new List<Hootel>();
        private static int _gerador = 1;

        public IActionResult Index() { return View(_banco); }

        [HttpPost]
        public IActionResult Cadastrar(Hootel hotel)
        {
            hotel.Codigo = _gerador++;
            _banco.Add(hotel);
            TempData["msg"] = "Hotel registrado!";
            return RedirectToAction("cadastrar");
        }

        [HttpGet] //Abrir a página de cadastro - URL /hotel/cadastrar
        public IActionResult Cadastrar()
        {
            CarregarUnidades();
            return View();
        }

        private void CarregarUnidades()
        {
            var lista = new List<string>(new string[] { "Unidade I", "Unidade II", "Unidade III" });
            ViewBag.unidades = new SelectList(lista);
        }

        [HttpPost]
        public IActionResult Editar(Hootel hotel)
        {
            _banco[_banco.FindIndex(p => p.Codigo == hotel.Codigo)] = hotel;

            TempData["msg"] = "Hotel atualizado!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarUnidades();

            var hotel = _banco.Find(p => p.Codigo == id);
            return View(hotel);
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            _banco.RemoveAll(p => p.Codigo == id);
            TempData["msg"] = "Hotel removido!";

            return RedirectToAction("Index");
        }
    }
}
