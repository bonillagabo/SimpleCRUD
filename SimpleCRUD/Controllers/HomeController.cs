using SimpleCRUD.DAL;
using SimpleCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClientesDBContext context;

        public HomeController()
        {
            context = new ClientesDBContext();
        }

        [HttpGet]
        public IActionResult Index()
        {
            IndexVM model = new IndexVM();
            model.clientes = context.Clientes.ToList();
            model.Buscar = "Teclea Nombre o Apellido";

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexVM model, string BuscarBtn, string AgregarBtn)
        {
            IActionResult result = null;

            if(AgregarBtn != null)
            {
                result = View("NuevoCliente");
            }else if(BuscarBtn != null)
            {
                result = this.Buscar(model);               
            }

            return result;
        }

        [HttpPost]
        public IActionResult Agregar(NuevoClienteVM model)
        {
            if (ModelState.IsValid)
            {
                Cliente cliente = null;
                try
                {
                    cliente = context.Clientes.Where(c => c.Dni == model.Dni).First();
                }
                catch (System.Exception)
                {

                }
                

                if(cliente==null)
                { 
                Cliente nuevoCliente = new Cliente()
                {
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    Dni = model.Dni,
                    Celular = model.Celular,
                    Domicilio = model.Domicilio,
                    Email = model.Email,
                };

                context.Clientes.Add(nuevoCliente);
                context.SaveChanges();

                IndexVM m = new IndexVM();
                m.clientes = context.Clientes.ToList();
                m.Buscar = "Teclea Nombre o Apellido";

                    return View("Index",m);
                }
                else
                {
                    ModelState.AddModelError("Dni", "Ya Existe un Cliente con el Dni ingresado.");
                    return View("NuevoCliente", model);
                }
            }
            else
            {
                return View("NuevoCliente",model);
            }
        }

        [HttpGet]
        public IActionResult Eliminar(long nroSocio)
        {
            Cliente clienteAEliminar = context.Clientes.Find(nroSocio);
            context.Clientes.Remove(clienteAEliminar);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modificar(long nroSocio)
        {
            Cliente cliente = context.Clientes.Find(nroSocio);
            
            ModificarClienteVM model = new ModificarClienteVM()
            {
                NroSocio = cliente.NroSocio,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Dni = cliente.Dni,
                Celular = cliente.Celular,
                Domicilio = cliente.Domicilio,
                Email = cliente.Email
            };

            return View("ModificarCliente",model);
        }

        [HttpPost]
        public IActionResult Modificar(ModificarClienteVM model, string GuardarBtn, string RecargarBtn)
        {
            IActionResult result = null;

            if(RecargarBtn != null)
            {
                result = Recargar(model);
            }else if(GuardarBtn != null)
            {
                result = Guardar(model);
            }

            return result;
        }

        private IActionResult Recargar(ModificarClienteVM model)
        {
            Cliente cliente = context.Clientes.Find(model.NroSocio);

            model.Nombre = cliente.Nombre;
            model.Apellido = cliente.Apellido;
            model.Celular = cliente.Celular;
            model.Dni = cliente.Dni;
            model.Domicilio = cliente.Domicilio;
            model.Email = cliente.Email;

            ModelState.Clear();

            return View("ModificarCliente",model);
        }

        private IActionResult Guardar(ModificarClienteVM model)
        {
            IActionResult result = null;

            if (ModelState.IsValid)
            {
                Cliente cliente = context.Clientes.Find(model.NroSocio);

                if(model.Dni == cliente.Dni)
                {
                    cliente.Nombre = model.Nombre;
                    cliente.Apellido = model.Apellido;
                    cliente.Celular = model.Celular;
                    cliente.Domicilio = model.Domicilio;
                    cliente.Email = model.Email;

                    result = RedirectToAction("Index"); 
                }
                else
                {
                    Cliente c = null;
                    try
                    {
                        c = context.Clientes.Where(c => c.Dni == model.Dni).First();
                    }
                    catch (System.Exception)
                    {
                       
                    }

                    if (c == null)
                    {
                        cliente.Nombre = model.Nombre;
                        cliente.Apellido = model.Apellido;
                        cliente.Dni = model.Dni;
                        cliente.Celular = model.Celular;
                        cliente.Domicilio = model.Domicilio;
                        cliente.Email = model.Email;

                        result = RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Dni", "Ya Existe un Cliente con el Dni ingresado.");
                        result = View("ModificarCliente", model);
                    }
                }             
            }
            else
            {
                return View("ModificarCliente", model);
            }

            context.SaveChanges();

            return result;
        }

        private IActionResult Buscar(IndexVM model)
        {
            if (string.IsNullOrEmpty(model.Buscar) || model.Buscar.Equals("Teclea Nombre o Apellido"))
            {
                model.Buscar = "";
            }
            
            List<Cliente> clientesFiltrados = context.Clientes.Where(c => c.Nombre.Contains(model.Buscar) || c.Apellido.Contains(model.Buscar)).ToList();

            model.clientes = clientesFiltrados;

            return View(model); 
        }

    }
}
