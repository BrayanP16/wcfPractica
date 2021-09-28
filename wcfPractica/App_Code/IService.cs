using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{
	[OperationContract]
	int AddAlumno(int AlumnoId, string Alumno, int Matricula);
	[OperationContract]
	string GetAlumnos();

}

[DataContract]
public class AlumnosDetalles
{
	public int AlumnoId { get; set; }
	[DataMember]
	public string Alumno { get; set; }
	[DataMember]
	public Nullable<int> Matricula { get; set; }
}