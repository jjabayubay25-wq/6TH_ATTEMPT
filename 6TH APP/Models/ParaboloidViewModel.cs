namespace ParaboloidApp.Models
{
    public class ParaboloidViewModel
    {
        public double A { get; set; } = 2.0;
        public double B { get; set; } = 3.0;
        public double H { get; set; } = 5.0;

        // Formula: V = 1/2 * PI * a * b * h^2
        public double Volume => 0.5 * Math.PI * A * B * Math.Pow(H, 2);
    }
}