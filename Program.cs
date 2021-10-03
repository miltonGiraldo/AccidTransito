using System;
using AccidTransito.app.Dominio;
using AccidTransito.app.Persistencia;

namespace AccidTransito.app.Consola
{
  class Program
  {   
  
     private static IRepositorioAccidente _repoAccidente= new RepositorioAccidente(new Persistencia.AppContext());
     private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
     private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
   
     static void Main(string[] args)
 
     {
       Console.WriteLine("Hello World EF!");
   
       AddAccidentes();
       AddVehiculos();
       AddPersonas();
     }   
   { 
      private static void AddAccidentes();
     {}}
      var accidente = new Accidente
      {
      Persona = new Persona{
      Nombre = "Juan",
      Apellido = "Gomez",
      TipoDocumento = "cc",
      NumeroIdentificacion = "714536451",
      Pais = "Colombia",
      Departamento = " Antioquia",
      CiudadResidencia = "Manizales",
      Direccion = "cra 34 n 34 - 32",
      NumeroTelefono = "3113456747",
      Edad = "23",
      Genero = Genero.Masculino,
        
      },
      Vehiculo = new Vehiculo{
      Clase = "Moto",
      LicenciaTransito = "3763452341",
      Placa = "Rzc45F",
      Modelo = "2020",
      Servicio = "Particular",
      Seguros = " si ",
      Tecnomecanica = "si",
      },
                

      Fecha = new DateTime(2021,09,25),
      Hora = "3:40",
      Ciudad = "Medellin",
      Barrio = "Manrique",
      Direccion = "calle 12 N 6 - 8",
      Preacuerdo = " si ",
      NumeroCitacion = "3456",
      Croquis = "si",
      Comparendo = "98",
      };      
      }    
      
      private static void AddVehiculos();
      }
        var vehiculo = new Vehiculo
       {
       Clase = "Automovil",
       LicenciaTransito = "3765902341",
       Placa = "MSG654",
       Modelo = "2018",
       Servicio = "Particular",
       Seguros = " si ",
       Tecnomecanica = "si",
                
       };       
               
       //}
       private static void AddPersonas();
      
       var persona = new Persona
       {  
       Nombre = "Milton",
       Apellido = "Giraldo",
       TipoDocumento = "cc",
       NumeroIdentificacion = "94468661",
       Pais = "Colombia",
       Departamento = " Antioquia",
       CiudadResidencia = "Medellin",
       Direccion = "cra 99 n 34 - 78",
       NumeroTelefono = "3117274567",
       Edad = "38",
       Genero = Genero.Masculino,                               
       };
    
       _repoAccidente.AddAccidentes(accidente);
       _repoVehiculo.AddVehiculos(vehiculo);
       _repoPersona.AddPersonas(persona);
      
    }              
     
  }         
}
