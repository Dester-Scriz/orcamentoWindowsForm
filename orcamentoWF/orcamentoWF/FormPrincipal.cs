﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Biblioteca para Abrir Processos no Windows
using System.Diagnostics;
using orcamentoWF.Adicionar;

namespace orcamentoWF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClienteCad = new frmClienteAdicionar();
            // Define Hierarquia de Pai e filho do MDI
            frmClienteCad.MdiParent = this;
            // Exibe a tela
            frmClienteCad.Show();
        }
    }
}
