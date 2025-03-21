namespace Materials_Lizyakin.Forms
{
    partial class FormEntry
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
            comboBoxType = new ComboBox();
            labelType = new Label();
            labelName = new Label();
            labelTin = new Label();
            textBoxName = new TextBox();
            textBoxTin = new TextBox();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(99, 24);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 0;
            comboBoxType.TextChanged += ComboBoxType_TextChanged;
            // 
            // labelType
            // 
            labelType.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelType.Location = new Point(24, 24);
            labelType.Margin = new Padding(15);
            labelType.Name = "labelType";
            labelType.Size = new Size(57, 23);
            labelType.TabIndex = 1;
            labelType.Text = "Тип";
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(24, 77);
            labelName.Margin = new Padding(15);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 23);
            labelName.TabIndex = 2;
            labelName.Text = "Имя";
            // 
            // labelTin
            // 
            labelTin.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTin.Location = new Point(24, 130);
            labelTin.Margin = new Padding(15);
            labelTin.Name = "labelTin";
            labelTin.Size = new Size(57, 23);
            labelTin.TabIndex = 3;
            labelTin.Text = "ИНН";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(99, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(263, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxTin
            // 
            textBoxTin.Location = new Point(99, 130);
            textBoxTin.Name = "textBoxTin";
            textBoxTin.Size = new Size(263, 23);
            textBoxTin.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Dock = DockStyle.Bottom;
            buttonConfirm.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonConfirm.Location = new Point(10, 204);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(392, 40);
            buttonConfirm.TabIndex = 6;
            buttonConfirm.Text = "Сохранить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += ButtonConfirm_Click;
            // 
            // FormEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 254);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxTin);
            Controls.Add(textBoxName);
            Controls.Add(labelTin);
            Controls.Add(labelName);
            Controls.Add(labelType);
            Controls.Add(comboBoxType);
            Name = "FormEntry";
            Padding = new Padding(10);
            Text = "Запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxType;
        private Label labelType;
        private Label labelName;
        private Label labelTin;
        private TextBox textBoxName;
        private TextBox textBoxTin;
        private Button buttonConfirm;
    }
}