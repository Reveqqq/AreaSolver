using AreaSolver.Figures;

namespace AreaSolver
{
    public static class AreaSolver
    {
        public static double TriangleArea(Triangle triangle) => triangle.Area();

        public static double TriangleArea(double a, double b, double c) => new Triangle(a, b, c).Area();
        public static double CircleArea(Circle circle) => circle.Area();
        public static double CircleArea(double r) => new Circle(r).Area();
        public static double CalculateArea(Figure figure) => figure.Area();
        public static bool IsRightAngled(Triangle triangle) => triangle.IsRightAngledTriangle();
    }
}
