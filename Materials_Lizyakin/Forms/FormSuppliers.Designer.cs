namespace Materials_Lizyakin
{
    partial class FormSuppliers
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
            panelButtons = new Panel();
            buttonHistory = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            panelItems = new Panel();
            DGVSuppliers = new DataGridView();
            panelButtons.SuspendLayout();
            panelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSuppliers).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonHistory);
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Controls.Add(buttonEdit);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(800, 77);
            panelButtons.TabIndex = 0;
            // 
            // buttonHistory
            // 
            buttonHistory.Location = new Point(460, 12);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(328, 59);
            buttonHistory.TabIndex = 3;
            buttonHistory.Text = "История поставок";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += ButtonHistory_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(319, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 59);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(178, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 59);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(162, 59);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelItems
            // 
            panelItems.Controls.Add(DGVSuppliers);
            panelItems.Dock = DockStyle.Fill;
            panelItems.Location = new Point(0, 77);
            panelItems.Name = "panelItems";
            panelItems.Padding = new Padding(10);
            panelItems.Size = new Size(800, 373);
            panelItems.TabIndex = 1;
            // 
            // DGVSuppliers
            // 
            DGVSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGVSuppliers.BackgroundColor = Color.White;
            DGVSuppliers.BorderStyle = BorderStyle.None;
            DGVSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSuppliers.Dock = DockStyle.Fill;
            DGVSuppliers.Location = new Point(10, 10);
            DGVSuppliers.Name = "DGVSuppliers";
            DGVSuppliers.Size = new Size(780, 353);
            DGVSuppliers.TabIndex = 0;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelItems);
            Controls.Add(panelButtons);
            Name = "FormSuppliers";
            Text = "Поставщики";
            panelButtons.ResumeLayout(false);
            panelItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panelItems;
        private DataGridView DGVSuppliers;
        private Button buttonHistory;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}
