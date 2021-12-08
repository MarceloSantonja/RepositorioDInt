using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class ServicioJson
    {
        public void ExportarJSON(in ObservableCollection<Pelicula> lista, in string rutaFichero)
        {
            try
            {
                string peliculasJson = JsonConvert.SerializeObject(lista);
                File.WriteAllText(rutaFichero, peliculasJson);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public ObservableCollection<Pelicula> ImportarJSON(in string rutaFichero)
        {
           
            string peliculasJson = "";
            try
            {
                peliculasJson = File.ReadAllText(rutaFichero);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }

            return JsonConvert.DeserializeObject<ObservableCollection<Pelicula>>(peliculasJson);
        }
    }

}
