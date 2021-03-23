using System;
using ENTITY;
using DAL;
using System.Collections.Generic;
namespace BLL
{
    public class NetworkService
    {
        NetworkRepository networkRepository = new NetworkRepository();
        public List<String> TrainNetwork(Network network, double learningRat, int iterations, double ERMSAllowed) {
            double erms = 9999;
            int currentIteration=0;
            string log="";
            List<String> res = new List<string>();
            // network.Weights = new float[network.NoInputs, network.NoOutputs];
            while (currentIteration < iterations && erms>ERMSAllowed)
            {
                Console.WriteLine("-------ITERACION: " + currentIteration + "-----------");
                log = log + "-------ITERACION: " + currentIteration + "-----------";
                int indexCurrentPattern = 0;
                
                var yr = new double[network.NoOutputs];
                var el = new double[network.NoOutputs];
                var ep = new double[network.NoPatterns];
                while (indexCurrentPattern < network.NoPatterns)
                {
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
                        log =log + i + " Si: " + s[i];
                        yr[i] = calculateEscalon(s[i]);
                        log = log + i + " YRi: " + yr[i] + " yd1: " + network.OutputsPatterns[indexCurrentPattern, i];
                        Console.WriteLine(i + " YRi: " + yr[i] + " yd1: " + network.OutputsPatterns[indexCurrentPattern, i]);
                        el[i] = network.OutputsPatterns[indexCurrentPattern, i] - yr[i];
                        log = log + i + " eli: " + el[i];
                        Console.WriteLine(i + " eli: " + el[i]);
                    }
                    ep[indexCurrentPattern] = calculatePatternError(network.NoOutputs, el);
                    calculateNewParams(network, el, indexCurrentPattern, learningRat);
                    indexCurrentPattern++;
                    log = log + "Current Pattern: " + indexCurrentPattern;
                    Console.WriteLine("Current Pattern: "+indexCurrentPattern);
                }
                erms = CalculateERMS(network.NoPatterns, ep);
                log = log + erms;
                string messageERMS = "ERMS: " + erms;
                res.Add(messageERMS);
                Console.WriteLine(messageERMS);

                currentIteration++;
            }
            res.Add(log);
            return res;

        }
        private double CalculateERMS(int noPatterns,double[] ep) {
            double rms = 0;
            for (int i = 0; i < noPatterns; i++)
            {
                rms = rms + ep[i];
                Console.WriteLine("epi: " + ep[i]);
            }
            rms = rms / noPatterns;
            return rms;
        }
        private void calculateNewParams(Network network,double[] el,int indexCurrentParttern, double learningRat) {
            for (int i = 0; i < network.NoOutputs; i++)
            {
                for (int j = 0; j < network.NoInputs; j++)
                {
                    var newWeight = network.TrainParams.Weights[i, j]+(learningRat*el[i]*network.InputsPatterns[indexCurrentParttern,j]);
                    network.TrainParams.Weights[i, j] = newWeight;
                    Console.WriteLine(i + " weightA: " + network.TrainParams.Weights[i, j]);
                }
                network.TrainParams.Threshold[i] = network.TrainParams.Threshold[i] + (learningRat * el[i] * 1);
                Console.WriteLine(i + " U: " + network.TrainParams.Threshold[i]);
            }
        }
        private int calculateEscalon(double value) {
            return value >= 0 ? 1 : -1;
        }
        private double calculatePatternError(int noOutputs,double[] el)
        {
            double result = 0;
            for (int i = 0; i < noOutputs; i++)
            {   
                result = result + Math.Abs(el[i]);
            }
            return result/noOutputs;
        }
        public Network ReadDataTrain(string path) {
            return networkRepository.ReadDataTrain(path);
        }
        public void SaveNetworkTrainParams(string path, List<string> values) {
            networkRepository.SaveNetworkTrainParams(path, values);
        }
        public TrainParams ReadNetworkTrainParams(string path) {
           return networkRepository.ReadNetworkTrainParams(path);
        }
        public double[] simulateNetwork(TrainParams trainParams,double [] x) {
                int noOutputs = trainParams.Weights.GetLength(0);
                int noInputs = trainParams.Weights.GetLength(1);
                double[] yr = new double[noOutputs];
                var s = new double[noOutputs];
                for (int i = 0; i <noOutputs; i++)
                {
                    for (int j = 0; j < noInputs; j++)
                    {
                        var xj = x[j];
                        var wji = trainParams.Weights[i, j];
                        s[i] = s[i] + (xj * wji);
                        Console.WriteLine("xi: " + xj);
                        Console.WriteLine("wji: " + wji);
                }
                    Console.WriteLine("si: " + s[i]);
                    s[i] = s[i] - trainParams.Threshold[i];
                    Console.WriteLine(i + " Si: " + s[i]);
                    yr[i] = calculateEscalon(s[i]);
                }
            return yr;
        }
        public double[,] ReadSimulationPatterns(string path) {
            return networkRepository.ReadSimulationPatterns(path);
        }
    }
}
