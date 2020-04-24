using System;
using System.Windows.Forms;
// Chamar o Web Service
using ModeloCotacaoRNEv3.wsCotacao;


namespace ModeloCotacaoRNEv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Evento que carrega o formulario
        private void Form1_Load(object sender, EventArgs e)
        {            
           
                FachadaWSSGSClient ws = new FachadaWSSGSClient();
                var valorCotacao = ws.getUltimosValoresSerieVO(1, 1).valores[0].svalor;
                double dividirDolar = Convert.ToDouble(valorCotacao) / 10000;
                textBoxCotacaoDolar.Text = dividirDolar.ToString("N2");
               
        }  
        public static void MascaraMoeda(ref TextBox text)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = text.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;
                text.Text = string.Format("{0:N}", v);
                text.SelectionStart = text.Text.Length;
            }
            catch (Exception)
            {            
              
            }
        }
        private void textBoxCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxPIS_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxPIS);
            
        }
        private void textBoxSeguro_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxSeguro);
        }
        private void textBoxCombustivel_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxCombustivel);
        }
        private void textBoxDespesasAdm_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxDespesasAdm);
        }        
        private void textBoxIRPJ_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxDepreciacao_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxDepreciacao);
        }
        private void textBoxSalario_TextChanged(object sender, EventArgs e)
        {
            MascaraMoeda(ref textBoxSalario);            
        }                
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int distancia = int.Parse(textBoxDistancia.Text);
            int tempoViagem = int.Parse(textBoxTempoViagem.Text);
            double pis = double.Parse(textBoxPIS.Text);
            double seguro = double.Parse(textBoxSeguro.Text);
            double salarioEncargos = double.Parse(textBoxSalario.Text);
            double depreciacao = double.Parse(textBoxDepreciacao.Text);
            double combustivel = double.Parse(textBoxCombustivel.Text);
            double despesasAdm = double.Parse(textBoxDespesasAdm.Text);
            double irpj = double.Parse(textBoxIRPJ.Text);
            double profit = double.Parse(textBoxProfit.Text);
            double cotacaoDolar = double.Parse(textBoxCotacaoDolar.Text);

            double resultadoCombustivel = distancia * combustivel;
            double resultadodespesasAdm = tempoViagem * despesasAdm;
            double resultadoDepreciacao = tempoViagem * depreciacao;
            double resultadoSalariosEncargos = salarioEncargos * tempoViagem ;

            double resultadoTempo = resultadodespesasAdm + resultadoDepreciacao + resultadoSalariosEncargos;
            double resultadoPIS = (resultadoCombustivel + resultadoTempo) * (pis / 100);

            double resultadoSeguro = (resultadoCombustivel + resultadoTempo + resultadoPIS) * (seguro / 100);

            double resultadoCustoFinal = resultadoCombustivel + resultadoTempo + resultadoPIS + resultadoSeguro;

            double resultadoCustoIRPJ = resultadoCustoFinal * (irpj / 100);
            double resultadoCustoProfit = (resultadoCustoFinal + resultadoCustoIRPJ) * (profit / 100);

            double resultadoFreteVendaRS = resultadoCustoFinal + resultadoCustoIRPJ + resultadoCustoProfit;
            double resultadoFreteVendaUSD = resultadoFreteVendaRS / cotacaoDolar;
            
            textBoxCustoTotal.Text = resultadoCustoFinal.ToString("C2");
            textBoxResultadoFinalRS.Text = resultadoFreteVendaRS.ToString("C2");       
            textBoxResultadoFinalUSD.Text = ($@"US$ "+ resultadoFreteVendaUSD.ToString("N2"));

        }
    }
}
