using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPeliculas
{
    class ServicioDialogos
    {
        public enum tipoArchivo { JSON, Imagen };
        public string LeerArchivoJSON()
        {
            string texto = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JSON(*.json)|*.json";
            if (openFileDialog.ShowDialog() == true)
                texto = File.ReadAllText(openFileDialog.FileName);
            return texto;
        }

        public string RutaArchivo(in tipoArchivo tipo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string ruta = "";
            switch (tipo)
            {
                case tipoArchivo.JSON:
                    openFileDialog.Filter = "Archivos JSON(*.json)|*.json";
                    break;
                case tipoArchivo.Imagen:
                    openFileDialog.Filter = "Imagen JPEG(*.jpeg)|*.jpeg|Imagen JPG(*.jpg)|*.jpg|Imagen BMP(*.bmp)|*.bmp";
                    break;
            }
            if (openFileDialog.ShowDialog() == true)
                ruta = Path.GetFileName(openFileDialog.FileName);
            return ruta;
        }
















    }
}
