using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class PersonaService
    {

        private PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();

        }
        public RespuestaBusqueda Guardar(Persona persona)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Persona = personaRepository.Buscar(persona.Identificacion);
                if (respuesta.Persona == null)
                {
                    personaRepository.Guardar(persona);
                    respuesta.Mensaje = $"Los datos de {persona.Nombre} han sido guardados correctamente";
                }
                else
                {
                    respuesta.Mensaje = $"La persona con cedula {persona.Identificacion}  ya se encuentra registrada";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
            }
            return respuesta;
        }


        public RespuestaBusqueda Eliminar(string identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Persona = personaRepository.Buscar(identificacion);
                if (respuesta.Persona != null)
                {
                    personaRepository.Eliminar(identificacion);
                    respuesta.Mensaje = $"Los datos de la persona con cedula {identificacion} han sido eliminados correctamente";
                }
                else
                {
                    respuesta.Mensaje = $"La persona con cedula {identificacion} no se encuentra registrada";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos" + E.Message;
            }
            return respuesta;


        }

        public RespuestaBusqueda Modificar(Persona persona)
        {
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();

            try
            {
              personaRepository.Modificar(persona);
                respuestaBusqueda.Persona = persona;
                respuestaBusqueda.Mensaje= $"Los Persona con identificacion {persona.Identificacion} ha sido modificada satisfacatoriamente";
              

            }
            catch (Exception e)
            {

                respuestaBusqueda.Mensaje = "Error de lectura o escritura de archivos"+e.Message;
            }
            return respuestaBusqueda;
        }

        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respueta = new RespuestaBusqueda();

            try
            {
                respueta.Error = false;

                respueta.Persona = personaRepository.Buscar(identificacion);
                if (respueta.Persona != null)
                {
                    respueta.Mensaje = "Se consultaron los datos Satisfactoriamente";
                }
                else
                {
                    respueta.Mensaje = "La Persona solicitada no existe";
                }
                return respueta;
            }
            catch (Exception e)
            {
                respueta.Error = true;
                respueta.Mensaje = "Error de Datos:" + e.Message;
                respueta.Persona = null;
                return respueta;

            }
        }
        public int TotalizarPorSexo(string Sexo)
        {
            return personaRepository.TotalizarPorSexo(Sexo);
        }
        public int TotalizarPersonas()
        {
            return personaRepository.TotalizarPersonas();
        }
        public IList<Persona> ConsultarPorSexo(string Sexo)
        {
            return personaRepository.ConsultarPorSexo(Sexo);
        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                respuesta.Personas=personaRepository.Consultar();
                if (respuesta.Personas!=null)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de personas";
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                }
                
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: "+e.Message;
            }
            return respuesta;

        }

    }



    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
        public bool Error { get; set; }
    }



    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public List<Persona> Personas { get; set; }
        public bool Error { get; set; }
    }

       


}
