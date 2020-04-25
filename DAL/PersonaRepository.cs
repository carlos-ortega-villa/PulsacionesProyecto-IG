using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;
namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = @"Persona.txt";
        private List<Persona> personas;
        public PersonaRepository()
        {
            personas = new List<Persona>();
        }
        public void Guardar(Persona persona)
        
        {
            FileStream fileStream = new FileStream(ruta,FileMode.Append);
            StreamWriter stream = new StreamWriter (fileStream);
            stream.WriteLine(persona.ToString());
            stream.Close();
            fileStream.Close();
            
        }

        public List<Persona> Consultar()
        {
            personas.Clear();
            
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while((linea=lector.ReadLine())!=null)
            {
                Persona persona = new Persona();
                string[] datos = linea.Split(';');
                persona.Identificacion = datos[0];
                persona.Nombre = datos[1];
                persona.Edad = int.Parse(datos[2]);
                persona.Sexo = datos[3];
                persona.Pulsacion = Convert.ToDecimal(datos[4]);
                personas.Add(persona);
            }
            fileStream.Close();
            lector.Close();
            return personas;
        }


        public void Eliminar(string identificacion)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion!=identificacion)
                {
                    Guardar(item);
                }
            }

        }

        public void Modificar(Persona persona)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != persona.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(persona);
                }
            }

        }

        public Persona Buscar(string identificacion) 
        {
            personas.Clear();
            personas = Consultar();
            Persona persona = new Persona();
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        public Persona MapearPersona(string linea)
        {
            Persona persona = new Persona();
            string[] datos = linea.Split(';');
            persona.Identificacion = datos[0];
            persona.Nombre = datos[1];
            persona.Edad = int.Parse(datos[2]);
            persona.Sexo = datos[3];
            persona.Pulsacion = int.Parse(datos[4]);
            return persona;
        }
        public int TotalizarPorSexo(string Sexo)
        {
            return personas.Count(p => p.Sexo == Sexo);
        }
        public int TotalizarPersonas()
        {
            return personas.Count();
        }
        public IList<Persona> ConsultarPorSexo(string Sexo)
        {
            return personas.Where(p => p.Sexo == Sexo).ToList();
        }
    }
}
