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
        public string Guardar(Persona persona)
        {

            try
            {
                if (personaRepository.Buscar(persona.Identificacion) == null)
                {
                    
                    personaRepository.Guardar(persona);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"La identificacion {persona.Identificacion} ya se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
            }
        }


        public string Eliminar(string identificacion)
        {
            try
            {
                if (personaRepository.Buscar(identificacion) != null)
                {

                    personaRepository.Eliminar(identificacion);
                    return $"Los Persona con identificacion {identificacion} ha sido eliminada satisfacatoriamente";
                }
                return $"La identificacion {identificacion} no se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }


        }

        public string Modificar(Persona persona)
        {

            try
            {
                if (personaRepository.Buscar(persona.Identificacion) != null)
                {

                    personaRepository.Modificar(persona);
                    return $"Los Persona con identificacion {persona.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {persona.Identificacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
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
