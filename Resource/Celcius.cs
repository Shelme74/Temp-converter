namespace Resource
{
    public static class Celcius
    {
        public static double CelToFah(double Cel)
        {
            double Fah;
            Fah = (Cel * 1.8) + 32;
            return Fah;
        }
        public static double CelToKel(double Cel)
        {
            double Kel;
            Kel = Cel + 273.15;
            return Kel;
        }
    }
}
