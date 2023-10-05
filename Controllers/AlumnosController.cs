using ServicioSocial.Models;
using ServicioSocial.Services;
using ServicioSocial.Sessions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ServicioSocial.Controllers
{
    public class AlumnosController : Controller
    {
       private readonly ITransacciones db;
       private readonly DbcontrolEscolarContext _db;

       public AlumnosController(DbcontrolEscolarContext _db,ITransacciones db){
        this._db = _db;
        this.db = db;
       }

       [Authorize]
       [Authorize(Roles = "Admin,Administrativos,Docentes")]
       public IActionResult Principal(){
        Usuario u =  SessionHelper.GetObjectFromJson<Usuario>(HttpContext.Session,"usuario");
        ViewBag.Nombre = u.NomUsuario;
        ViewBag.Rol = u.IdRol;
        return View(_db.Alumnos
        .Include(x => x.CurpNavigation)
        .Include(x => x.IdCarreraNavigation)
        .Include(x => x.IdEspecialidadNavigation)
        .Include(x => x.IdModalidadNavigation)
        .ToList());
       }

       [Authorize]
       [Authorize(Roles = "Admin,Alumno")]
       public IActionResult Individual(){
        Usuario u = SessionHelper.GetObjectFromJson<Usuario>(HttpContext.Session,"usuario");
        ViewBag.Nombre = u.NomUsuario;
        ViewBag.Rol = u.IdRol;
        return View(db.ObtenerAlumnoPorNoControl(u.NomUsuario));
       }
    }
}