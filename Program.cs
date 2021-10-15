using System;
using AccidTransito.app.Dominio;
using AccidTransito.app.Persistencia;
using System.Collections.Generic;


namespace AccidTransito.app.Consola
{
    class Program
    {
        private static IRepositorioAgenteTransito _repoAgente = new RepositorioAgenteTransito(new Persistencia.AppContext());
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        //private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddAccidentes();
            //AddVehiculos();
            AddPersonas();
            AddAgentes();
        }

        private static void AddPersonas()
        {
            var Persona = new Persona
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
            _repoPersona.AddPersonas(Persona);
            }
            private static void AddAgentes()
            {
            var Agente = new Agente
            {
                Contraseña = "00123",
                Codigo = "C002",
                
            };
            _repoAgente.AddAgentes(Agente);

        }
        private static void AddAccidentes()
        {

            List<Persona> listaPersonas = new List<Persona>{
                new Persona{
                    Nombre="Milton",
                    Apellido = "Giraldo",
                    TipoDocumento = "cc",
                    NumeroIdentificacion = "94468661",
                    Pais = "Colombia",
                    Departamento = " Antioquia",
                    CiudadResidencia = "Medellin",
                    Direccion = "cra 99 n 34 - 78",
                    NumeroTelefono = "3117274567",
                    Edad = "38",
                    Genero = Genero.Masculino
                },
                new Persona{
                    Nombre="Maria",
                    Apellido = "Parra",
                    TipoDocumento = "cc",
                    NumeroIdentificacion = "43678976",
                    Pais = "Colombia",
                    Departamento = "Caldas",
                    CiudadResidencia = "Manizales",
                    Direccion = "cra 23 n 56 - 70",
                    NumeroTelefono = "3007274457",
                    Edad = "24",
                    Genero = Genero.Femenino
                },
                new Persona{
                    Nombre="Santiago",
                    Apellido = "Areiza",
                    TipoDocumento = "cc",
                    NumeroIdentificacion = "723849003",
                    Pais = "Colombia",
                    Departamento = "Cundinamarca",
                    CiudadResidencia = "Bogota",
                    Direccion = "cra 26 n 67 - 12",
                    NumeroTelefono = "3016786543",
                    Edad = "45",
                    Genero = Genero.Masculino
                }
            };

            List<Vehiculo> ListaVehiculos = new List<Vehiculo>{
                new Vehiculo{
                    Clase = "Automovil",
                    LicenciaTransito = "3765902341",
                    Placa = "MSG654",
                    Modelo = "2018",
                    Servicio = "Particular",
                    Seguros = " si ",
                    Tecnomecanica = "si"
                },
                new Vehiculo{
                    Clase = "Moto",
                    LicenciaTransito = "000597856",
                    Placa = "RXC67E",
                    Modelo = "2019",
                    Servicio = "Particular",
                    Seguros = " si ",
                    Tecnomecanica = "si"
                }
            };

            var Nuevoaccidente = new Accidente
            {
                Persona = listaPersonas,
                Vehiculo = ListaVehiculos,
                Fecha = new DateTime(2021, 09, 25),
                Hora = "3:40",
                Ciudad = "Medellin",
                Barrio = "Manrique",
                Direccion = "calle 12 N 6 - 8",
                Preacuerdo = " si ",
                NumeroCitacion = "3456",
                Croquis = "si",
                Comparendo = "98",
            };

            Accidente accidenteNuevo = _repoAccidente.AddAccidentes(Nuevoaccidente);
            Console.WriteLine(accidenteNuevo.id);

        }
    }
}














/* namespace AccidTransito.app.Consola
{
  class Program
  {    */
 /*  
    private static IRepositorioAccidente _repoAccidente= new RepositorioAccidente(new Persistencia.AppContext());
    //private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
    static void Main(string[] args)
    {
       Console.WriteLine("Hello World!");
   
       AddAccidentes();
       //AddVehiculos();
        AddPersonas();  
    
       //private static void AddPersonas();
    {
       var Persona = new Persona
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
        _repoPersona.AddPersonas(persona);
     }
    }
        private static void AddAccidentes();
    
        List<Persona> listaPersonas=new List<Persona>{
        new Persona{Nombre="Milton",Apellido = "Giraldo",TipoDocumento = "cc",NumeroIdentificacion = "94468661",
        Pais = "Colombia",Departamento = " Antioquia",CiudadResidencia = "Medellin",Direccion = "cra 99 n 34 - 78",
        NumeroTelefono = "3117274567",Edad = "38",Genero = Genero.Masculino},
        new Persona{Nombre="Maria",Apellido = "Parra",TipoDocumento = "cc",NumeroIdentificacion = "43678976",
        Pais = "Colombia",Departamento = "Caldas",CiudadResidencia = "Manizales",Direccion = "cra 23 n 56 - 70",
        NumeroTelefono = "3007274457",Edad = "24",Genero = Genero.Femenino},
        new Persona{Nombre="Santiago",Apellido = "Areiza",TipoDocumento = "cc",NumeroIdentificacion = "723849003",
        Pais = "Colombia",Departamento = "Cundinamarca",CiudadResidencia = "Bogota",Direccion = "cra 26 n 67 - 12",
        NumeroTelefono = "3016786543",Edad = "45",Genero = Genero.Masculino},                                  
       };
          
        List<Vehiculo> ListaVehiculos=new List<Vehiculo>{
          new Vehiculo{Clase = "Automovil",LicenciaTransito = "3765902341",Placa = "MSG654",Modelo = "2018",Servicio = "Particular",
            Seguros = " si ",Tecnomecanica = "si"},
          new Vehiculo{Clase = "Moto",LicenciaTransito = "000597856",Placa = "RXC67E",Modelo = "2019",Servicio = "Particular",
            Seguros = " si ",Tecnomecanica = "si"}

        };
  
        var Nuevoaccidente = new Accidente
        {
         Persona=listaPersonas,       
         Vehiculo=ListaVehiculos,
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
        Accidente accidenteNuevo =_repoAccidente.AddAccidentes(Nuevoaccidente);        
        Console.WriteLine(accidenteNuevo.id);
      }              
    }
  }         
}
 */