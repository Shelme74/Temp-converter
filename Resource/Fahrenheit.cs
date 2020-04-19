namespace Resource
{
    public static class Fahrenheit
    {
        public static double FahToCel(double Fah)
        {
            double Cel;
            Cel = (Fah - 32) / 1.8;
            return Cel;
        }
        public static double FahToKel(double Fah)
        {
            double Kel;
            Kel = (Fah + 459.67) / 1.8;
            return Kel;
        }
    }
}
