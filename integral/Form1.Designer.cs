namespace integral
{
    partial class integral__Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(integral__Form));
            this.res__simpson = new System.Windows.Forms.Button();
            this.border__b = new System.Windows.Forms.TextBox();
            this.border__a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.res__trapeze = new System.Windows.Forms.Button();
            this.time__simpson = new System.Windows.Forms.TextBox();
            this.time__trapeze = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.res__out__simpson = new System.Windows.Forms.TextBox();
            this.res__out__trapeze = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // res__simpson
            // 
            this.res__simpson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.res__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__simpson.ForeColor = System.Drawing.Color.Black;
            this.res__simpson.Location = new System.Drawing.Point(227, 289);
            this.res__simpson.Name = "res__simpson";
            this.res__simpson.Size = new System.Drawing.Size(208, 48);
            this.res__simpson.TabIndex = 0;
            this.res__simpson.Text = "Трапеции";
            this.res__simpson.UseVisualStyleBackColor = false;
            // 
            // border__b
            // 
            this.border__b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__b.Location = new System.Drawing.Point(275, 61);
            this.border__b.Name = "border__b";
            this.border__b.Size = new System.Drawing.Size(127, 23);
            this.border__b.TabIndex = 2;
            // 
            // border__a
            // 
            this.border__a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__a.Location = new System.Drawing.Point(275, 33);
            this.border__a.Name = "border__a";
            this.border__a.Size = new System.Drawing.Size(127, 23);
            this.border__a.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Верхняя граница интегрирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нижняя граница интегрирования";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // res__trapeze
            // 
            this.res__trapeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.res__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__trapeze.ForeColor = System.Drawing.Color.Black;
            this.res__trapeze.Location = new System.Drawing.Point(16, 289);
            this.res__trapeze.Name = "res__trapeze";
            this.res__trapeze.Size = new System.Drawing.Size(205, 48);
            this.res__trapeze.TabIndex = 8;
            this.res__trapeze.Text = "Симпсон";
            this.res__trapeze.UseVisualStyleBackColor = false;
            // 
            // time__simpson
            // 
            this.time__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time__simpson.ForeColor = System.Drawing.Color.Blue;
            this.time__simpson.Location = new System.Drawing.Point(16, 468);
            this.time__simpson.Name = "time__simpson";
            this.time__simpson.Size = new System.Drawing.Size(204, 23);
            this.time__simpson.TabIndex = 11;
            this.time__simpson.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // time__trapeze
            // 
            this.time__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time__trapeze.ForeColor = System.Drawing.Color.Blue;
            this.time__trapeze.Location = new System.Drawing.Point(227, 468);
            this.time__trapeze.Name = "time__trapeze";
            this.time__trapeze.Size = new System.Drawing.Size(208, 23);
            this.time__trapeze.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.border__a);
            this.groupBox1.Controls.Add(this.border__b);
            this.groupBox1.Location = new System.Drawing.Point(16, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "границы интегрирования";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // res__out__simpson
            // 
            this.res__out__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__out__simpson.Location = new System.Drawing.Point(15, 393);
            this.res__out__simpson.Margin = new System.Windows.Forms.Padding(2);
            this.res__out__simpson.Name = "res__out__simpson";
            this.res__out__simpson.Size = new System.Drawing.Size(205, 23);
            this.res__out__simpson.TabIndex = 13;
            // 
            // res__out__trapeze
            // 
            this.res__out__trapeze.BackColor = System.Drawing.Color.White;
            this.res__out__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__out__trapeze.Location = new System.Drawing.Point(227, 393);
            this.res__out__trapeze.Margin = new System.Windows.Forms.Padding(2);
            this.res__out__trapeze.Name = "res__out__trapeze";
            this.res__out__trapeze.Size = new System.Drawing.Size(208, 23);
            this.res__out__trapeze.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(194, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(172, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "результаты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // integral__Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.res__out__trapeze);
            this.Controls.Add(this.res__out__simpson);
            this.Controls.Add(this.time__trapeze);
            this.Controls.Add(this.time__simpson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.res__trapeze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res__simpson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "integral__Form";
            this.Text = "Integrals (Егоров, Журавлев 3-46 )";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.integral__Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button res__simpson;
        private System.Windows.Forms.TextBox border__b;
        private System.Windows.Forms.TextBox border__a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button res__trapeze;
        private System.Windows.Forms.TextBox time__simpson;
        private System.Windows.Forms.TextBox time__trapeze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox res__out__simpson;
        private System.Windows.Forms.TextBox res__out__trapeze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

