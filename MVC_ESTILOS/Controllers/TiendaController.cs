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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
                {
                    categoria existe = bd.categoria.Find(obj.id);
                    existe.nombre = obj.nombre;
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
                {
                    producto existe = bd.producto.Find(pro.id);
                    existe.marca = pro.marca;
                    existe.id_categoria = pro.id_categoria;
                    existe.nombre = pro.nombre;
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
                using (TiendaEntities bd = new TiendaEntities())
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
                using (TiendaEntities bd = new TiendaEntities())
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
        public ActionResult MostrarFactura()
        {
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    List<factura> Lista = bd.factura.Where(a => a.id >= 1).ToList();
                    return View(Lista);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult NuevoFactura()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NuevoFactura(factura fac)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    bd.factura.Add(fac);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarFactura");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar factura", ex);
                return View();
            }
        }

        public ActionResult EditarFactura(int id)
        {
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    factura obj = bd.factura.Find(id);
                    return View(obj);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar factura", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditarFactura(factura fac)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    factura existe = bd.factura.Find(fac.id);
                    existe.pago = fac.pago;
                    existe.importe = fac.importe;
                    existe.fecha = fac.fecha;
                    existe.id_usuario = fac.id_usuario;
                    existe.id_carrito = fac.id_carrito;
                    bd.SaveChanges();
                    return RedirectToAction("MostrarFactura");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar factura", ex);
                return View();
            }
        }
        public ActionResult DetallesFactura(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    factura existe = bd.factura.Find(id);
                    return View(existe);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar factura", ex);
                return View();
            }
        }
        [HttpGet]
        public ActionResult EliminarFactura(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    factura existe = bd.factura.Find(id);
                    bd.factura.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarFactura");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar factura", ex);
                return View();
            }
        }
        public ActionResult MostrarCarrito()
        {
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    List<carrito> Lista = bd.carrito.Where(a => a.id >= 1).ToList();
                    return View(Lista);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ActionResult NuevoCarrito()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NuevoCarrito(carrito car)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    bd.carrito.Add(car);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCarrito");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar carrito", ex);
                return View();
            }
        }

        public ActionResult EditarCarrito(int id)
        {
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    carrito obj = bd.carrito.Find(id);
                    return View(obj);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar carrito", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditarCarrito(carrito car)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    carrito existe = bd.carrito.Find(car.id);
                    existe.id_usuario = car.id_usuario;
                    existe.id_producto = car.id_producto;
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCarrito");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al editar carrito", ex);
                return View();
            }
        }
        public ActionResult DetallesCarrito(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    carrito existe = bd.carrito.Find(id);
                    return View(existe);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al mostrar carrito", ex);
                return View();
            }
        }
        [HttpGet]
        public ActionResult EliminarCarrito(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (TiendaEntities bd = new TiendaEntities())
                {
                    carrito existe = bd.carrito.Find(id);
                    bd.carrito.Remove(existe);
                    bd.SaveChanges();
                    return RedirectToAction("MostrarCarrito");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al eliminar carrito", ex);
                return View();
            }
        }
    }
}