namespace RedPerceptron
{
    partial class Simulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgThreshold = new System.Windows.Forms.DataGridView();
            this.dgWeights = new System.Windows.Forms.DataGridView();
            this.btnLoadNetworkParams = new System.Windows.Forms.Button();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.btnLoadSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOutputs = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Umbrales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pesos";
            // 
            // dgThreshold
            // 
            this.dgThreshold.AllowUserToAddRows = false;
            this.dgThreshold.AllowUserToDeleteRows = false;
            this.dgThreshold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThreshold.Location = new System.Drawing.Point(317, 37);
            this.dgThreshold.Name = "dgThreshold";
            this.dgThreshold.RowHeadersWidth = 51;
            this.dgThreshold.RowTemplate.Height = 24;
            this.dgThreshold.Size = new System.Drawing.Size(216, 150);
            this.dgThreshold.TabIndex = 17;
            // 
            // dgWeights
            // 
            this.dgWeights.AllowUserToAddRows = false;
            this.dgWeights.AllowUserToDeleteRows = false;
            this.dgWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeights.Location = new System.Drawing.Point(15, 37);
            this.dgWeights.Name = "dgWeights";
            this.dgWeights.RowHeadersWidth = 51;
            this.dgWeights.RowTemplate.Height = 24;
            this.dgWeights.Size = new System.Drawing.Size(277, 182);
            this.dgWeights.TabIndex = 16;
            // 
            // btnLoadNetworkParams
            // 
            this.btnLoadNetworkParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadNetworkParams.Location = new System.Drawing.Point(554, 37);
            this.btnLoadNetworkParams.Name = "btnLoadNetworkParams";
            this.btnLoadNetworkParams.Size = new System.Drawing.Size(150, 54);
            this.btnLoadNetworkParams.TabIndex = 20;
            this.btnLoadNetworkParams.Text = "Cargar Pesos y umbrales";
            this.btnLoadNetworkParams.UseVisualStyleBackColor = true;
            this.btnLoadNetworkParams.Click += new System.EventHandler(this.btnLoadNetworkParams_Click);
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(242, 603);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(106, 27);
            this.txtX2.TabIndex = 21;
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(17, 603);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(106, 27);
            this.txtX1.TabIndex = 22;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(346, 669);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(91, 49);
            this.btnSimulate.TabIndex = 23;
            this.btnSimulate.Text = "Simular";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(132, 691);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(106, 27);
            this.txtResult.TabIndex = 24;
            // 
            // dgSP
            // 
            this.dgSP.AllowUserToAddRows = false;
            this.dgSP.AllowUserToDeleteRows = false;
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Location = new System.Drawing.Point(17, 260);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowHeadersWidth = 51;
            this.dgSP.RowTemplate.Height = 24;
            this.dgSP.Size = new System.Drawing.Size(397, 263);
            this.dgSP.TabIndex = 25;
            // 
            // btnLoadSP
            // 
            this.btnLoadSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSP.Location = new System.Drawing.Point(434, 263);
            this.btnLoadSP.Name = "btnLoadSP";
            this.btnLoadSP.Size = new System.Drawing.Size(185, 52);
            this.btnLoadSP.TabIndex = 26;
            this.btnLoadSP.Text = "Cargar Patrones para  simulacion";
            this.btnLoadSP.UseVisualStyleBackColor = true;
            this.btnLoadSP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Patrones para la Simulación";
            // 
            // dgOutputs
            // 
            this.dgOutputs.AllowUserToAddRows = false;
            this.dgOutputs.AllowUserToDeleteRows = false;
            this.dgOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutputs.Location = new System.Drawing.Point(638, 263);
            this.dgOutputs.Name = "dgOutputs";
            this.dgOutputs.RowHeadersWidth = 51;
            this.dgOutputs.RowTemplate.Height = 24;
            this.dgOutputs.Size = new System.Drawing.Size(300, 259);
            this.dgOutputs.TabIndex = 28;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(434, 481);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 42);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calcular salidas";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Salida";
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgOutputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadSP);
            this.Controls.Add(this.dgSP);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.btnLoadNetworkParams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgThreshold);
            this.Controls.Add(this.dgWeights);
            this.Name = "Simulacion";
            this.Text = "Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgThreshold;
        private System.Windows.Forms.DataGridView dgWeights;
        private System.Windows.Forms.Button btnLoadNetworkParams;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.Button btnLoadSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOutputs;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}