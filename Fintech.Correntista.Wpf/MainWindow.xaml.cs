﻿using Fintech.Dominio;
using Fintech.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fintech.Correntista.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public MainWindow()
        {
            InitializeComponent();
            PopularControles();
        }
        private void PopularControles()
        {
            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Outro);

            clienteDataGrid.ItemsSource = Clientes;
        }
        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            //var cliente = new Cliente();
            Cliente cliente = new();
            cliente.Cpf = cpfTectBox.Text;
            cliente.DataNascimento = Convert.ToDateTime(dataNascimentoTectBox.Text);

            var endereco = new Endereco();
            endereco.Cep = cepTectBox.Text;
            endereco.Cidade = cidadeTectBox.Text;
            endereco.Logradouro = logradouroTectBox.Text;
            endereco.Numero = numeroLogradouroTectBox.Text;

            cliente.EnderecoResidencial = endereco;

            cliente.Nome = nomeTectBox.Text;
            cliente.Sexo = (Sexo)sexoComboBox.SelectedItem;

            Clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso.");
            LimparControlesCliente();

            clienteDataGrid.Items.Refresh();
            pesquisaClienteTabItem.Focus();


        }

        private void LimparControlesCliente()
        {
            cpfTectBox.Clear();
            nomeTectBox.Clear();
            dataNascimentoTectBox.Clear();
            sexoComboBox.SelectedIndex = -1;
            cepTectBox.Clear();
            cidadeTectBox.Clear();
            logradouroTectBox.Clear();
            numeroLogradouroTectBox.Clear();

        }
    }
}
