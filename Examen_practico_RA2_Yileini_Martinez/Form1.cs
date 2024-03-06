using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_practico_RA2_Yileini_Martinez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;

            DialogResult resultado = dlg_Guardar.ShowDialog();

            // Verificar si el usuario presionó el botón Guardar
            if (resultado == DialogResult.OK)
            {

                string ruta_archivo = dlg_Guardar.FileName;
                string crea_texto = ruta_archivo;


                using (StreamWriter archivo = File.CreateText(ruta_archivo))
                {
                    foreach (DataGridViewRow fila in dgv_Datos.Rows)
                    {
                        // Obtiene los valores de las celdas (supongamos que son 4 columnas)
                        string valorColumna1 = fila.Cells[0].Value?.ToString() ?? "";
                        string valorColumna2 = fila.Cells[1].Value?.ToString() ?? "";
                        string valorColumna3 = fila.Cells[2].Value?.ToString() ?? "";
                        string valorColumna4 = fila.Cells[7].Value?.ToString() ?? "";
                        string valorColumna5 = fila.Cells[8].Value?.ToString() ?? "";

                        // Escribe los valores en el archivo de texto
                        archivo.WriteLine($"\r Matricula:{valorColumna1}, \r Nombre:{valorColumna2}, \r Direccion:{valorColumna3}, \r  Area_Tecnica:{valorColumna4}, \r Curso_Sesion:{valorColumna5}");

                    }
                }


            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;

            int fila;
            fila = dgv_Datos.CurrentRow.Index;
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                dgv_Datos.Rows.RemoveAt(fila);
                MessageBox.Show("Resgistro Eliminar");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
          
            string matricula  = txt_Matricula.Text;
            string nombre = txt_Nombre.Text;
            string direccion = txt_Direccion.Text;
            string email = txt_Email.Text;
            string maestro = txt_Maestro_titular.Text;
            double telefono;

            telefono = Convert.ToDouble(txt_Telefono.Text);
            
            string genero = "";
            

            if (rb_Femenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rb_Masculino.Checked)
            {
                genero = "Masculino";
            }


            dgv_Datos.Rows.Add(txt_Matricula.Text,txt_Nombre.Text, txt_Direccion.Text,txt_Telefono.Text,txt_Email.Text, txt_Maestro_titular.Text, genero,cb_area_tecnica.Text,cb_curso.Text) ;

            txt_Matricula.Focus();
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Direccion.Clear();
            txt_Email.Clear();
            txt_Telefono.Clear();
            txt_Maestro_titular.Clear();
        


        }

      
    }
}
