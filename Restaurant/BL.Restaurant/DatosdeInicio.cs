﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static BL.Restaurant.TiemposBL;

namespace BL.Restaurant
{
   public  class DatosdeInicio : CreateDatabaseIfNotExists<Contexto> 
    {
       
        protected override void Seed(Contexto contexto)
        {

           var usuarioAdmin = new Usuario(); 
            usuarioAdmin.Nombre = "Admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var usuarioAdmin2 = new Usuario();
            usuarioAdmin2.Nombre = "Admin2";
            usuarioAdmin2.Contrasena = "1234";
            contexto.Usuarios.Add(usuarioAdmin2);

            var usuarioAdmin3 = new Usuario();
            usuarioAdmin3.Nombre = "Admin3";
            usuarioAdmin3.Contrasena = "12345";
            contexto.Usuarios.Add(usuarioAdmin3);

            var usuarioAdmin4 = new Usuario();
            usuarioAdmin4.Nombre = "Admin4";
            usuarioAdmin4.Contrasena = "123456";
            contexto.Usuarios.Add(usuarioAdmin4);

            var usuarioAdmin5 = new Usuario();
            usuarioAdmin5.Nombre = "RicardoAnduray";
            usuarioAdmin5.Contrasena = "Ricardo";
            contexto.Usuarios.Add(usuarioAdmin5);




            var tiempo1 = new Tiempo();
             tiempo1.Descripcion = "Mañana";
            contexto.Tiempos.Add(tiempo1);

            var tiempo2 = new Tiempo();
            tiempo2.Descripcion = "Tarde";
            contexto.Tiempos.Add(tiempo2);

            var tiempo3 = new Tiempo();
            tiempo3.Descripcion = "Noche";
            contexto.Tiempos.Add(tiempo3);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Desayuno";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Almuerzo";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Cena";
            contexto.Categorias.Add(categoria3);

       
            var cliente1 = new Cliente();
            cliente1.Nombre = "Ricardo";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Rony";
            contexto.Clientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Nombre = "Isis";
            contexto.Clientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Nombre = "Henry";
            contexto.Clientes.Add(cliente4);




            base.Seed(contexto);
        }
    }
}
