
namespace PD
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChoiceFormuls = new System.Windows.Forms.Label();
            this.Formula1 = new System.Windows.Forms.Button();
            this.Formula3 = new System.Windows.Forms.Button();
            this.Formula2 = new System.Windows.Forms.Button();
            this.Formula4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Formula4);
            this.panel1.Controls.Add(this.Formula2);
            this.panel1.Controls.Add(this.Formula3);
            this.panel1.Controls.Add(this.Formula1);
            this.panel1.Controls.Add(this.ChoiceFormuls);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // ChoiceFormuls
            // 
            this.ChoiceFormuls.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChoiceFormuls.AutoSize = true;
            this.ChoiceFormuls.BackColor = System.Drawing.Color.Maroon;
            this.ChoiceFormuls.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceFormuls.ForeColor = System.Drawing.Color.Black;
            this.ChoiceFormuls.Location = new System.Drawing.Point(140, 0);
            this.ChoiceFormuls.Name = "ChoiceFormuls";
            this.ChoiceFormuls.Size = new System.Drawing.Size(513, 56);
            this.ChoiceFormuls.TabIndex = 0;
            this.ChoiceFormuls.Text = "Выберите формулу";
            // 
            // Formula1
            // 
            this.Formula1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Formula1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formula1.Location = new System.Drawing.Point(13, 99);
            this.Formula1.Name = "Formula1";
            this.Formula1.Size = new System.Drawing.Size(347, 96);
            this.Formula1.TabIndex = 1;
            this.Formula1.Text = "Р = ρ*g*H  ";
            this.Formula1.UseVisualStyleBackColor = false;
            this.Formula1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formula3
            // 
            this.Formula3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Formula3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formula3.Location = new System.Drawing.Point(13, 219);
            this.Formula3.Name = "Formula3";
            this.Formula3.Size = new System.Drawing.Size(347, 96);
            this.Formula3.TabIndex = 2;
            this.Formula3.Text = "P = (H*ρ)/C";
            this.Formula3.UseVisualStyleBackColor = false;
            this.Formula3.Click += new System.EventHandler(this.Formula3_Click);
            // 
            // Formula2
            // 
            this.Formula2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Formula2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formula2.Location = new System.Drawing.Point(441, 99);
            this.Formula2.Name = "Formula2";
            this.Formula2.Size = new System.Drawing.Size(347, 96);
            this.Formula2.TabIndex = 3;
            this.Formula2.Text = "Р = ρ*g*L + Ру";
            this.Formula2.UseVisualStyleBackColor = false;
            this.Formula2.Click += new System.EventHandler(this.Formula2_Click);
            // 
            // Formula4
            // 
            this.Formula4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Formula4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Formula4.Location = new System.Drawing.Point(441, 219);
            this.Formula4.Name = "Formula4";
            this.Formula4.Size = new System.Drawing.Size(347, 96);
            this.Formula4.TabIndex = 4;
            this.Formula4.Text = "Р = Рст. * e^s";
            this.Formula4.UseVisualStyleBackColor = false;
            this.Formula4.Click += new System.EventHandler(this.Formula4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 96);
            this.button1.TabIndex = 6;
            this.button1.Text = "pV = zGRT ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(441, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 96);
            this.button2.TabIndex = 7;
            this.button2.Text = "R = Rу / Mг ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ChoiceFormuls;
        private System.Windows.Forms.Button Formula1;
        private System.Windows.Forms.Button Formula4;
        private System.Windows.Forms.Button Formula2;
        private System.Windows.Forms.Button Formula3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

