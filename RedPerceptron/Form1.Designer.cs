namespace RedPerceptron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.btnLoadNetwork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLearningRat = new System.Windows.Forms.TextBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgWeights = new System.Windows.Forms.DataGridView();
            this.dgThreshold = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtERMSAllowed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoIterations = new System.Windows.Forms.TextBox();
            this.dgERMS = new System.Windows.Forms.DataGridView();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadWandT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrentIteration = new System.Windows.Forms.TextBox();
            this.txtCurrentERMS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgERMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputs
            // 
            this.txtInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputs.Location = new System.Drawing.Point(15, 78);
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(96, 30);
            this.txtInputs.TabIndex = 1;
            // 
            // btnLoadNetwork
            // 
            this.btnLoadNetwork.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoadNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadNetwork.Location = new System.Drawing.Point(15, 131);
            this.btnLoadNetwork.Name = "btnLoadNetwork";
            this.btnLoadNetwork.Size = new System.Drawing.Size(258, 62);
            this.btnLoadNetwork.TabIndex = 2;
            this.btnLoadNetwork.Text = "Cargar datos de Entrenamiento";
            this.btnLoadNetwork.UseVisualStyleBackColor = true;
            this.btnLoadNetwork.Click += new System.EventHandler(this.btnLoadNetwork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salidas";
            // 
            // txtOutputs
            // 
            this.txtOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputs.Location = new System.Drawing.Point(158, 78);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.Size = new System.Drawing.Size(97, 30);
            this.txtOutputs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patrones";
            // 
            // txtPatterns
            // 
            this.txtPatterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatterns.Location = new System.Drawing.Point(298, 78);
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(101, 30);
            this.txtPatterns.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "RA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLearningRat
            // 
            this.txtLearningRat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRat.Location = new System.Drawing.Point(447, 78);
            this.txtLearningRat.Name = "txtLearningRat";
            this.txtLearningRat.Size = new System.Drawing.Size(101, 30);
            this.txtLearningRat.TabIndex = 10;
            this.txtLearningRat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarEntrenamientoToolStripMenuItem,
            this.simularToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarEntrenamientoToolStripMenuItem
            // 
            this.cargarEntrenamientoToolStripMenuItem.Name = "cargarEntrenamientoToolStripMenuItem";
            this.cargarEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.cargarEntrenamientoToolStripMenuItem.Text = "Cargar Datos Entrenamiento";
            this.cargarEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.cargarEntrenamientoToolStripMenuItem_Click);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dgWeights
            // 
            this.dgWeights.AllowUserToAddRows = false;
            this.dgWeights.AllowUserToDeleteRows = false;
            this.dgWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeights.Location = new System.Drawing.Point(15, 261);
            this.dgWeights.Name = "dgWeights";
            this.dgWeights.RowHeadersWidth = 51;
            this.dgWeights.RowTemplate.Height = 24;
            this.dgWeights.Size = new System.Drawing.Size(277, 182);
            this.dgWeights.TabIndex = 12;
            this.dgWeights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWeights_CellContentClick);
            // 
            // dgThreshold
            // 
            this.dgThreshold.AllowUserToAddRows = false;
            this.dgThreshold.AllowUserToDeleteRows = false;
            this.dgThreshold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThreshold.Location = new System.Drawing.Point(317, 261);
            this.dgThreshold.Name = "dgThreshold";
            this.dgThreshold.RowHeadersWidth = 51;
            this.dgThreshold.RowTemplate.Height = 24;
            this.dgThreshold.Size = new System.Drawing.Size(216, 150);
            this.dgThreshold.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pesos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Umbrales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(741, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "ERMS Permitido";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtERMSAllowed
            // 
            this.txtERMSAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtERMSAllowed.Location = new System.Drawing.Point(746, 78);
            this.txtERMSAllowed.Name = "txtERMSAllowed";
            this.txtERMSAllowed.Size = new System.Drawing.Size(101, 30);
            this.txtERMSAllowed.TabIndex = 16;
            this.txtERMSAllowed.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "No. Iteraciones";
            // 
            // txtNoIterations
            // 
            this.txtNoIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoIterations.Location = new System.Drawing.Point(592, 78);
            this.txtNoIterations.Name = "txtNoIterations";
            this.txtNoIterations.Size = new System.Drawing.Size(101, 30);
            this.txtNoIterations.TabIndex = 18;
            // 
            // dgERMS
            // 
            this.dgERMS.AllowUserToAddRows = false;
            this.dgERMS.AllowUserToDeleteRows = false;
            this.dgERMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgERMS.Location = new System.Drawing.Point(15, 459);
            this.dgERMS.Name = "dgERMS";
            this.dgERMS.RowHeadersWidth = 51;
            this.dgERMS.RowTemplate.Height = 24;
            this.dgERMS.Size = new System.Drawing.Size(277, 188);
            this.dgERMS.TabIndex = 20;
            this.dgERMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(324, 459);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(369, 188);
            this.txtLog.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(317, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 62);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ver datos de Entrenamiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Log";
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(854, 176);
            this.chart1.Name = "chart1";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(433, 235);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1126, 777);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 57);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Guardar pesos y umbrales actuales";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chart2
            // 
            chartArea12.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart2.Legends.Add(legend12);
            this.chart2.Location = new System.Drawing.Point(854, 474);
            this.chart2.Name = "chart2";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "YR";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "YD";
            this.chart2.Series.Add(series17);
            this.chart2.Series.Add(series18);
            this.chart2.Size = new System.Drawing.Size(433, 288);
            this.chart2.TabIndex = 30;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // btnLoadWandT
            // 
            this.btnLoadWandT.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoadWandT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWandT.Location = new System.Drawing.Point(561, 261);
            this.btnLoadWandT.Name = "btnLoadWandT";
            this.btnLoadWandT.Size = new System.Drawing.Size(132, 94);
            this.btnLoadWandT.TabIndex = 31;
            this.btnLoadWandT.Text = "Cargar Pesos y umbrales";
            this.btnLoadWandT.UseVisualStyleBackColor = true;
            this.btnLoadWandT.Click += new System.EventHandler(this.btnLoadWandT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(905, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Iteración Actual";
            // 
            // txtCurrentIteration
            // 
            this.txtCurrentIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentIteration.Location = new System.Drawing.Point(932, 136);
            this.txtCurrentIteration.Name = "txtCurrentIteration";
            this.txtCurrentIteration.Size = new System.Drawing.Size(101, 30);
            this.txtCurrentIteration.TabIndex = 33;
            // 
            // txtCurrentERMS
            // 
            this.txtCurrentERMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentERMS.Location = new System.Drawing.Point(1084, 136);
            this.txtCurrentERMS.Name = "txtCurrentERMS";
            this.txtCurrentERMS.Size = new System.Drawing.Size(122, 30);
            this.txtCurrentERMS.TabIndex = 35;
            this.txtCurrentERMS.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1079, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "ERMS Actual";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(985, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Grafica YR vs YD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 976);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCurrentERMS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurrentIteration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoadWandT);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.dgERMS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoIterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtERMSAllowed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgThreshold);
            this.Controls.Add(this.dgWeights);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLearningRat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatterns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadNetwork);
            this.Controls.Add(this.txtInputs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Red Perceptron Unicapa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgERMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.Button btnLoadNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLearningRat;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarEntrenamientoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgWeights;
        private System.Windows.Forms.DataGridView dgThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtERMSAllowed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoIterations;
        private System.Windows.Forms.DataGridView dgERMS;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnLoadWandT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurrentIteration;
        private System.Windows.Forms.TextBox txtCurrentERMS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

