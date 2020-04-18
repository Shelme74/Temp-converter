// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

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
