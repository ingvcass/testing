namespace tree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.at = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.TextBox();
            this.ct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // at
            // 
            this.at.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.at.Location = new System.Drawing.Point(38, 96);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(174, 56);
            this.at.TabIndex = 0;
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt.Location = new System.Drawing.Point(253, 96);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(174, 56);
            this.bt.TabIndex = 1;
            // 
            // ct
            // 
            this.ct.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ct.Location = new System.Drawing.Point(471, 96);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(174, 56);
            this.ct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите стороны треугольника";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SeaShell;
            this.start.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(207, 193);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(264, 56);
            this.start.TabIndex = 4;
            this.start.Text = "Проверить";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(686, 286);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.at);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox at;
        private System.Windows.Forms.TextBox bt;
        private System.Windows.Forms.TextBox ct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
    }
}

