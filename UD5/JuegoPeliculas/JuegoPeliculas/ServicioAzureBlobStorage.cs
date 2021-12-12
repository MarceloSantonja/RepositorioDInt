using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class ServicioAzureBlobStorage 
    {
        public ServicioAzureBlobStorage()
        {
        }

        public string AlmacenarImagenEnNube( string ruta)
        {

            string cadenaConexion = "DefaultEndpointsProtocol=https;AccountName=juegopeliculasmsa;AccountKey=+DCfwgzSiNEIesIe/XeGxRxcUwceVRm5YFo/dVjpZ36QMG//7Yp11s0YqBhiYdSS6YJ3c444acsViQ3N/3bRbg==;EndpointSuffix=core.windows.net"; 
            string nombreContenedorBlobs = "imagenes"; 
            string rutaImagen = ruta;

            //Obtenemos el cliente del contenedor
            var clienteBlobService = new BlobServiceClient(cadenaConexion);
            var clienteContenedor = clienteBlobService.GetBlobContainerClient(nombreContenedorBlobs);

            //Leemos la imagen y la subimos al contenedor
            Stream streamImagen = File.OpenRead(rutaImagen);
            string nombreImagen = Path.GetFileName(rutaImagen);
            try
            {
                clienteContenedor.UploadBlob(nombreImagen, streamImagen);
            }
            catch (Exception e)
            {

                new ServicioDialogos().MostrarMensaje("Es muy posible que se deba a que ya existe una imagen con este nombre en la nube, pero no puedo asegurartelo!", "Error subiendo la imagen a Azure", System.Windows.MessageBoxImage.Error);
            }
            

            //Una vez subida, obtenemos la URL para referenciarla
            var clienteBlobImagen = clienteContenedor.GetBlobClient(nombreImagen);
            return clienteBlobImagen.Uri.AbsoluteUri;
        }





    }


}
