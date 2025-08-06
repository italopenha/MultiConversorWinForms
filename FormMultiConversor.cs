using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiConversor
{
    public partial class FormMultiConversor : Form
    {
        public FormMultiConversor()
        {
            InitializeComponent();
            txtCotacaoDolar.Enabled = false;
        }

        #region Conversão de Temperaturas

        /// <summary>
        /// Método para converter Fahrenheit para Celsius.
        /// </summary>
        private void ConverterFahrenheitParaCelsius()
        {
            try
            {
                txtCelsius.Text = string.Empty; // Limpa o campo de saída da antes de converter

                // Verifica se o texto digitado é um número válido
                if (!double.TryParse(txtFahrenheit.Text, out double fahrenheit))
                    return;

                double celsius = (fahrenheit - 32) / 1.8f;
                txtCelsius.Text = celsius.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para converter Celsius para Fahrenheit.
        /// </summary>
        private void ConverterCelsiusParaFahrenheit()
        {
            try
            {
                txtFahrenheit.Text = string.Empty; // Limpa o campo de saída da antes de converter

                if (!double.TryParse(txtCelsius.Text, out double celsius))
                    return;

                double fahrenheit = (celsius * 1.8f) + 32;
                txtFahrenheit.Text = fahrenheit.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Permite sinal de menos, mas apenas se:
                // - ele estiver no início
                // - ainda não houver um sinal de menos
                if (e.KeyChar == '-')
                {
                    if (textBox.SelectionStart != 0 || textBox.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtFahrenheit_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtFahrenheit.Text) && txtFahrenheit.Text != "-") // Verifica se o campo não está vazio  
                {
                    ConverterFahrenheitParaCelsius();
                }
                else
                {
                    txtCelsius.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Permite sinal de menos, mas apenas se:
                // - ele estiver no início
                // - ainda não houver um sinal de menos
                if (e.KeyChar == '-')
                {
                    if (textBox.SelectionStart != 0 || textBox.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtCelsius_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCelsius.Text) && txtCelsius.Text != "-") // Verifica se o campo não está vazio  
                {
                    ConverterCelsiusParaFahrenheit();
                }
                else
                {
                    txtFahrenheit.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Conversão de Moedas

        /// <summary>
        /// Método para obter a cotação de uma moeda em relação a outra usando a API ExchangeRate-API.
        /// </summary>
        /// <param name="moedaOrigem"></param>
        /// <param name="moedaDestino"></param>
        /// <returns></returns>
        private async Task<decimal> ObterCotacaoAsync(string moedaOrigem, string moedaDestino)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpResponseMessage resposta = await cliente.GetAsync($"https://v6.exchangerate-api.com/v6/e49bcf089726ccc1cbfb750b/latest/{moedaOrigem}");
                    if (resposta.IsSuccessStatusCode)
                    {
                        string jsonString = await resposta.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<RespostaTaxaCambio>(jsonString);
                        return dados.conversion_rates[moedaDestino];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao obter a cotação");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para converter Dólar para Real.
        /// </summary>
        private async void ConverterDolarParaRealAsync()
        {
            try
            {
                txtReal.Text = string.Empty; // Limpa o campo de saída da antes de converter

                if (!decimal.TryParse(txtDolar.Text, out decimal dolar))
                    return;

                decimal cotacaoDolar = await ObterCotacaoAsync("USD", "BRL");
                decimal real = dolar * cotacaoDolar;
                txtReal.Text = real.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para converter Real para Dólar.
        /// </summary>
        private async void ConverterRealParaDolarAsync()
        {
            try
            {
                txtDolar.Text = string.Empty; // Limpa o campo de saída da antes de converter

                if (!decimal.TryParse(txtReal.Text, out decimal real))
                    return;

                decimal cotacaoReal = await ObterCotacaoAsync("BRL", "USD");
                decimal dolar = real * cotacaoReal;
                txtDolar.Text = dolar.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        /// <summary>
        /// Método para obter a cotação do Dólar ao iniciar o formulário.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private async void ObterCotacaoDolarAsync()
        {
            try
            {
                decimal cotacaoDolar = await ObterCotacaoAsync("USD", "BRL");
                txtCotacaoDolar.Text = cotacaoDolar.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtDolar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDolar.Text)) // Verifica se o campo não está vazio  
                {
                    ConverterDolarParaRealAsync();
                }
                else
                {
                    txtReal.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtReal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtReal.Text)) // Verifica se o campo não está vazio  
                {
                    ConverterRealParaDolarAsync();
                }
                else
                {
                    txtDolar.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FormMultiConversor_Load(object sender, EventArgs e)
        {
            try
            {
                ObterCotacaoDolarAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Conversão Quilômetros / Milhas

        private void ConverterMilhasParaQuilometros()
        {
            try
            {
                txtQuilometro.Text = string.Empty;

                if (!float.TryParse(txtMilha.Text, out float milha))
                    return;

                float quilometro = milha * 1.60934f;
                txtQuilometro.Text = quilometro.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ConverterQuilometrosParaMilhas()
        {
            try
            {
                txtMilha.Text = string.Empty;

                if (!float.TryParse(txtQuilometro.Text, out float quilometro))
                    return;

                float milha = quilometro / 1.60934f;
                txtMilha.Text = milha.ToString("F2");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtMilha_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtMilha_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtMilha.Text)) // Verifica se o campo não está vazio  
                {
                    ConverterMilhasParaQuilometros();
                }
                else
                {
                    txtQuilometro.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtQuilometro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Permite teclas de controle (ex: backspace, delete)
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                // Permite dígitos (0-9)
                if (char.IsDigit(e.KeyChar))
                {
                    return;
                }

                // Permite vírgula, mas apenas se:
                // - ainda não houver uma vírgula
                // - já houver ao menos um dígito antes dela
                if (e.KeyChar == ',')
                {
                    // Já tem vírgula? Ou não tem número ainda? Então bloqueia
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0 || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }

                    return;
                }

                // Bloqueia qualquer outra tecla
                e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtQuilometro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtQuilometro.Text)) // Verifica se o campo não está vazio  
                {
                    ConverterQuilometrosParaMilhas();
                }
                else
                {
                    txtMilha.Text = string.Empty; // Limpa o campo de saída se o campo de entrada estiver vazio  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }

    /// <summary>
    /// Classe para armazenar a resposta da API de taxa de câmbio.
    /// </summary>
    public class RespostaTaxaCambio
    {
        public Dictionary<string, decimal> conversion_rates { get; set; }
    }
}
