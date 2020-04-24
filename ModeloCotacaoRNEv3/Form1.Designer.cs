namespace ModeloCotacaoRNEv3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDistancia = new System.Windows.Forms.TextBox();
            this.textBoxPIS = new System.Windows.Forms.TextBox();
            this.textBoxSeguro = new System.Windows.Forms.TextBox();
            this.textBoxTempoViagem = new System.Windows.Forms.TextBox();
            this.textBoxDespesasAdm = new System.Windows.Forms.TextBox();
            this.textBoxCotacaoDolar = new System.Windows.Forms.TextBox();
            this.textBoxCustoTotal = new System.Windows.Forms.TextBox();
            this.textBoxIRPJ = new System.Windows.Forms.TextBox();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.textBoxResultadoFinalRS = new System.Windows.Forms.TextBox();
            this.textBoxResultadoFinalUSD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCombustivel = new System.Windows.Forms.TextBox();
            this.textBoxDepreciacao = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDistancia
            // 
            this.textBoxDistancia.Location = new System.Drawing.Point(168, 60);
            this.textBoxDistancia.Name = "textBoxDistancia";
            this.textBoxDistancia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistancia.TabIndex = 1;
            this.textBoxDistancia.Text = "0";
            this.textBoxDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPIS
            // 
            this.textBoxPIS.Location = new System.Drawing.Point(178, 113);
            this.textBoxPIS.Name = "textBoxPIS";
            this.textBoxPIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxPIS.TabIndex = 3;
            this.textBoxPIS.Text = "0,00";
            this.textBoxPIS.TextChanged += new System.EventHandler(this.textBoxPIS_TextChanged);
            // 
            // textBoxSeguro
            // 
            this.textBoxSeguro.Location = new System.Drawing.Point(178, 139);
            this.textBoxSeguro.Name = "textBoxSeguro";
            this.textBoxSeguro.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeguro.TabIndex = 4;
            this.textBoxSeguro.Text = "0,00";
            this.textBoxSeguro.TextChanged += new System.EventHandler(this.textBoxSeguro_TextChanged);
            // 
            // textBoxTempoViagem
            // 
            this.textBoxTempoViagem.Location = new System.Drawing.Point(297, 60);
            this.textBoxTempoViagem.Name = "textBoxTempoViagem";
            this.textBoxTempoViagem.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempoViagem.TabIndex = 2;
            this.textBoxTempoViagem.Text = "0";
            // 
            // textBoxDespesasAdm
            // 
            this.textBoxDespesasAdm.Location = new System.Drawing.Point(178, 164);
            this.textBoxDespesasAdm.Name = "textBoxDespesasAdm";
            this.textBoxDespesasAdm.Size = new System.Drawing.Size(100, 20);
            this.textBoxDespesasAdm.TabIndex = 5;
            this.textBoxDespesasAdm.Text = "14,39";
            this.textBoxDespesasAdm.TextChanged += new System.EventHandler(this.textBoxDespesasAdm_TextChanged);
            // 
            // textBoxCotacaoDolar
            // 
            this.textBoxCotacaoDolar.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCotacaoDolar.Enabled = false;
            this.textBoxCotacaoDolar.Location = new System.Drawing.Point(503, 60);
            this.textBoxCotacaoDolar.Name = "textBoxCotacaoDolar";
            this.textBoxCotacaoDolar.Size = new System.Drawing.Size(93, 20);
            this.textBoxCotacaoDolar.TabIndex = 9;
            this.textBoxCotacaoDolar.TextChanged += new System.EventHandler(this.textBoxCotacaoDolar_TextChanged);
            // 
            // textBoxCustoTotal
            // 
            this.textBoxCustoTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCustoTotal.Enabled = false;
            this.textBoxCustoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustoTotal.Location = new System.Drawing.Point(501, 111);
            this.textBoxCustoTotal.Name = "textBoxCustoTotal";
            this.textBoxCustoTotal.Size = new System.Drawing.Size(126, 20);
            this.textBoxCustoTotal.TabIndex = 10;
            // 
            // textBoxIRPJ
            // 
            this.textBoxIRPJ.Location = new System.Drawing.Point(501, 142);
            this.textBoxIRPJ.Name = "textBoxIRPJ";
            this.textBoxIRPJ.Size = new System.Drawing.Size(27, 20);
            this.textBoxIRPJ.TabIndex = 10;
            this.textBoxIRPJ.Text = "15";
            this.textBoxIRPJ.TextChanged += new System.EventHandler(this.textBoxIRPJ_TextChanged);
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(501, 168);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(27, 20);
            this.textBoxProfit.TabIndex = 11;
            this.textBoxProfit.Text = "0";
            // 
            // textBoxResultadoFinalRS
            // 
            this.textBoxResultadoFinalRS.Enabled = false;
            this.textBoxResultadoFinalRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoFinalRS.Location = new System.Drawing.Point(82, 27);
            this.textBoxResultadoFinalRS.Name = "textBoxResultadoFinalRS";
            this.textBoxResultadoFinalRS.Size = new System.Drawing.Size(126, 20);
            this.textBoxResultadoFinalRS.TabIndex = 13;
            // 
            // textBoxResultadoFinalUSD
            // 
            this.textBoxResultadoFinalUSD.Enabled = false;
            this.textBoxResultadoFinalUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoFinalUSD.Location = new System.Drawing.Point(82, 53);
            this.textBoxResultadoFinalUSD.Name = "textBoxResultadoFinalUSD";
            this.textBoxResultadoFinalUSD.Size = new System.Drawing.Size(126, 20);
            this.textBoxResultadoFinalUSD.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PIS/COFINS (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Seguro (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Despesas Adm.  (R$)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cotação Dólar (R$)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tempo de Viagem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Distância/Km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "IRPJ (%)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Custo Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Profit (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Combustível (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salários/Encargos (R$)";
            // 
            // textBoxCombustivel
            // 
            this.textBoxCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCombustivel.Location = new System.Drawing.Point(132, 79);
            this.textBoxCombustivel.Name = "textBoxCombustivel";
            this.textBoxCombustivel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCombustivel.TabIndex = 9;
            this.textBoxCombustivel.Text = "1,61";
            this.textBoxCombustivel.TextChanged += new System.EventHandler(this.textBoxCombustivel_TextChanged);
            // 
            // textBoxDepreciacao
            // 
            this.textBoxDepreciacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepreciacao.Location = new System.Drawing.Point(132, 53);
            this.textBoxDepreciacao.Name = "textBoxDepreciacao";
            this.textBoxDepreciacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepreciacao.TabIndex = 8;
            this.textBoxDepreciacao.Text = "128,70";
            this.textBoxDepreciacao.TextChanged += new System.EventHandler(this.textBoxDepreciacao_TextChanged);
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalario.Location = new System.Drawing.Point(132, 27);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalario.TabIndex = 7;
            this.textBoxSalario.Text = "275,50";
            this.textBoxSalario.TextChanged += new System.EventHandler(this.textBoxSalario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Depreciação (R$)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxSalario);
            this.groupBox3.Controls.Add(this.textBoxDepreciacao);
            this.groupBox3.Controls.Add(this.textBoxCombustivel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 131);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custos/Dia";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalcular.Location = new System.Drawing.Point(82, 82);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 34);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.textBoxResultadoFinalRS);
            this.groupBox2.Controls.Add(this.textBoxResultadoFinalUSD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Frete Venda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProfit);
            this.Controls.Add(this.textBoxIRPJ);
            this.Controls.Add(this.textBoxCustoTotal);
            this.Controls.Add(this.textBoxCotacaoDolar);
            this.Controls.Add(this.textBoxDespesasAdm);
            this.Controls.Add(this.textBoxTempoViagem);
            this.Controls.Add(this.textBoxSeguro);
            this.Controls.Add(this.textBoxPIS);
            this.Controls.Add(this.textBoxDistancia);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Frete Mercosul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDistancia;
        private System.Windows.Forms.TextBox textBoxPIS;
        private System.Windows.Forms.TextBox textBoxSeguro;
        private System.Windows.Forms.TextBox textBoxTempoViagem;
        private System.Windows.Forms.TextBox textBoxDespesasAdm;
        private System.Windows.Forms.TextBox textBoxCotacaoDolar;
        private System.Windows.Forms.TextBox textBoxCustoTotal;
        private System.Windows.Forms.TextBox textBoxIRPJ;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.TextBox textBoxResultadoFinalRS;
        private System.Windows.Forms.TextBox textBoxResultadoFinalUSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxDepreciacao;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

