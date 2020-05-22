using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjtoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        atleta obj = new atleta();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() + "\n\nIMC: " + obj.CalcularIMC().ToString("F"));
            txt_resultado.Text = obj.CalcularIMC().ToString("F");
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Altura = double.Parse(txt_altura.Text);
                obj.Peso = double.Parse(txt_peso.Text);
                obj.Idade = int.Parse(txt_idade.Text);
               
                MessageBox.Show("Dados armazenados.");
            }
             catch(FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

   
}
