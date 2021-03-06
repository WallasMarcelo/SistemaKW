﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sistema_FotoStudio.View
{
    public partial class frmPesquisaFornecedor : Form
    {
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        public string CPF
        {
            get
            {
                mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCPF.Text;
                mskCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCPF.Text = value;
            }
        }

        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }

        public string CNPJ
        {
            get
            {
                mskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCNPJ.Text;
                mskCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCNPJ.Text = value;
            }
        }

        public string razaoSocial { get => txtrazaoSocial.Text; set => txtrazaoSocial.Text = value; }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            pesquisaFornecedorController pesquisaFornecedor = new pesquisaFornecedorController();
            DataTable dataTable = new DataTable();

            if (!CPF.Equals(""))
            {
                ListarDados(pesquisaFornecedor.pesquisaPorCPF(CPF));
                return;
               
            }

            if (!CNPJ.Equals("")){
               ListarDados(pesquisaFornecedor.pesquisaPorCNPJ(CNPJ));
                return;
            }

            if (!Nome.Equals(""))
            {
                ListarDados(pesquisaFornecedor.pesquisaPorNome(Nome));
                return;
            }

            if (!razaoSocial.Equals(""))
            {
                ListarDados(pesquisaFornecedor.pesquisaPorRazaoSocial(razaoSocial));
                return;
            }

        }


        public void ListarDados(DataTable tabela)
        {

            dataGridFornecedor.DataSource = tabela;
         
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Nome = "";
            CPF = "";
            CNPJ = "";
            razaoSocial = "";

            dataGridFornecedor.DataSource = null;
            dataGridFornecedor.Rows.Clear();
            dataGridFornecedor.Refresh();


        }
    }
}
