using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
using System.Threading;

namespace RedPerceptron
{
    public partial class Form1 : Form
    {
        NetworkService networkService = new NetworkService();
        double[,] weights;
        double[] threshold;
        List<double> ERMSList;
        double[] iterations;
        Network network;
        double[,,] _yd;
        double[,,] _yr;
        TrainParams trainParams;
        public Form1()
        {
            InitializeComponent();
            dgERMS.ColumnCount = 2;
            dgERMS.Columns[0].Name = "Iteracion";
            dgERMS.Columns[1].Name = "ERMS";
            dgERMS.Columns[0].Width = 50;
            dgERMS.Columns[1].Width = 80;
            chart2.Series["YR"].BorderWidth = 6;
            chart2.Series["YD"].BorderWidth = 3;

            txtInputs.Enabled = false;
            txtOutputs.Enabled = false;
            txtPatterns.Enabled = false;
            txtCurrentERMS.Enabled = false;
            txtCurrentIteration.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (network != null)
            {
                if (FieldsVerified())
                {
                    network.TrainParams = trainParams;
                    ERMSList = new List<double>();
                    Thread thread = new Thread(new ThreadStart(this.DoTraining));
                    thread.IsBackground = true;
                    thread.Start();
                    
                }
                else
                {
                    MessageBox.Show("Rellene los campos requeridos");
                }
            }
            else {
                MessageBox.Show("Cargue los datos de entrenamiento");
            }
        }
        private void FillDataGridERMS(List<double> ERMS) {
            dgERMS.Rows.Clear();
            int iteration = 0;
            foreach (var item in ERMS)
            {
                dgERMS.Rows.Add();
                dgERMS.Rows[iteration].Cells[0].Value = iteration + 1;
                dgERMS.Rows[iteration].Cells[1].Value = item;
                iteration++;
            }
        }
        private void DoTraining() {
            double learningRat = 0;
            double ERMSAllowed = double.Parse(txtERMSAllowed.Text);
            try
            {
                learningRat = double.Parse(txtLearningRat.Text);
            }
            catch (Exception)
            {
            }
            TrainNetwork(network, learningRat, int.Parse(txtNoIterations.Text), double.Parse(txtERMSAllowed.Text));
            FillDataGridWeights(network.TrainParams.Weights);
            FillDataGridThreshold(network.TrainParams.Threshold);
        }
        private bool FieldsVerified() {
            if (txtLearningRat.Text != "" && txtNoIterations.Text != "" && txtERMSAllowed.Text != "") {
                return true;
            }
            return false;
        }
        private void FillDataGridThreshold(double[] threshold) {
            dgThreshold.Rows.Clear();
            dgThreshold.ColumnCount = 1;
            dgThreshold.Columns[0].Width = 50;
            for (int i = 0; i < threshold.Length; i++)
            {
                dgThreshold.Rows.Add();
                dgThreshold.Rows[i].Cells[0].Value = threshold[i];
            }

        }
        private void InitializeWeights(int noInputs, int noOutputs) {
            weights = new double[noOutputs, noInputs];
            for (int i = 0; i < noOutputs; i++)
            {
                for (int j = 0; j < noInputs; j++)
                {
                    weights[i, j] = 0;
                }
            }

        }
        private void FillDataGridWeights(double[,] weights) {
            dgWeights.Rows.Clear();
            dgWeights.ColumnCount = weights.GetLength(1);
            for (int i = 0; i < weights.GetLength(1); i++)
            {
                dgWeights.Columns[i].Width = 50;
            }
            for (int i = 0; i < weights.GetLength(0); i++)
            {
                dgWeights.Rows.Add();
                for (int j = 0; j < weights.GetLength(1); j++)
                {
                    dgWeights.Rows[i].Cells[j].Value = weights[i, j];
                }

            }
        }

        private void btnLoadNetwork_Click(object sender, EventArgs e)
        {
            LoadTrainData();
        }
        private void LoadTrainData() {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    network = networkService.ReadDataTrain(openFile.FileName);

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el archivo");
                }
            }
            if (network != null)
            {
                txtInputs.Text = network.NoInputs.ToString();
                txtOutputs.Text = network.NoOutputs.ToString();
                txtPatterns.Text = network.NoPatterns.ToString();
                InitializeWeights(network.NoInputs, network.NoOutputs);
                FillDataGridWeights(weights);
                threshold = new double[network.NoOutputs];
                threshold[0] = 0.3;
                trainParams = new TrainParams();
                trainParams.Weights = weights;
                trainParams.Threshold = threshold;
                FillDataGridThreshold(trainParams.Threshold);
            }
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTrainData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgWeights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //32224724
            //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateChart(double[] erms, double[] it) {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < erms.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(it[i], erms[i]);
            }
        }
        public void TrainNetwork(Network network, double learningRat, int noIterations, double ERMSAllowed)
        {
            double erms = 9999;
            int currentIteration = 0;
            _yr = new double[1, 2, 3];
            iterations = new double[noIterations];
            CheckForIllegalCrossThreadCalls = false;
            // network.Weights = new float[network.NoInputs, network.NoOutputs];
            while (currentIteration < noIterations && erms > ERMSAllowed)
            {
                txtCurrentIteration.Text =""+(currentIteration+1);
                ResetCharYDvsYR();
                Console.WriteLine("-------ITERACION: " + (currentIteration + 1) + "-----------");
                txtLog.Text = txtLog.Text + "-------ITERACION: " + (currentIteration + 1) + "-----------" + "\r\n";
                int indexCurrentPattern = 0;
                
                var yr = new double[network.NoOutputs];
                var el = new double[network.NoOutputs];
                var ep = new double[network.NoPatterns];
                while (indexCurrentPattern < network.NoPatterns)
                {
                    txtLog.Text = txtLog.Text + "Current Pattern: " + (indexCurrentPattern+1) + "\r\n";
                    var s = new double[network.NoOutputs];
                    for (int i = 0; i < network.NoOutputs; i++)
                    {
                        for (int j = 0; j < network.NoInputs; j++)
                        {
                            var xj = network.InputsPatterns[indexCurrentPattern, j];
                            var wji = network.TrainParams.Weights[i, j];
                            s[i] = s[i] + (xj * wji);
                        }
                        s[i] = s[i] - network.TrainParams.Threshold[i];
                        Console.WriteLine(i + " Si: " + s[i]);
                        txtLog.Text = txtLog.Text + $" S{(i + 1)}: " + s[i] + "\r\n";
                        yr[i] = calculateEscalon(s[i]);
                        //_yr[currentIteration,indexCurrentPattern,i]=yr[i];
                        DrawCharYDvsYR(yr[i], network.OutputsPatterns[indexCurrentPattern, i], currentIteration, indexCurrentPattern,i);
                        txtLog.Text = txtLog.Text + $" YR{(i + 1)}: " + yr[i] + " yd1: " + network.OutputsPatterns[indexCurrentPattern, i] + "\r\n";
                        Console.WriteLine(i + " YRi: " + yr[i] + " yd1: " + network.OutputsPatterns[indexCurrentPattern, i]);
                        el[i] = network.OutputsPatterns[indexCurrentPattern, i] - yr[i];
                        txtLog.Text = txtLog.Text + $" EL{(i + 1)}: " + el[i] + "\r\n";
                        Console.WriteLine(i + " ELi: " + el[i]);
                    }
                    ep[indexCurrentPattern] = calculatePatternError(network.NoOutputs, el);
                    txtLog.Text = txtLog.Text + $" EP{indexCurrentPattern + 1}: " + ep[indexCurrentPattern] + "\r\n";
                    calculateNewParams(network, el, indexCurrentPattern, learningRat);
                    indexCurrentPattern++;

                    Console.WriteLine("Current Pattern: " + indexCurrentPattern);
                }
                erms = CalculateERMS(network.NoPatterns, ep);
                string messageERMS = "ERMS: " + erms;
                txtLog.Text = txtLog.Text + messageERMS + "\r\n";
                ERMSList.Add(erms);
                txtCurrentERMS.Text = "" + erms;
                iterations[currentIteration] = currentIteration;
                if (chart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart(ERMSList.ToArray(), iterations); });
                }
                FillDataGridERMS(ERMSList);
                Console.WriteLine(messageERMS);
                currentIteration++;
            }

        }
        private double CalculateERMS(int noPatterns, double[] ep)
        {
            double rms = 0;
            for (int i = 0; i < noPatterns; i++)
            {
                rms = rms + ep[i];
                Console.WriteLine("epi: " + ep[i]);
            }
            rms = rms / noPatterns;
            return rms;
        }
        private List<string> CreateParamsList(Network network) {
            string delimiter = "/";
            List<string> data = new List<string>();
            string a = "";
            for (int i = 0; i < network.NoOutputs; i++)
            {
                for (int j = 0; j < network.NoInputs; j++)
                {
                    if (j == network.NoInputs - 1)
                    {
                        a = a + network.TrainParams.Weights[i, j] + ";";
                    }
                    else
                    {
                        a = a + network.TrainParams.Weights[i, j] + delimiter;
                    }
                }
                a = a + network.TrainParams.Threshold[i];
                data.Add(a);
            }
            return data;
        }
        private void SaveCurrentParams() {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                networkService.SaveNetworkTrainParams(saveFileDialog.FileName + ".txt", CreateParamsList(network));
            }
        }
        private void calculateNewParams(Network network, double[] el, int indexCurrentParttern, double learningRat)
        {
            for (int i = 0; i < network.NoOutputs; i++)
            {
                for (int j = 0; j < network.NoInputs; j++)
                {
                    var newWeight = network.TrainParams.Weights[i, j] + (learningRat * el[i] * network.InputsPatterns[indexCurrentParttern, j]);
                    network.TrainParams.Weights[i, j] = newWeight;
                    txtLog.Text = txtLog.Text + $" W({i + 1},{j + 1}): " + network.TrainParams.Weights[i, j] + "\r\n";
                    Console.WriteLine(i + " weightA: " + network.TrainParams.Weights[i, j]);
                }
                network.TrainParams.Threshold[i] = network.TrainParams.Threshold[i] + (learningRat * el[i] * 1);
                txtLog.Text = txtLog.Text + $" U({i + 1}): " + network.TrainParams.Threshold[i] + "\r\n";
                Console.WriteLine(i + " U: " + network.TrainParams.Threshold[i]);
            }
        }
        private int calculateEscalon(double value)
        {
            return value >= 0 ? 1 : -1;
        }
        private double calculatePatternError(int noOutputs, double[] el)
        {
            double result = 0;
            for (int i = 0; i < noOutputs; i++)
            {
                result = result + Math.Abs(el[i]);
            }
            return result / noOutputs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (network != null) {
                TrainData trainData = new TrainData(network);
                trainData.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (network != null) {
                if (double.Parse(txtCurrentERMS.Text) <= double.Parse(txtERMSAllowed.Text))
                {
                    SaveCurrentParams();

                }
                else {
                    MessageBox.Show("No son optimos");
                }
            }
        }
        private void Restart() {
            network = null;
            dgERMS.Rows.Clear();
            dgThreshold.Rows.Clear();
            dgWeights.Rows.Clear();
            chart1.Series["Series1"].Points.Clear();
            txtLog.Text = "";
            txtInputs.Text = "";
            txtOutputs.Text = "";
            txtPatterns.Text = "";
            ResetCharYDvsYR();
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simulacion simulacion = new Simulacion();
            simulacion.Show();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void ResetCharYDvsYR() {
            chart2.Series["YR"].Points.Clear();
            chart2.Series["YD"].Points.Clear();
        }
        private void DrawCharYDvsYR(double yr,double yd, int currentIteration, int currentPattern,int currentOutput) {
            
            if (currentIteration==0 && currentPattern==0 && currentOutput==0)chart2.Series["YR"].Points.Clear();
            
            chart2.Series["YR"].Points.AddXY(currentOutput,yr );
            chart2.Series["YD"].Points.AddXY(currentOutput, yd);
        }

        private void chart2_Click(object sender, EventArgs e)
        {
        }
        private void LoadTrainParams() {
            TrainParams AuxParams;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AuxParams = networkService.ReadNetworkTrainParams(openFileDialog.FileName);
                if (AuxParams.Weights.GetLength(0) == network.NoOutputs && AuxParams.Weights.GetLength(1) == network.NoInputs)
                {
                    trainParams = AuxParams;
                }
                else
                {
                    MessageBox.Show("incoherencia entre los datos de entrenamiento y los pesos o umbrales");
                }
            }
            FillDataGridWeights(trainParams.Weights);
            FillDataGridThreshold(trainParams.Threshold);
        }

        private void btnLoadWandT_Click(object sender, EventArgs e)
        {
            if (network != null)
            {
                LoadTrainParams();
            }
            else {
                MessageBox.Show("Cargue los datos de entrenamiento");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
