﻿using System;

namespace ENTITY
{
    public class Network
    {
        public TrainParams TrainParams { get; set; }
        public int NoInputs { get; set; }
        public int NoOutputs { get; set; }
        public double[,] OutputsPatterns { get; set; }
        public double[,] InputsPatterns { get; set; }
        public int NoPatterns { get; set; }
    }
}
