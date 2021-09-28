using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public int AddAlumno(int AlumnoId, string Alumno, int Matricula)
    {
        UTNEntities utn = new UTNEntities();
        Alumnos alumdtl = new Alumnos();
        alumdtl.AlumnoId = AlumnoId;
        alumdtl.Alumno = Alumno;
        alumdtl.Matricula = Matricula;
        utn.Alumnos.Add(alumdtl);
        int Retval = utn.SaveChanges();
        return Retval;
    }

    public string GetAlumnos()
    {
        List<AlumnosDetalles> alumlst = new List<AlumnosDetalles>();
        UTNEntities utn = new UTNEntities();
        //liq
        var lstAlum = from k in utn.Alumnos select k;

        foreach (var item in lstAlum)
        {
            AlumnosDetalles alumdt = new AlumnosDetalles();
            alumdt.AlumnoId = item.AlumnoId;
            alumdt.Alumno = item.Alumno;
            alumdt.Matricula = item.Matricula;
            alumlst.Add(alumdt);
        }
        string json = JsonConvert.SerializeObject(alumlst);
        return json;
    }
   

}
