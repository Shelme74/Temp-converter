namespace Resource
{
    public static class Kelvin
    {
        public static double KelToCel(double Kel)
        {
            double Cel;
            Cel = Kel - 273.15;
            return Cel;
        }
        public static double KelToFah(double Kel)
        {
            double Fah;
            Fah = (Kel * 1.8) - 459.67;
            return Fah;
        }
    }
}
