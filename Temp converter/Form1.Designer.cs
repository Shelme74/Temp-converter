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

using System.Windows.Forms;

namespace Program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kelTab = new System.Windows.Forms.TabPage();
            this.KelToFah = new System.Windows.Forms.Label();
            this.KelToCel = new System.Windows.Forms.Label();
            this.KelInput = new System.Windows.Forms.NumericUpDown();
            this.fahTab = new System.Windows.Forms.TabPage();
            this.FahToKel = new System.Windows.Forms.Label();
            this.FahToCel = new System.Windows.Forms.Label();
            this.FahInput = new System.Windows.Forms.NumericUpDown();
            this.celTab = new System.Windows.Forms.TabPage();
            this.CelToKel = new System.Windows.Forms.Label();
            this.CeltoFah = new System.Windows.Forms.Label();
            this.CelInput = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.kelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KelInput)).BeginInit();
            this.fahTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahInput)).BeginInit();
            this.celTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CelInput)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kelTab
            // 
            this.kelTab.Controls.Add(this.KelToFah);
            this.kelTab.Controls.Add(this.KelToCel);
            this.kelTab.Controls.Add(this.KelInput);
            this.kelTab.Location = new System.Drawing.Point(4, 22);
            this.kelTab.Name = "kelTab";
            this.kelTab.Padding = new System.Windows.Forms.Padding(3);
            this.kelTab.Size = new System.Drawing.Size(272, 231);
            this.kelTab.TabIndex = 2;
            this.kelTab.Text = "Kelvin";
            this.kelTab.UseVisualStyleBackColor = true;
            // 
            // KelToFah
            // 
            this.KelToFah.AutoSize = true;
            this.KelToFah.Location = new System.Drawing.Point(6, 43);
            this.KelToFah.Name = "KelToFah";
            this.KelToFah.Size = new System.Drawing.Size(52, 13);
            this.KelToFah.TabIndex = 3;
            this.KelToFah.Text = "-479.67 F";
            // 
            // KelToCel
            // 
            this.KelToCel.AutoSize = true;
            this.KelToCel.Location = new System.Drawing.Point(6, 30);
            this.KelToCel.Name = "KelToCel";
            this.KelToCel.Size = new System.Drawing.Size(57, 13);
            this.KelToCel.TabIndex = 2;
            this.KelToCel.Text = "-273.15 °C";
            // 
            // KelInput
            // 
            this.KelInput.Location = new System.Drawing.Point(7, 7);
            this.KelInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.KelInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.KelInput.Name = "KelInput";
            this.KelInput.Size = new System.Drawing.Size(100, 20);
            this.KelInput.TabIndex = 1;
            this.KelInput.ValueChanged += new System.EventHandler(this.KelInput_ValueChanged);
            // 
            // fahTab
            // 
            this.fahTab.Controls.Add(this.FahToKel);
            this.fahTab.Controls.Add(this.FahToCel);
            this.fahTab.Controls.Add(this.FahInput);
            this.fahTab.Location = new System.Drawing.Point(4, 22);
            this.fahTab.Name = "fahTab";
            this.fahTab.Padding = new System.Windows.Forms.Padding(3);
            this.fahTab.Size = new System.Drawing.Size(272, 231);
            this.fahTab.TabIndex = 1;
            this.fahTab.Text = "Fahrenheit";
            this.fahTab.UseVisualStyleBackColor = true;
            // 
            // FahToKel
            // 
            this.FahToKel.AutoSize = true;
            this.FahToKel.Location = new System.Drawing.Point(6, 43);
            this.FahToKel.Name = "FahToKel";
            this.FahToKel.Size = new System.Drawing.Size(56, 13);
            this.FahToKel.TabIndex = 3;
            this.FahToKel.Text = "255.372 K";
            // 
            // FahToCel
            // 
            this.FahToCel.AutoSize = true;
            this.FahToCel.Location = new System.Drawing.Point(6, 30);
            this.FahToCel.Name = "FahToCel";
            this.FahToCel.Size = new System.Drawing.Size(57, 13);
            this.FahToCel.TabIndex = 2;
            this.FahToCel.Text = "-17.778 °C";
            // 
            // FahInput
            // 
            this.FahInput.Location = new System.Drawing.Point(7, 7);
            this.FahInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.FahInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.FahInput.Name = "FahInput";
            this.FahInput.Size = new System.Drawing.Size(100, 20);
            this.FahInput.TabIndex = 1;
            this.FahInput.ValueChanged += new System.EventHandler(this.FahInput_ValueChanged);
            // 
            // celTab
            // 
            this.celTab.Controls.Add(this.CelToKel);
            this.celTab.Controls.Add(this.CeltoFah);
            this.celTab.Controls.Add(this.CelInput);
            this.celTab.Location = new System.Drawing.Point(4, 22);
            this.celTab.Name = "celTab";
            this.celTab.Padding = new System.Windows.Forms.Padding(3);
            this.celTab.Size = new System.Drawing.Size(272, 231);
            this.celTab.TabIndex = 0;
            this.celTab.Text = "Celsius";
            this.celTab.UseVisualStyleBackColor = true;
            // 
            // CelToKel
            // 
            this.CelToKel.AutoSize = true;
            this.CelToKel.Location = new System.Drawing.Point(6, 43);
            this.CelToKel.Name = "CelToKel";
            this.CelToKel.Size = new System.Drawing.Size(50, 13);
            this.CelToKel.TabIndex = 3;
            this.CelToKel.Text = "273.15 K";
            // 
            // CeltoFah
            // 
            this.CeltoFah.AutoSize = true;
            this.CeltoFah.Location = new System.Drawing.Point(6, 30);
            this.CeltoFah.Name = "CeltoFah";
            this.CeltoFah.Size = new System.Drawing.Size(37, 13);
            this.CeltoFah.TabIndex = 2;
            this.CeltoFah.Text = "32.0 F";
            // 
            // CelInput
            // 
            this.CelInput.Location = new System.Drawing.Point(7, 7);
            this.CelInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CelInput.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.CelInput.Name = "CelInput";
            this.CelInput.Size = new System.Drawing.Size(100, 20);
            this.CelInput.TabIndex = 1;
            this.CelInput.TextChanged += new System.EventHandler(this.CelInput_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.celTab);
            this.tabControl1.Controls.Add(this.fahTab);
            this.tabControl1.Controls.Add(this.kelTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Temperature converter";
            this.kelTab.ResumeLayout(false);
            this.kelTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KelInput)).EndInit();
            this.fahTab.ResumeLayout(false);
            this.fahTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahInput)).EndInit();
            this.celTab.ResumeLayout(false);
            this.celTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CelInput)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage kelTab;
        private Label KelToFah;
        private Label KelToCel;
        private NumericUpDown KelInput;
        private TabPage fahTab;
        private Label FahToKel;
        private Label FahToCel;
        private NumericUpDown FahInput;
        private TabPage celTab;
        private Label CelToKel;
        private Label CeltoFah;
        private NumericUpDown CelInput;
        private TabControl tabControl1;
        private Label label1;
    }
}
