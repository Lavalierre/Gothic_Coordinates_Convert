namespace G2O_CoordinatesConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputX_label = new System.Windows.Forms.Label();
            this.outputY_label = new System.Windows.Forms.Label();
            this.screenResX_box = new System.Windows.Forms.TextBox();
            this.screenRes_label = new System.Windows.Forms.Label();
            this.screenResY_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCoord_label = new System.Windows.Forms.Label();
            this.inputX_box = new System.Windows.Forms.TextBox();
            this.inputY_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputCoord_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inputW_box = new System.Windows.Forms.TextBox();
            this.inputH_box = new System.Windows.Forms.TextBox();
            this.outputW_label = new System.Windows.Forms.Label();
            this.outputH_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputX_label
            // 
            this.outputX_label.AutoSize = true;
            this.outputX_label.Location = new System.Drawing.Point(12, 127);
            this.outputX_label.Name = "outputX_label";
            this.outputX_label.Size = new System.Drawing.Size(17, 13);
            this.outputX_label.TabIndex = 0;
            this.outputX_label.Text = "X:";
            // 
            // outputY_label
            // 
            this.outputY_label.AutoSize = true;
            this.outputY_label.Location = new System.Drawing.Point(12, 141);
            this.outputY_label.Name = "outputY_label";
            this.outputY_label.Size = new System.Drawing.Size(17, 13);
            this.outputY_label.TabIndex = 1;
            this.outputY_label.Text = "Y:";
            // 
            // screenResX_box
            // 
            this.screenResX_box.Location = new System.Drawing.Point(264, 38);
            this.screenResX_box.MaxLength = 5;
            this.screenResX_box.Name = "screenResX_box";
            this.screenResX_box.Size = new System.Drawing.Size(48, 20);
            this.screenResX_box.TabIndex = 2;
            this.screenResX_box.TextChanged += new System.EventHandler(this.screenResX_TextChanged);
            this.screenResX_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.screenResX_KeyPress);
            // 
            // screenRes_label
            // 
            this.screenRes_label.AutoSize = true;
            this.screenRes_label.Location = new System.Drawing.Point(203, 19);
            this.screenRes_label.Name = "screenRes_label";
            this.screenRes_label.Size = new System.Drawing.Size(109, 13);
            this.screenRes_label.TabIndex = 3;
            this.screenRes_label.Text = "Разрешение экрана";
            // 
            // screenResY_box
            // 
            this.screenResY_box.Location = new System.Drawing.Point(264, 64);
            this.screenResY_box.MaxLength = 5;
            this.screenResY_box.Name = "screenResY_box";
            this.screenResY_box.Size = new System.Drawing.Size(48, 20);
            this.screenResY_box.TabIndex = 4;
            this.screenResY_box.TextChanged += new System.EventHandler(this.screenResY_TextChanged);
            this.screenResY_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.screenResY_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y:";
            // 
            // inputCoord_label
            // 
            this.inputCoord_label.AutoSize = true;
            this.inputCoord_label.Location = new System.Drawing.Point(12, 19);
            this.inputCoord_label.Name = "inputCoord_label";
            this.inputCoord_label.Size = new System.Drawing.Size(115, 13);
            this.inputCoord_label.TabIndex = 7;
            this.inputCoord_label.Text = "Входные координаты";
            // 
            // inputX_box
            // 
            this.inputX_box.Location = new System.Drawing.Point(35, 38);
            this.inputX_box.MaxLength = 5;
            this.inputX_box.Name = "inputX_box";
            this.inputX_box.Size = new System.Drawing.Size(48, 20);
            this.inputX_box.TabIndex = 8;
            this.inputX_box.TextChanged += new System.EventHandler(this.inputX_TextChanged);
            this.inputX_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputX_KeyPress);
            // 
            // inputY_box
            // 
            this.inputY_box.Location = new System.Drawing.Point(35, 64);
            this.inputY_box.MaxLength = 5;
            this.inputY_box.Name = "inputY_box";
            this.inputY_box.Size = new System.Drawing.Size(48, 20);
            this.inputY_box.TabIndex = 9;
            this.inputY_box.TextChanged += new System.EventHandler(this.inputY_TextChanged);
            this.inputY_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputY_KeyPressed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Y:";
            // 
            // outputCoord_label
            // 
            this.outputCoord_label.AutoSize = true;
            this.outputCoord_label.Location = new System.Drawing.Point(12, 104);
            this.outputCoord_label.Name = "outputCoord_label";
            this.outputCoord_label.Size = new System.Drawing.Size(123, 13);
            this.outputCoord_label.TabIndex = 12;
            this.outputCoord_label.Text = "Выходные координаты";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(269, 141);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(73, 13);
            this.author_label.TabIndex = 13;
            this.author_label.Text = "Автор: RTSR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "W:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "H:";
            // 
            // inputW_box
            // 
            this.inputW_box.Location = new System.Drawing.Point(127, 38);
            this.inputW_box.MaxLength = 5;
            this.inputW_box.Name = "inputW_box";
            this.inputW_box.Size = new System.Drawing.Size(48, 20);
            this.inputW_box.TabIndex = 16;
            this.inputW_box.TextChanged += new System.EventHandler(this.inputW_TextChanged);
            this.inputW_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputW_KeyPress);
            // 
            // inputH_box
            // 
            this.inputH_box.Location = new System.Drawing.Point(127, 64);
            this.inputH_box.MaxLength = 5;
            this.inputH_box.Name = "inputH_box";
            this.inputH_box.Size = new System.Drawing.Size(48, 20);
            this.inputH_box.TabIndex = 17;
            this.inputH_box.TextChanged += new System.EventHandler(this.inputH_TextChanged);
            this.inputH_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputH_KeyPress);
            // 
            // outputW_label
            // 
            this.outputW_label.AutoSize = true;
            this.outputW_label.Location = new System.Drawing.Point(78, 127);
            this.outputW_label.Name = "outputW_label";
            this.outputW_label.Size = new System.Drawing.Size(21, 13);
            this.outputW_label.TabIndex = 18;
            this.outputW_label.Text = "W:";
            // 
            // outputH_label
            // 
            this.outputH_label.AutoSize = true;
            this.outputH_label.Location = new System.Drawing.Point(78, 141);
            this.outputH_label.Name = "outputH_label";
            this.outputH_label.Size = new System.Drawing.Size(18, 13);
            this.outputH_label.TabIndex = 19;
            this.outputH_label.Text = "H:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 163);
            this.Controls.Add(this.outputH_label);
            this.Controls.Add(this.outputW_label);
            this.Controls.Add(this.inputH_box);
            this.Controls.Add(this.inputW_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.outputCoord_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputY_box);
            this.Controls.Add(this.inputX_box);
            this.Controls.Add(this.inputCoord_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.screenResY_box);
            this.Controls.Add(this.screenRes_label);
            this.Controls.Add(this.screenResX_box);
            this.Controls.Add(this.outputY_label);
            this.Controls.Add(this.outputX_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gothic Coordinates Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputX_label;
        private System.Windows.Forms.Label outputY_label;
        private System.Windows.Forms.TextBox screenResX_box;
        private System.Windows.Forms.Label screenRes_label;
        private System.Windows.Forms.TextBox screenResY_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label inputCoord_label;
        private System.Windows.Forms.TextBox inputX_box;
        private System.Windows.Forms.TextBox inputY_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label outputCoord_label;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputW_box;
        private System.Windows.Forms.TextBox inputH_box;
        private System.Windows.Forms.Label outputW_label;
        private System.Windows.Forms.Label outputH_label;
    }
}

