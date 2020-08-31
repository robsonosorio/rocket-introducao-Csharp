using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // importe de componentes

namespace SimpleToPark
{
    public partial class FormPrincipal : Form
    {
        private DataTable bancoDeDados;
        public FormPrincipal()
        {
            InitializeComponent();

            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa", typeof(string));
            bancoDeDados.Columns.Add("Entrada", typeof(string));

            dataGridViewCarrosEstacionados.DataSource = bancoDeDados;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do veículo:", "Entrada de veículo");
            if (!string.IsNullOrEmpty(placa))
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString()});
                dataGridViewCarrosEstacionados.Rows[dataGridViewCarrosEstacionados.Rows.Count - 1].MinimumHeight = 30; // modicado a altura da ultima linha
            }
        }
    }
}
