namespace lab2task3
{
    partial class MainForm
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
            this.startbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Anserlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startbutton.Location = new System.Drawing.Point(664, 9);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(233, 33);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "рассчитать";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дан текст, имеющий вид: d1 ± d2 ± dn, где di - цифры (n > 1). Вычислить записанну" +
    "ю в тексте сумму   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задача:";
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(27, 42);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(627, 23);
            this.inputtextBox.TabIndex = 3;
            this.inputtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputtextBox_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ответ:";
            // 
            // Anserlabel
            // 
            this.Anserlabel.Location = new System.Drawing.Point(698, 45);
            this.Anserlabel.Name = "Anserlabel";
            this.Anserlabel.Size = new System.Drawing.Size(186, 15);
            this.Anserlabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 78);
            this.Controls.Add(this.Anserlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startbutton);
            this.Name = "MainForm";
            this.Text = "Задача на строки";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startbutton;
        private Label label1;
        private Label label2;
        private TextBox inputtextBox;
        private Label label3;
        private Label Anserlabel;
    }
}