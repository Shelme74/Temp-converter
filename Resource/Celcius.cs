/**
 * Copyright(C) 2021  Shelme74
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or(at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.If not, see<https://www.gnu.org/licenses/>.
 * 
 */

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
