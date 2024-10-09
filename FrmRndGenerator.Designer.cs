namespace WFA24100902
{
    partial class FrmRndGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUI01 = new Label();
            lblUI02 = new Label();
            lblUI03 = new Label();
            nudMin = new NumericUpDown();
            nudMax = new NumericUpDown();
            btnGeneralas = new Button();
            rtbSzamok = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(477, 51);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Milyen intervallumból generáljam a számokat?";
            lblUI01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUI02
            // 
            lblUI02.Dock = DockStyle.Top;
            lblUI02.Location = new Point(98, 0);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(184, 35);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "legkisebb szám:";
            lblUI02.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUI03
            // 
            lblUI03.Dock = DockStyle.Top;
            lblUI03.Location = new Point(98, 52);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(184, 35);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "legnagyobb szám:";
            lblUI03.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudMin
            // 
            nudMin.Dock = DockStyle.Fill;
            nudMin.Location = new Point(288, 3);
            nudMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMin.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(89, 32);
            nudMin.TabIndex = 1;
            nudMin.TextAlign = HorizontalAlignment.Right;
            nudMin.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // nudMax
            // 
            nudMax.AutoSize = true;
            nudMax.Dock = DockStyle.Fill;
            nudMax.Location = new Point(288, 55);
            nudMax.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMax.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudMax.Name = "nudMax";
            nudMax.Size = new Size(89, 32);
            nudMax.TabIndex = 1;
            nudMax.TextAlign = HorizontalAlignment.Right;
            nudMax.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // btnGeneralas
            // 
            btnGeneralas.Location = new Point(110, 180);
            btnGeneralas.Name = "btnGeneralas";
            btnGeneralas.Size = new Size(279, 48);
            btnGeneralas.TabIndex = 2;
            btnGeneralas.Text = "Számok generálása";
            btnGeneralas.UseVisualStyleBackColor = true;
            // 
            // rtbSzamok
            // 
            rtbSzamok.Font = new Font("Consolas", 14F);
            rtbSzamok.Location = new Point(12, 234);
            rtbSzamok.Name = "rtbSzamok";
            rtbSzamok.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbSzamok.Size = new Size(477, 211);
            rtbSzamok.TabIndex = 3;
            rtbSzamok.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblUI02, 1, 0);
            tableLayoutPanel1.Controls.Add(lblUI03, 1, 1);
            tableLayoutPanel1.Controls.Add(nudMin, 2, 0);
            tableLayoutPanel1.Controls.Add(nudMax, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(477, 105);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // FrmRndGenerator
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 457);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(rtbSzamok);
            Controls.Add(btnGeneralas);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmRndGenerator";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUI01;
        private Label lblUI02;
        private Label lblUI03;
        private NumericUpDown nudMin;
        private NumericUpDown nudMax;
        private Button btnGeneralas;
        private RichTextBox rtbSzamok;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
