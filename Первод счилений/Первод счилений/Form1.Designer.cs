namespace Первод_счилений
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
            this.textBoxNp = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxN10 = new System.Windows.Forms.TextBox();
            this.buttonFrom10to2 = new System.Windows.Forms.Button();
            this.buttonPto10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNp
            // 
            this.textBoxNp.Location = new System.Drawing.Point(412, 102);
            this.textBoxNp.Name = "textBoxNp";
            this.textBoxNp.Size = new System.Drawing.Size(206, 20);
            this.textBoxNp.TabIndex = 0;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(314, 102);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(45, 20);
            this.textBoxP.TabIndex = 1;
            // 
            // textBoxN10
            // 
            this.textBoxN10.Location = new System.Drawing.Point(62, 102);
            this.textBoxN10.Name = "textBoxN10";
            this.textBoxN10.Size = new System.Drawing.Size(206, 20);
            this.textBoxN10.TabIndex = 2;
            this.textBoxN10.TextChanged += new System.EventHandler(this.textBoxN10_TextChanged);
            // 
            // buttonFrom10to2
            // 
            this.buttonFrom10to2.Location = new System.Drawing.Point(62, 145);
            this.buttonFrom10to2.Name = "buttonFrom10to2";
            this.buttonFrom10to2.Size = new System.Drawing.Size(131, 50);
            this.buttonFrom10to2.TabIndex = 6;
            this.buttonFrom10to2.Text = "Из 10 в 2";
            this.buttonFrom10to2.UseVisualStyleBackColor = true;
            this.buttonFrom10to2.Click += new System.EventHandler(this.buttonFrom10to2_Click);
            // 
            // buttonPto10
            // 
            this.buttonPto10.Location = new System.Drawing.Point(412, 145);
            this.buttonPto10.Name = "buttonPto10";
            this.buttonPto10.Size = new System.Drawing.Size(131, 50);
            this.buttonPto10.TabIndex = 7;
            this.buttonPto10.Text = "из 2 в 10";
            this.buttonPto10.UseVisualStyleBackColor = true;
            this.buttonPto10.Click += new System.EventHandler(this.buttonPto10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 404);
            this.Controls.Add(this.buttonPto10);
            this.Controls.Add(this.buttonFrom10to2);
            this.Controls.Add(this.textBoxN10);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxNp);
            this.Name = "Form1";
            this.Text = "Перевод счислений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNp;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxN10;
        private System.Windows.Forms.Button buttonFrom10to2;
        private System.Windows.Forms.Button buttonPto10;
    }
}

