using AreaSolver.Figures;

namespace AreaSolverShould
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleAreaShould()
        {
            var sShouldBe = 6;
            Triangle triangle = new Triangle(3, 4, 5);
            var s1 = AreaSolver.AreaSolver.TriangleArea(triangle);
            var s2 = AreaSolver.AreaSolver.TriangleArea(3, 4, 5);
            var s3 = AreaSolver.AreaSolver.CalculateArea(triangle);
            Assert.IsTrue(s1.Equals(sShouldBe));
            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s1.Equals(s3));
            Assert.IsTrue(s2.Equals(s3));
        }

        [Test]
        public void UnexistingTriangleShould()
        {
            Assert.Throws<Exception>(() => new Triangle(24, 5, 5));
            Assert.Throws<Exception>(() => new Triangle(24, -5, 5));
            Assert.Throws<Exception>(() => new Triangle(24, 0, 5));
        }

        [Test]
        public void RightTriangleShould()
        {
            Assert.IsTrue(AreaSolver.AreaSolver.IsRightAngled(new Triangle(3, 4, 5)));

            Assert.IsFalse(AreaSolver.AreaSolver.IsRightAngled(new Triangle(2, 4, 5)));
        }
    }
}