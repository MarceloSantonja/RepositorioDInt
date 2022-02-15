using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimaPracticaExamen.modelo
{
    class Componente : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre , value); }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { SetProperty(ref tipo, value); }
        }
        private string foto;

        public string Foto
        {
            get { return foto; }
            set { SetProperty(ref foto, value); }
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { SetProperty(ref precio, value); }
        }


        public Componente(string nombre, string tipo, string foto, int precio)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Foto = foto;
            this.Precio = precio;
        }

        public static ObservableCollection<Componente> GetSamples()
        {
            var lista = new ObservableCollection<Componente>();
            lista.Add(new Componente("AMD Ryzen 7 5800X", "Procesador", "AMD_Ryzen_7_5800X.jpg", 452));
            lista.Add(new Componente("Intel Core i7-11700K", "Procesador", "Intel_Core_i7_11700K.jpg", 365));
            lista.Add(new Componente("Gainward 471056224", "Tarjeta", "Gainward_471056224.jpg", 1719));
            lista.Add(new Componente("ASUS ROG Maximus XIII Extreme", "Placa base", "ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
            lista.Add(new Componente("ASRock X570 Creator", "Placa base", "ASRock_X570_Creator.jpg", 512));
            return lista;
        }
    }
}
