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

using System;
using System.Globalization;
using System.Windows.Forms;
using Resource;

namespace Program
{
    /// <summary>
    /// Creates the Form1 class.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void CelInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainWindow mainwd = this;
                decimal cel = mainwd.CelInput.Value;
                double celDbl = decimal.ToDouble(cel);
                double fahDbl = Celcius.CelToFah(celDbl);
                double kelDbl = Celcius.CelToKel(celDbl);
                string fahSt = fahDbl.ToString("F1", CultureInfo.CurrentCulture);
                string kelSt = kelDbl.ToString("F2", CultureInfo.CurrentCulture);
                mainwd.CeltoFah.Text = $"{fahSt} F";
                mainwd.CelToKel.Text = $"{kelSt} K";
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
                MainWindow mainwd = this;
                decimal fah = mainwd.FahInput.Value;
                double fahDbl = decimal.ToDouble(fah);
                double celDbl = Fahrenheit.FahToCel(fahDbl);
                double kelDbl = Fahrenheit.FahToKel(fahDbl);
                string celSt = celDbl.ToString("F3", CultureInfo.CurrentCulture);
                string kelSt = kelDbl.ToString("F3", CultureInfo.CurrentCulture);
                mainwd.FahToCel.Text = $"{celSt} °C";
                mainwd.FahToKel.Text = $"{kelSt} K";
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
                MainWindow mainwd = this;
                decimal kel = this.KelInput.Value;
                double kelDbl = decimal.ToDouble(kel);
                double celDbl = Kelvin.KelToCel(kelDbl);
                double fahDbl = Kelvin.KelToFah(kelDbl);
                string celSt = celDbl.ToString("F2", CultureInfo.CurrentCulture);
                string fahSt = fahDbl.ToString("F2", CultureInfo.CurrentCulture);
                mainwd.KelToCel.Text = $"{celSt} °C";
                mainwd.KelToFah.Text = $"{fahSt} F";
            }
            catch
            {
                throw;
            }
        }
    }
}
