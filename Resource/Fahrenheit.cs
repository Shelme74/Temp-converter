/**
 * Copyright(C) 2022  Shelme74
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
