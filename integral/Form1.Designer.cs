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
            this.res__simpson = new System.Windows.Forms.Button();
            this.border__b = new System.Windows.Forms.TextBox();
            this.border__a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.res__trapeze = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time__simpson = new System.Windows.Forms.TextBox();
            this.time__trapeze = new System.Windows.Forms.TextBox();
            this.res__out__simpson = new System.Windows.Forms.TextBox();
            this.res__out__trapeze = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // res__simpson
            // 
            this.res__simpson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.res__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__simpson.ForeColor = System.Drawing.Color.Blue;
            this.res__simpson.Location = new System.Drawing.Point(172, 489);
            this.res__simpson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.res__simpson.Name = "res__simpson";
            this.res__simpson.Size = new System.Drawing.Size(245, 59);
            this.res__simpson.TabIndex = 0;
            this.res__simpson.Text = "Расчитать интеграл";
            this.res__simpson.UseVisualStyleBackColor = false;
            // 
            // border__b
            // 
            this.border__b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__b.Location = new System.Drawing.Point(412, 174);
            this.border__b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.border__b.Name = "border__b";
            this.border__b.Size = new System.Drawing.Size(320, 26);
            this.border__b.TabIndex = 2;
            // 
            // border__a
            // 
            this.border__a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border__a.Location = new System.Drawing.Point(412, 140);
            this.border__a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.border__a.Name = "border__a";
            this.border__a.Size = new System.Drawing.Size(320, 26);
            this.border__a.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Верхняя граница интегрирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нижняя граница интегрирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кликни сюда чтобы расчитать интеграл методом Симсона";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(703, 464);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(571, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кликни сюда чтобы расчитать интеграл методом Трапеций";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // res__trapeze
            // 
            this.res__trapeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.res__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__trapeze.ForeColor = System.Drawing.Color.Blue;
            this.res__trapeze.Location = new System.Drawing.Point(861, 489);
            this.res__trapeze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.res__trapeze.Name = "res__trapeze";
            this.res__trapeze.Size = new System.Drawing.Size(245, 59);
            this.res__trapeze.TabIndex = 8;
            this.res__trapeze.Text = "Расчитать интеграл";
            this.res__trapeze.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(173, 620);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время выполнения ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(880, 620);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Время выполнения ";
            // 
            // time__simpson
            // 
            this.time__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time__simpson.ForeColor = System.Drawing.Color.Blue;
            this.time__simpson.Location = new System.Drawing.Point(169, 664);
            this.time__simpson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time__simpson.Name = "time__simpson";
            this.time__simpson.Size = new System.Drawing.Size(196, 26);
            this.time__simpson.TabIndex = 11;
            this.time__simpson.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // time__trapeze
            // 
            this.time__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time__trapeze.ForeColor = System.Drawing.Color.Blue;
            this.time__trapeze.Location = new System.Drawing.Point(876, 664);
            this.time__trapeze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time__trapeze.Name = "time__trapeze";
            this.time__trapeze.Size = new System.Drawing.Size(196, 26);
            this.time__trapeze.TabIndex = 12;
            // 
            // res__out__simpson
            // 
            this.res__out__simpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__out__simpson.Location = new System.Drawing.Point(172, 578);
            this.res__out__simpson.Name = "res__out__simpson";
            this.res__out__simpson.Size = new System.Drawing.Size(201, 26);
            this.res__out__simpson.TabIndex = 13;
            // 
            // res__out__trapeze
            // 
            this.res__out__trapeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res__out__trapeze.Location = new System.Drawing.Point(871, 578);
            this.res__out__trapeze.Name = "res__out__trapeze";
            this.res__out__trapeze.Size = new System.Drawing.Size(201, 26);
            this.res__out__trapeze.TabIndex = 14;
            // 
            // integral__Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 724);
            this.Controls.Add(this.res__out__trapeze);
            this.Controls.Add(this.res__out__simpson);
            this.Controls.Add(this.time__trapeze);
            this.Controls.Add(this.time__simpson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.res__trapeze);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.border__a);
            this.Controls.Add(this.border__b);
            this.Controls.Add(this.res__simpson);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "integral__Form";
            this.Text = "Integrals(Егоров, Журавлев 3-46 )";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button res__simpson;
        private System.Windows.Forms.TextBox border__b;
        private System.Windows.Forms.TextBox border__a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button res__trapeze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time__simpson;
        private System.Windows.Forms.TextBox time__trapeze;
        private System.Windows.Forms.TextBox res__out__simpson;
        private System.Windows.Forms.TextBox res__out__trapeze;
    }
}

