using AreaSolver.Figures;
using AreaSolver;
using System.Net.WebSockets;

namespace AreaSolverShould
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaShould()
        {
            var sShouldBe = 2 * 2 * Math.PI;
            Circle circle = new Circle(2);
            var s1 = AreaSolver.AreaSolver.CircleArea(circle);
            var s2 = AreaSolver.AreaSolver.CircleArea(2);
            var s3 = AreaSolver.AreaSolver.CalculateArea(circle);
            Assert.IsTrue(s1.Equals(sShouldBe));
            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s1.Equals(s3));
            Assert.IsTrue(s2.Equals(s3));
        }

        [Test]
        public void UnexistingCircleShould()
        {
            Assert.Throws<Exception>(() => new Circle(-2));
        }
    }
}