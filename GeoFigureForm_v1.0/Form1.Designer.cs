namespace GeoFigureForm_v1._0
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
            this.labelForFigur = new System.Windows.Forms.Label();
            this.comboBoxForFigure = new System.Windows.Forms.ComboBox();
            this.textBoxForFigure1 = new System.Windows.Forms.TextBox();
            this.textBoxForFigure2 = new System.Windows.Forms.TextBox();
            this.textBoxForFigure3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForFigure = new System.Windows.Forms.Button();
            this.buttonForSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForFigur
            // 
            this.labelForFigur.AutoSize = true;
            this.labelForFigur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForFigur.Location = new System.Drawing.Point(59, 42);
            this.labelForFigur.Name = "labelForFigur";
            this.labelForFigur.Size = new System.Drawing.Size(189, 24);
            this.labelForFigur.TabIndex = 0;
            this.labelForFigur.Text = "Выберите фигуру ";
            // 
            // comboBoxForFigure
            // 
            this.comboBoxForFigure.FormattingEnabled = true;
            this.comboBoxForFigure.Items.AddRange(new object[] {
            "Прямоугольник",
            "Треугольник",
            "Круг"});
            this.comboBoxForFigure.Location = new System.Drawing.Point(400, 47);
            this.comboBoxForFigure.Name = "comboBoxForFigure";
            this.comboBoxForFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForFigure.TabIndex = 1;
            this.comboBoxForFigure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxForFigure_MouseClick);
            // 
            // textBoxForFigure1
            // 
            this.textBoxForFigure1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForFigure1.Location = new System.Drawing.Point(91, 152);
            this.textBoxForFigure1.Multiline = true;
            this.textBoxForFigure1.Name = "textBoxForFigure1";
            this.textBoxForFigure1.Size = new System.Drawing.Size(91, 58);
            this.textBoxForFigure1.TabIndex = 2;
            // 
            // textBoxForFigure2
            // 
            this.textBoxForFigure2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForFigure2.Location = new System.Drawing.Point(287, 152);
            this.textBoxForFigure2.Multiline = true;
            this.textBoxForFigure2.Name = "textBoxForFigure2";
            this.textBoxForFigure2.Size = new System.Drawing.Size(91, 58);
            this.textBoxForFigure2.TabIndex = 3;
            // 
            // textBoxForFigure3
            // 
            this.textBoxForFigure3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForFigure3.Location = new System.Drawing.Point(476, 152);
            this.textBoxForFigure3.Multiline = true;
            this.textBoxForFigure3.Name = "textBoxForFigure3";
            this.textBoxForFigure3.Size = new System.Drawing.Size(91, 58);
            this.textBoxForFigure3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(472, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 7;
            // 
            // buttonForFigure
            // 
            this.buttonForFigure.AllowDrop = true;
            this.buttonForFigure.Location = new System.Drawing.Point(287, 45);
            this.buttonForFigure.Name = "buttonForFigure";
            this.buttonForFigure.Size = new System.Drawing.Size(75, 23);
            this.buttonForFigure.TabIndex = 8;
            this.buttonForFigure.Text = "Выбрать";
            this.buttonForFigure.UseVisualStyleBackColor = true;
            this.buttonForFigure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForFigure_MouseClick);
            // 
            // buttonForSelect
            // 
            this.buttonForSelect.Location = new System.Drawing.Point(256, 262);
            this.buttonForSelect.Name = "buttonForSelect";
            this.buttonForSelect.Size = new System.Drawing.Size(122, 23);
            this.buttonForSelect.TabIndex = 9;
            this.buttonForSelect.Text = "Подтвердить ввод";
            this.buttonForSelect.UseVisualStyleBackColor = true;
            this.buttonForSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonForSelect_KeyDown);
            this.buttonForSelect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForSelect_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 297);
            this.Controls.Add(this.buttonForSelect);
            this.Controls.Add(this.buttonForFigure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFigure3);
            this.Controls.Add(this.textBoxForFigure2);
            this.Controls.Add(this.textBoxForFigure1);
            this.Controls.Add(this.comboBoxForFigure);
            this.Controls.Add(this.labelForFigur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForFigur;
        private System.Windows.Forms.ComboBox comboBoxForFigure;
        private System.Windows.Forms.TextBox textBoxForFigure1;
        private System.Windows.Forms.TextBox textBoxForFigure2;
        private System.Windows.Forms.TextBox textBoxForFigure3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonForFigure;
        private System.Windows.Forms.Button buttonForSelect;
    }
}

