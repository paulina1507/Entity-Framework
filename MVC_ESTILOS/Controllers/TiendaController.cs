using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ESTILOS.Models;

namespace MVC_ESTILOS.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    List<usuario> Lista = bd.usuario.Where(a => a.id >= 1).ToList();
                    return View(Lista);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult Nuevo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(usuario usu)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    bd.usuario.Add(usu);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar usuario", ex);
                return View();
            }
        }
        
        public ActionResult Editar(int id)
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    usuario obj = bd.usuario.Find(id);
                    return View(obj);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar usuario", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(usuario obj)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    usuario existe = bd.usuario.Find(obj.id);
                    existe.nombre = obj.nombre;
                    existe.apellidos = obj.apellidos;
                    existe.direccion = obj.direccion;
                    existe.email = obj.email;
                    existe.passw = obj.passw;
                    existe.cp = obj.cp;
                    existe.localidad = obj.localidad;
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar usuario", ex);
                return View();
            }
        }
        public ActionResult Detalles(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    usuario existe = bd.usuario.Find(id);
                    return View(existe);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar usuario", ex);
                return View();
            }
        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    usuario existe = bd.usuario.Find(id);
                    bd.usuario.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar usuario", ex);
                return View();
            }
        }

        public ActionResult MostrarCategoria()
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    List<categoria> Lista = bd.categoria.Where(a => a.id >= 1).ToList();
                    return View(Lista);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult NuevoCategoria()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NuevoCategoria(categoria cat)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    bd.categoria.Add(cat);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCategoria");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar categoria", ex);
                return View();
            }
        }

        public ActionResult EditarCategoria(int id)
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    categoria obj = bd.categoria.Find(id);
                    return View(obj);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar categoria", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditarCategoria(categoria obj)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    categoria existe = bd.categoria.Find(obj.id);
                    existe.nombre = obj.nombre;
                    existe.descripcion = obj.descripcion;
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCategoria");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar categoria", ex);
                return View();
            }
        }
        public ActionResult DetallesCategoria(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    categoria existe = bd.categoria.Find(id);
                    return View(existe);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar categoria", ex);
                return View();
            }
        }
        [HttpGet]
        public ActionResult EliminarCategoria(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    categoria existe = bd.categoria.Find(id);
                    bd.categoria.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCategoria");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar categoria", ex);
                return View();
            }
        }

        public ActionResult MostrarProducto()
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    List<producto> Lista = bd.producto.Where(a => a.id >= 1).ToList();
                    return View(Lista);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult NuevoProducto()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NuevoProducto(producto pro)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    bd.producto.Add(pro);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarProducto");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar producto", ex);
                return View();
            }
        }

        public ActionResult EditarProducto(int id)
        {
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    producto obj = bd.producto.Find(id);
                    return View(obj);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar producto", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditarProducto(producto pro)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    producto existe = bd.producto.Find(pro.id);
                    existe.id_categoria = pro.id_categoria;
                    existe.id_usuario = pro.id_usuario;
                    existe.nombre = pro.nombre;
                    existe.descripcion = pro.descripcion;
                    existe.precio = pro.precio;
                    existe.existentes = pro.existentes;
                    bd.SaveChanges();
                    return RedirectToAction("MostrarProducto");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar producto", ex);
                return View();
            }
        }
        public ActionResult DetallesProducto(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    producto existe = bd.producto.Find(id);
                    return View(existe);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar producto", ex);
                return View();
            }
        }
        [HttpGet]
        public ActionResult EliminarProducto(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEF2Entities bd = new TiendaEF2Entities())
                {
                    producto existe = bd.producto.Find(id);
                    bd.producto.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarProducto");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar producto", ex);
                return View();
            }
        }
    }
}