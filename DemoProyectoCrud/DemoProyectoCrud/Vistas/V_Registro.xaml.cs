﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using DemoProyectoCrud.Tablas;
using System.Collections.ObjectModel;
using System.IO;
using DemoProyectoCrud.Datos;

namespace DemoProyectoCrud.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Registro : ContentPage
    {
        private SQLiteAsyncConnection conexion;
        public V_Registro()
        {
            InitializeComponent();
            conexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            var DatosContacto = new T_Contacto
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                Telefono = txtTelefono.Text
            };
            conexion.InsertAsync(DatosContacto);
            limpiarFormulario();
            DisplayAlert("Confirmación", "El contacto se registró correctamente", "OK");
        }
        private void limpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
        }
    }
}