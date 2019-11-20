namespace MethodHalfDivAndCombinedTangedAndChordMetod
{
    partial class DrawGrafix
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
            this.RunCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunCalculate
            // 
            this.RunCalculate.BackColor = System.Drawing.Color.BlueViolet;
            this.RunCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RunCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunCalculate.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.RunCalculate.FlatAppearance.BorderSize = 0;
            this.RunCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.RunCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.RunCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunCalculate.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunCalculate.ForeColor = System.Drawing.Color.Khaki;
            this.RunCalculate.Location = new System.Drawing.Point(422, 367);
            this.RunCalculate.Name = "RunCalculate";
            this.RunCalculate.Size = new System.Drawing.Size(221, 51);
            this.RunCalculate.TabIndex = 0;
            this.RunCalculate.Text = "Найти";
            this.RunCalculate.UseVisualStyleBackColor = false;
            this.RunCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Метод Половинного деления и Комбинированный метод хорд и косательных";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Indigo;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.Khaki;
            this.Close.Location = new System.Drawing.Point(609, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(55, 40);
            this.Close.TabIndex = 3;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click_1);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // DrawGrafix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RunCalculate);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawGrafix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уточнитель корней";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
    }
}

