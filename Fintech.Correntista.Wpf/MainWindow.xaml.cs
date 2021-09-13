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
        public Cliente ClienteSelecionado { get; set; }
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

            var banco = new Banco() { Nome = "Banco Um", Numero = 154 };

            bancoComboBox.Items.Add(banco);
            bancoComboBox.Items.Add(new Banco { Nome = "Banco Dois", Numero = 157 });

            tipoContaComboBox.Items.Add(TipoConta.ContaCorrente);
            tipoContaComboBox.Items.Add(TipoConta.ContaEspecial);
            tipoContaComboBox.Items.Add(TipoConta.Poupanca);
        }

        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            //var cliente = new Cliente();
            Cliente cliente = new();
            cliente.Cpf = cpfTextBox.Text;
            cliente.DataNascimento = Convert.ToDateTime(dataNascimentoTextBox.Text);

            var endereco = new Endereco();
            endereco.Cep = cepTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;
            endereco.Logradouro = logradouroTextBox.Text;
            endereco.Numero = numeroLogradouroTextBox.Text;

            cliente.EnderecoResidencial = endereco;

            cliente.Nome = nomeTextBox.Text;
            cliente.Sexo = (Sexo)sexoComboBox.SelectedItem;

            Clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso.");
            LimparControlesCliente();
            clienteDataGrid.Items.Refresh();
            pesquisaClienteTabItem.Focus();
        }

        private void LimparControlesCliente()
        {
            cpfTextBox.Clear();
            nomeTextBox.Text = "";
            dataNascimentoTextBox.Text = null;
            sexoComboBox.SelectedIndex = -1;
            logradouroTextBox.Text = string.Empty;
            numeroLogradouroTextBox.Clear();
            cidadeTextBox.Clear();
            cepTextBox.Clear();
        }

        private void SelecionarClienteButtonClick(object sender, RoutedEventArgs e)
        {
            var botaoClicado = (Button)sender;
            var clienteSelecionado = botaoClicado.DataContext;

            ClienteSelecionado = (Cliente)clienteSelecionado;

            clienteTextBox.Text = ClienteSelecionado.ToString();
            contasTabItem.Focus();
        }

        private void tipoContaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tipoContaComboBox.SelectedIndex == -1) return;
            var tipoConta = (TipoConta)tipoContaComboBox.SelectedItem;

            if (tipoConta == TipoConta.ContaEspecial)
            {
                limiteDockPanel.Visibility = Visibility.Visible;
                limiteTextBox.Focus();
            }
            else
            {
                limiteDockPanel.Visibility = Visibility.Collapsed;
            }
        }

            private void incluirContaButton_Click(object sender, RoutedEventArgs e)
            {
                Conta conta = null;

                var agencia = new Agencia();
                agencia.Banco = (Banco)bancoComboBox.SelectedItem;
                agencia.Numero = Convert.ToInt32(numeroAgenciaTextBox.Text);
                agencia.DigitoVerificador = Convert.ToInt32(dvAgenciaTextBox.Text);

                var numero = Convert.ToInt32(numeroContaTextBox.Text);
                var digitoVerificador = dvContaTextBox.Text;

                switch ((TipoConta)tipoContaComboBox.SelectedItem)
                {
                    case TipoConta.ContaCorrente:
                        conta = new ContaCorrente(agencia, numero, digitoVerificador);
                        break;
                    case TipoConta.ContaEspecial:
                    var limite = Convert.ToDecimal(limiteTextBox.Text);
                    conta = new ContaEspecial(agencia, numero, digitoVerificador, limite);
                        break;
                    case TipoConta.Poupanca:
                    conta = new Poupanca(agencia, numero, digitoVerificador);
                        break;
                    default:
                        break;
                }
            ClienteSelecionado.Contas.Add(conta);

            MessageBox.Show("Conta adicionada com sucesso");
            LimparControlesConta();
            clienteDataGrid.Items.Refresh();
            clientesTapItem.Focus();

            }

        private void LimparControlesConta()
        {
            clienteTextBox.Clear();
            bancoComboBox.SelectedItem = -1;
            numeroAgenciaTextBox.Clear();
            dvAgenciaTextBox.Clear();
            numeroContaTextBox.Clear();
            dvContaTextBox.Clear();
            tipoContaComboBox.SelectedIndex = -1;
            limiteTextBox.Clear();
        }
    }
    }
