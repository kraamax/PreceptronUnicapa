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

namespace RedPerceptron
{
    public partial class Simulacion : Form
    {
        NetworkService networkService;
        TrainParams trainParams;
        double[,] simulationPatterns;
        public Simulacion()
        {
            InitializeComponent();
            networkService = new NetworkService();
        }

        private void btnLoadNetworkParams_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    trainParams = networkService.ReadNetworkTrainParams(openFileDialog.FileName);
                }
                FillDataGridWeights(trainParams.Weights);
                FillDataGridThreshold(trainParams.Threshold);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void FillDataGridWeights(double[,] weights)
        {
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
        private void FillDataGridThreshold(double[] threshold)
        {
            dgThreshold.ColumnCount = 1;
            dgThreshold.Columns[0].Width = 50;
            for (int i = 0; i < threshold.Length; i++)
            {
                dgThreshold.Rows.Add();
                dgThreshold.Rows[i].Cells[0].Value = threshold[i];
            }

        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (trainParams != null)
            {
                double[] x = new double[trainParams.Weights.GetLength(1)];
                try
                {
                    x[0] = double.Parse(txtX1.Text);
                    x[1] = double.Parse(txtX2.Text);
                }
                catch (Exception)
                {
                    x[0] = 0;
                    x[1] = 0;
                }
                
                double[] res = networkService.simulateNetwork(trainParams, x);
                for (int i = 0; i < res.Length; i++)
                {
                    txtResult.Text = txtResult.Text + res[i];
                }
            }
            else {
                MessageBox.Show("Debe cargar los pesos y umbrales");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
              OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try
                {
                    simulationPatterns = networkService.ReadSimulationPatterns(openFileDialog.FileName);
                    FillDataGridSP(simulationPatterns);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el archivo");
                }
               
            }
        }
        private void FillDataGridSP(double[,] a)
        {
            int totalColumns = a.GetLength(1);
            int totalRows = a.GetLength(0);
            dgSP.ColumnCount = totalColumns;
            for (int i = 0; i < totalColumns; i++)
            {
                dgSP.Columns[i].Name = "X" + (i + 1);
            }
            
            dgSP.Rows.Clear();
            int n = 0;
            for (int i = 0; i < totalRows; i++)
            {
                dgSP.Rows.Add();
                for (int j = 0; j <totalColumns; j++)
                {
                    Console.WriteLine("i: " + i + " j: " + j);
                    dgSP.Rows[i].Cells[j].Value = a[i, j];
                    Console.WriteLine(a[i, j]);
                }
            }
        }
        private double[] GetVector(double[,] array, int row) {
            double[] res=new double[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                    res[i] = array[row, i];
            }
            return res;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (trainParams != null)
            {
                if (simulationPatterns != null)
                {
                    if (simulationPatterns.GetLength(1) == trainParams.Weights.GetLength(1))
                    {
                        FillDataGridOutput();
                    }
                    else {
                        MessageBox.Show("Inconsistencia");
                    }
                }
                else {
                    MessageBox.Show("Cargue el archivo con los patrones para la simulacion");
                }
            }
            else {
                MessageBox.Show("Cargue los pesos y umbrales optimos");
            }
        }
        public void FillDataGridOutput() {
            dgOutputs.Rows.Clear();
            dgOutputs.ColumnCount = trainParams.Threshold.Length;
            for (int i = 0; i < simulationPatterns.GetLength(0); i++)
            {
                dgOutputs.Rows.Add();
                double[] res = networkService.simulateNetwork(trainParams, GetVector(simulationPatterns, i));
                for (int j = 0; j < res.Length; j++)
                {
                    dgOutputs.Rows[i].Cells[j].Value = res[j];
                }
            }
        }
    }
}
