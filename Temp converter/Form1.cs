/**
 * Copyright(C) 2020  Shelme74
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

namespace Program
{
    using System;
    using System.Windows.Forms;
    using Resource;

    /// <summary>
    /// Creates the Form1 class.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        private void CelInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal cel = this.CelInput.Value;
                double celDbl = decimal.ToDouble(cel);
                double fahDbl = Celcius.CelToFah(celDbl);
                double kelDbl = Celcius.CelToKel(celDbl);
                string fahSt = fahDbl.ToString("F1");
                string kelSt = kelDbl.ToString("F2");
                this.CeltoFah.Text = fahSt + " F";
                this.CelToKel.Text = kelSt + " K";
            }
            catch
            {
                throw;
            }
        }

        private void FahInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal fah = this.FahInput.Value;
                double fahDbl = decimal.ToDouble(fah);
                double celDbl = Fahrenheit.FahToCel(fahDbl);
                double kelDbl = Fahrenheit.FahToKel(fahDbl);
                string celSt = celDbl.ToString("F3");
                string kelSt = kelDbl.ToString("F3");
                this.FahToCel.Text = celSt + " °C";
                this.FahToKel.Text = kelSt + " K";
            }
            catch
            {
                throw;
            }
        }

        private void KelInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal kel = this.KelInput.Value;
                double kelDbl = decimal.ToDouble(kel);
                double celDbl = Kelvin.KelToCel(kelDbl);
                double fahDbl = Kelvin.KelToFah(kelDbl);
                string celSt = celDbl.ToString("F2");
                string fahSt = fahDbl.ToString("F2");
                this.KelToCel.Text = celSt + " °C";
                this.KelToFah.Text = fahSt + " F";
            }
            catch
            {
                throw;
            }
        }
    }
}
