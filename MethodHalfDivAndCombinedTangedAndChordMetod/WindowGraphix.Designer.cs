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
            this.MethChord = new System.Windows.Forms.Button();
            this.MethTanget = new System.Windows.Forms.Button();
            this.CombinedMeth = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MethHalfDiv = new System.Windows.Forms.Button();
            this.MethSimpleIter = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.NumberIteration = new System.Windows.Forms.Label();
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
            this.RunCalculate.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunCalculate.ForeColor = System.Drawing.Color.Khaki;
            this.RunCalculate.Location = new System.Drawing.Point(439, 347);
            this.RunCalculate.Name = "RunCalculate";
            this.RunCalculate.Size = new System.Drawing.Size(100, 45);
            this.RunCalculate.TabIndex = 0;
            this.RunCalculate.Text = "График";
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
            // MethChord
            // 
            this.MethChord.BackColor = System.Drawing.Color.BlueViolet;
            this.MethChord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MethChord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MethChord.Enabled = false;
            this.MethChord.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.MethChord.FlatAppearance.BorderSize = 0;
            this.MethChord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.MethChord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.MethChord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethChord.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethChord.ForeColor = System.Drawing.Color.Khaki;
            this.MethChord.Location = new System.Drawing.Point(439, 152);
            this.MethChord.Name = "MethChord";
            this.MethChord.Size = new System.Drawing.Size(103, 29);
            this.MethChord.TabIndex = 3;
            this.MethChord.Text = "Метод хорд";
            this.MethChord.UseVisualStyleBackColor = false;
            this.MethChord.Click += new System.EventHandler(this.MethChord_Click);
            // 
            // MethTanget
            // 
            this.MethTanget.BackColor = System.Drawing.Color.BlueViolet;
            this.MethTanget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MethTanget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MethTanget.Enabled = false;
            this.MethTanget.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.MethTanget.FlatAppearance.BorderSize = 0;
            this.MethTanget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.MethTanget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.MethTanget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethTanget.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethTanget.ForeColor = System.Drawing.Color.Khaki;
            this.MethTanget.Location = new System.Drawing.Point(439, 187);
            this.MethTanget.Name = "MethTanget";
            this.MethTanget.Size = new System.Drawing.Size(157, 34);
            this.MethTanget.TabIndex = 4;
            this.MethTanget.Text = "Метод косательных";
            this.MethTanget.UseVisualStyleBackColor = false;
            this.MethTanget.Click += new System.EventHandler(this.MethTanget_Click);
            // 
            // CombinedMeth
            // 
            this.CombinedMeth.BackColor = System.Drawing.Color.BlueViolet;
            this.CombinedMeth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CombinedMeth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CombinedMeth.Enabled = false;
            this.CombinedMeth.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.CombinedMeth.FlatAppearance.BorderSize = 0;
            this.CombinedMeth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.CombinedMeth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.CombinedMeth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CombinedMeth.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CombinedMeth.ForeColor = System.Drawing.Color.Khaki;
            this.CombinedMeth.Location = new System.Drawing.Point(439, 227);
            this.CombinedMeth.Name = "CombinedMeth";
            this.CombinedMeth.Size = new System.Drawing.Size(191, 34);
            this.CombinedMeth.TabIndex = 5;
            this.CombinedMeth.Text = "Комбинированный метод";
            this.CombinedMeth.UseVisualStyleBackColor = false;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(489, 96);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(30, 20);
            this.A.TabIndex = 6;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(589, 96);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(30, 20);
            this.B.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(446, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отрезок неопределённости";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(448, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "а = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(548, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "b = ";
            // 
            // MethHalfDiv
            // 
            this.MethHalfDiv.BackColor = System.Drawing.Color.BlueViolet;
            this.MethHalfDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MethHalfDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MethHalfDiv.Enabled = false;
            this.MethHalfDiv.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.MethHalfDiv.FlatAppearance.BorderSize = 0;
            this.MethHalfDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.MethHalfDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.MethHalfDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethHalfDiv.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethHalfDiv.ForeColor = System.Drawing.Color.Khaki;
            this.MethHalfDiv.Location = new System.Drawing.Point(439, 267);
            this.MethHalfDiv.Name = "MethHalfDiv";
            this.MethHalfDiv.Size = new System.Drawing.Size(205, 33);
            this.MethHalfDiv.TabIndex = 10;
            this.MethHalfDiv.Text = "Метод полвинного деления";
            this.MethHalfDiv.UseVisualStyleBackColor = false;
            // 
            // MethSimpleIter
            // 
            this.MethSimpleIter.BackColor = System.Drawing.Color.BlueViolet;
            this.MethSimpleIter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MethSimpleIter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MethSimpleIter.Enabled = false;
            this.MethSimpleIter.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.MethSimpleIter.FlatAppearance.BorderSize = 0;
            this.MethSimpleIter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.MethSimpleIter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.MethSimpleIter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethSimpleIter.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethSimpleIter.ForeColor = System.Drawing.Color.Khaki;
            this.MethSimpleIter.Location = new System.Drawing.Point(439, 306);
            this.MethSimpleIter.Name = "MethSimpleIter";
            this.MethSimpleIter.Size = new System.Drawing.Size(193, 35);
            this.MethSimpleIter.TabIndex = 11;
            this.MethSimpleIter.Text = "Метод простых итераций";
            this.MethSimpleIter.UseVisualStyleBackColor = false;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.ForeColor = System.Drawing.Color.Khaki;
            this.Result.Location = new System.Drawing.Point(439, 395);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(71, 21);
            this.Result.TabIndex = 12;
            this.Result.Text = "f(x) = 0 ";
            // 
            // NumberIteration
            // 
            this.NumberIteration.AutoSize = true;
            this.NumberIteration.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberIteration.ForeColor = System.Drawing.Color.Khaki;
            this.NumberIteration.Location = new System.Drawing.Point(439, 427);
            this.NumberIteration.Name = "NumberIteration";
            this.NumberIteration.Size = new System.Drawing.Size(122, 21);
            this.NumberIteration.TabIndex = 13;
            this.NumberIteration.Text = "Итераций -  ?";
            // 
            // DrawGrafix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 465);
            this.Controls.Add(this.NumberIteration);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.MethSimpleIter);
            this.Controls.Add(this.MethHalfDiv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.CombinedMeth);
            this.Controls.Add(this.MethTanget);
            this.Controls.Add(this.MethChord);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MethChord;
        private System.Windows.Forms.Button MethTanget;
        private System.Windows.Forms.Button CombinedMeth;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MethHalfDiv;
        private System.Windows.Forms.Button MethSimpleIter;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label NumberIteration;
    }
}

