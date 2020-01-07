using System;
using QuadraticSolverNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace QuadraticSolverTestNS
{
    [TestClass]
    public class QuadraticSolverTests
    {
        [TestMethod]
        public void Quadratic_0_0_0_has_solution_0()
        {
            QuadraticSolver solver = new QuadraticSolver(0, 0, 0);
            List<double> answer = solver.SolveQuadratic();
            Assert.AreEqual(2, answer.Count, "Number of solutions for the quadratic 0, 0, 0 is not equal to 2");
            Assert.AreEqual(0, answer[0], "The solution to the quadratic 0, 0, 0 is not equal to 0");
        }
    }
}
