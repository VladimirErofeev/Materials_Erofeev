namespace Materials_Lizyakin
{
    partial class FormHistoryMaterials
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
            DGVHistorySupplies = new DataGridView();
            panel1 = new Panel();
            labelSupplier = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVHistorySupplies).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGVHistorySupplies
            // 
            DGVHistorySupplies.BackgroundColor = Color.White;
            DGVHistorySupplies.BorderStyle = BorderStyle.None;
            DGVHistorySupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHistorySupplies.Dock = DockStyle.Fill;
            DGVHistorySupplies.Location = new Point(10, 10);
            DGVHistorySupplies.Name = "DGVHistorySupplies";
            DGVHistorySupplies.Size = new Size(780, 372);
            DGVHistorySupplies.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelSupplier);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 1;
            // 
            // labelSupplier
            // 
            labelSupplier.BackColor = Color.White;
            labelSupplier.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSupplier.Location = new Point(12, 9);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(776, 46);
            labelSupplier.TabIndex = 0;
            labelSupplier.Text = "label1";
            labelSupplier.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(DGVHistorySupplies);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(800, 392);
            panel2.TabIndex = 2;
            // 
            // FormHistoryMaterials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormHistoryMaterials";
            Text = "История Поставок";
            ((System.ComponentModel.ISupportInitialize)DGVHistorySupplies).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVHistorySupplies;
        private Panel panel1;
        private Panel panel2;
        private Label labelSupplier;
    }
}