
namespace CapaGUI
{
    partial class VistaReportes
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
            this.TAB = new MetroFramework.Controls.MetroTabControl();
            this.TabVentaExterna = new MetroFramework.Controls.MetroTabPage();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TabVentaInterna = new MetroFramework.Controls.MetroTabPage();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime4 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.TAB.SuspendLayout();
            this.TabVentaExterna.SuspendLayout();
            this.TabVentaInterna.SuspendLayout();
            this.SuspendLayout();
            // 
            // TAB
            // 
            this.TAB.Controls.Add(this.TabVentaExterna);
            this.TAB.Controls.Add(this.TabVentaInterna);
            this.TAB.Location = new System.Drawing.Point(23, 89);
            this.TAB.Name = "TAB";
            this.TAB.SelectedIndex = 1;
            this.TAB.Size = new System.Drawing.Size(847, 425);
            this.TAB.TabIndex = 1;
            this.TAB.UseSelectable = true;
            // 
            // TabVentaExterna
            // 
            this.TabVentaExterna.Controls.Add(this.metroListView1);
            this.TabVentaExterna.Controls.Add(this.metroDateTime2);
            this.TabVentaExterna.Controls.Add(this.metroDateTime1);
            this.TabVentaExterna.Controls.Add(this.metroLabel2);
            this.TabVentaExterna.Controls.Add(this.metroLabel1);
            this.TabVentaExterna.HorizontalScrollbarBarColor = true;
            this.TabVentaExterna.HorizontalScrollbarHighlightOnWheel = false;
            this.TabVentaExterna.HorizontalScrollbarSize = 10;
            this.TabVentaExterna.Location = new System.Drawing.Point(4, 38);
            this.TabVentaExterna.Name = "TabVentaExterna";
            this.TabVentaExterna.Size = new System.Drawing.Size(839, 383);
            this.TabVentaExterna.TabIndex = 0;
            this.TabVentaExterna.Text = "Reporte Venta Externa";
            this.TabVentaExterna.VerticalScrollbarBarColor = true;
            this.TabVentaExterna.VerticalScrollbarHighlightOnWheel = false;
            this.TabVentaExterna.VerticalScrollbarSize = 10;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(101, 80);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 5;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(101, 37);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Fecha Termino:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha Inicio:";
            // 
            // TabVentaInterna
            // 
            this.TabVentaInterna.Controls.Add(this.metroListView2);
            this.TabVentaInterna.Controls.Add(this.metroDateTime3);
            this.TabVentaInterna.Controls.Add(this.metroDateTime4);
            this.TabVentaInterna.Controls.Add(this.metroLabel3);
            this.TabVentaInterna.Controls.Add(this.metroLabel4);
            this.TabVentaInterna.HorizontalScrollbarBarColor = true;
            this.TabVentaInterna.HorizontalScrollbarHighlightOnWheel = false;
            this.TabVentaInterna.HorizontalScrollbarSize = 10;
            this.TabVentaInterna.Location = new System.Drawing.Point(4, 38);
            this.TabVentaInterna.Name = "TabVentaInterna";
            this.TabVentaInterna.Size = new System.Drawing.Size(839, 383);
            this.TabVentaInterna.TabIndex = 1;
            this.TabVentaInterna.Text = "Reporte Venta Interna";
            this.TabVentaInterna.VerticalScrollbarBarColor = true;
            this.TabVentaInterna.VerticalScrollbarHighlightOnWheel = false;
            this.TabVentaInterna.VerticalScrollbarSize = 10;
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime3.Location = new System.Drawing.Point(101, 77);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime3.TabIndex = 9;
            // 
            // metroDateTime4
            // 
            this.metroDateTime4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime4.Location = new System.Drawing.Point(101, 34);
            this.metroDateTime4.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime4.Name = "metroDateTime4";
            this.metroDateTime4.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime4.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Fecha Termino:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Fecha Inicio:";
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(3, 238);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(833, 142);
            this.metroListView1.TabIndex = 6;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // metroListView2
            // 
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(3, 228);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(833, 142);
            this.metroListView2.TabIndex = 10;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            // 
            // VistaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 550);
            this.Controls.Add(this.TAB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaReportes";
            this.Text = "VistaReportes";
            this.TAB.ResumeLayout(false);
            this.TabVentaExterna.ResumeLayout(false);
            this.TabVentaExterna.PerformLayout();
            this.TabVentaInterna.ResumeLayout(false);
            this.TabVentaInterna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TAB;
        private MetroFramework.Controls.MetroTabPage TabVentaExterna;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage TabVentaInterna;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroDateTime metroDateTime4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroListView metroListView2;
    }
}