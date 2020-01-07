using System;
using System.Collections.Generic;

namespace QuadraticSolverNS
{
    public class QuadraticSolver
    {
        public double a {
            get;
            set;
        }

        public double b
        {
            get;
            set;
        }

        public double c
        {
            get;
            set;
        }

        // Constructor
        public QuadraticSolver(double a, double b, double c) {

        }

        public List<double> SolveQuadratic() {
            return new List<double>() { 0 };
        }

        public void PrintAnswer(List<double> answer) { 
        
        }
    }
}
