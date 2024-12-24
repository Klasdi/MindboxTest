
namespace MindboxTest
{
    public class Circle : Сalculation
    {
        private readonly double _radius;
        public Circle(double radius) {
            if (radius < 0)
                throw new Exception("Радиус не может быть отрицательным");
            _radius = radius;
        }
        public double Square() {
            return double.Pi * _radius * _radius;
        }
    }
}
