﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    #region Fransfer functions and their derivatives

    public enum TransferFunction
    {
        None,
        Sigmoid
    }

    static class TransferFunctions
    {
        public static double Evaluate(TransferFunction tFunc, double input)
        {
            switch (tFunc)
            {
                case TransferFunction.Sigmoid:
                    return sigmoid(input);

                case TransferFunction.None:
                default:
                    return 0.0;
            }
        }

        public static double EvaluateDerivative(TransferFunction tFunc, double input)
        {
            switch (tFunc)
            {
                case TransferFunction.Sigmoid:
                    return sigmoidDerivative(input);

                case TransferFunction.None:
                default:
                    return 0.0;
            }
        }

        //Transfer function definitions

        private static double sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        private static double sigmoidDerivative(double x)
        {
            return sigmoid(x) * (1 - sigmoid(x));
        }
    }

    #endregion

    public class BackPropagationNetwork
    {
        #region Constructors

        public BackPropagationNetwork(int[] layerSizes, TransferFunction[] tFuncs)
        {
            // Validate the input data
            if (tFuncs.Length != layerSizes.Length || tFuncs[0] != TransferFunction.None)
                throw new ArgumentException("Cannot construct a network with these parameters.");

            // Initialize network layers
            layerCount
        }

        #endregion

        #region Private data

        private int layerCount;
        private int inputSize;
        private int[] layerSize;
        private TransferFunction[] transferFunction;

        private double[][] layerOutput;
        private double[][] layerInput;
        private double[][] bias;
        private double[][] delta;
        private double[][] previousBiasDelta;

        private double[][][] weight;
        private double[][][] previousWeightDelta;

        #endregion
    }
}