namespace lab5_1
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
            this.components = new System.ComponentModel.Container();
            this.IMG1 = new Emgu.CV.UI.ImageBox();
            this.IMG2 = new Emgu.CV.UI.ImageBox();
            this.load = new System.Windows.Forms.Button();
            this.binarb = new System.Windows.Forms.Button();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.lb1 = new System.Windows.Forms.Label();
            this.invcheck = new System.Windows.Forms.CheckBox();
            this.dilb = new System.Windows.Forms.Button();
            this.trb2 = new System.Windows.Forms.TrackBar();
            this.lb2 = new System.Windows.Forms.Label();
            this.contb = new System.Windows.Forms.Button();
            this.trb3 = new System.Windows.Forms.TrackBar();
            this.lb3 = new System.Windows.Forms.Label();
            this.cmbx1 = new System.Windows.Forms.ComboBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb3)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG1
            // 
            this.IMG1.Location = new System.Drawing.Point(12, 12);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(640, 480);
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            // 
            // IMG2
            // 
            this.IMG2.Location = new System.Drawing.Point(845, 12);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(640, 480);
            this.IMG2.TabIndex = 3;
            this.IMG2.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(658, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(181, 23);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // binarb
            // 
            this.binarb.Location = new System.Drawing.Point(658, 41);
            this.binarb.Name = "binarb";
            this.binarb.Size = new System.Drawing.Size(181, 23);
            this.binarb.TabIndex = 5;
            this.binarb.Text = "Binarize";
            this.binarb.UseVisualStyleBackColor = true;
            this.binarb.Click += new System.EventHandler(this.binarb_Click);
            // 
            // trb1
            // 
            this.trb1.LargeChange = 25;
            this.trb1.Location = new System.Drawing.Point(658, 70);
            this.trb1.Maximum = 255;
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(181, 45);
            this.trb1.TabIndex = 6;
            this.trb1.Value = 30;
            this.trb1.ValueChanged += new System.EventHandler(this.trb1_ValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(820, 102);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(19, 13);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "30";
            // 
            // invcheck
            // 
            this.invcheck.AutoSize = true;
            this.invcheck.Checked = true;
            this.invcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.invcheck.Location = new System.Drawing.Point(658, 121);
            this.invcheck.Name = "invcheck";
            this.invcheck.Size = new System.Drawing.Size(65, 17);
            this.invcheck.TabIndex = 8;
            this.invcheck.Text = "Inverted";
            this.invcheck.UseVisualStyleBackColor = true;
            // 
            // dilb
            // 
            this.dilb.Location = new System.Drawing.Point(658, 144);
            this.dilb.Name = "dilb";
            this.dilb.Size = new System.Drawing.Size(181, 23);
            this.dilb.TabIndex = 9;
            this.dilb.Text = "Dilatade";
            this.dilb.UseVisualStyleBackColor = true;
            this.dilb.Click += new System.EventHandler(this.dilb_Click);
            // 
            // trb2
            // 
            this.trb2.Location = new System.Drawing.Point(658, 173);
            this.trb2.Minimum = 1;
            this.trb2.Name = "trb2";
            this.trb2.Size = new System.Drawing.Size(181, 45);
            this.trb2.TabIndex = 10;
            this.trb2.Value = 3;
            this.trb2.ValueChanged += new System.EventHandler(this.trb2_ValueChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(820, 205);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(13, 13);
            this.lb2.TabIndex = 11;
            this.lb2.Text = "3";
            // 
            // contb
            // 
            this.contb.Location = new System.Drawing.Point(658, 224);
            this.contb.Name = "contb";
            this.contb.Size = new System.Drawing.Size(181, 23);
            this.contb.TabIndex = 12;
            this.contb.Text = "Find contours";
            this.contb.UseVisualStyleBackColor = true;
            this.contb.Click += new System.EventHandler(this.contb_Click);
            // 
            // trb3
            // 
            this.trb3.LargeChange = 20;
            this.trb3.Location = new System.Drawing.Point(658, 253);
            this.trb3.Maximum = 100;
            this.trb3.Minimum = 1;
            this.trb3.Name = "trb3";
            this.trb3.Size = new System.Drawing.Size(181, 45);
            this.trb3.TabIndex = 13;
            this.trb3.Value = 5;
            this.trb3.ValueChanged += new System.EventHandler(this.trb3_ValueChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(814, 285);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(19, 13);
            this.lb3.TabIndex = 14;
            this.lb3.Text = "50";
            // 
            // cmbx1
            // 
            this.cmbx1.FormattingEnabled = true;
            this.cmbx1.Location = new System.Drawing.Point(658, 380);
            this.cmbx1.Name = "cmbx1";
            this.cmbx1.Size = new System.Drawing.Size(121, 21);
            this.cmbx1.TabIndex = 15;
            this.cmbx1.SelectedIndexChanged += new System.EventHandler(this.cmbx1_SelectedIndexChanged);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(658, 354);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(28, 13);
            this.lb4.TabIndex = 16;
            this.lb4.Text = "Text";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(658, 304);
            this.rb1.Name = "rb1";
            this.rb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb1.Size = new System.Drawing.Size(44, 17);
            this.rb1.TabIndex = 17;
            this.rb1.TabStop = true;
            this.rb1.Text = "Eng";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(658, 327);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(44, 17);
            this.rb2.TabIndex = 18;
            this.rb2.Text = "Rus";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 565);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.cmbx1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.trb3);
            this.Controls.Add(this.contb);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.trb2);
            this.Controls.Add(this.dilb);
            this.Controls.Add(this.invcheck);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.binarb);
            this.Controls.Add(this.load);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IMG1;
        private Emgu.CV.UI.ImageBox IMG2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button binarb;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.CheckBox invcheck;
        private System.Windows.Forms.Button dilb;
        private System.Windows.Forms.TrackBar trb2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button contb;
        private System.Windows.Forms.TrackBar trb3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.ComboBox cmbx1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
    }
}

