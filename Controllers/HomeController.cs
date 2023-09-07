using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Marcia Costa", "123.456.789-10", "marciac@email.com", "miau");
        Cliente cliente2 = new Cliente(02, "Victor Barbosa", "213.456.189-70", "victorb@email.com", "vida");
        Cliente cliente3 = new Cliente(03, "Andrea Azevedo", "321.456.719-80", "adreaa@email.com", "baguera");
        Cliente cliente4 = new Cliente(04, "Thais Menezes", "423.156.781-90", "thaism@email.com", "nabi");
        Cliente cliente5 = new Cliente(05, "Thiago Silva", "523.416.789-01", "thiagos@email.com", "mika");

        //lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Areia Paragato", "12.345.678/0001-10", "areiaparagato@email.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Rações Pet", "13.315.678/0001-40", "racoespet@email.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Roupa Pet", "14.345.178/0001-20", "roupapet@email.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Dog Show", "15.145.628/0001-15", "dogshow@email.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Banho no Bicho", "16.345.618/0001-08", "banhonobicho@email.com");

        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
