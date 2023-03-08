
namespace dibujarMano
{
    partial class Form1
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEl = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBorrarAll = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(31, 21);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(242, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(284, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 399);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtR
            // 
            this.txtR.AccessibleName = "txtR";
            this.txtR.Location = new System.Drawing.Point(96, 72);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(78, 23);
            this.txtR.TabIndex = 2;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 305);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 31);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(12, 268);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(81, 31);
            this.btnPintar.TabIndex = 4;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // txtB
            // 
            this.txtB.AccessibleName = "txtB";
            this.txtB.Location = new System.Drawing.Point(96, 149);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(78, 23);
            this.txtB.TabIndex = 5;
            // 
            // txtG
            // 
            this.txtG.AccessibleName = "txtG";
            this.txtG.Location = new System.Drawing.Point(96, 110);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(78, 23);
            this.txtG.TabIndex = 6;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(136, 3);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 15);
            this.lblAncho.TabIndex = 7;
            this.lblAncho.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleName = "picBoxColor";
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox3.Location = new System.Drawing.Point(12, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 44);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleName = "picBoxN";
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(31, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 44);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Gray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "G";
            // 
            // btnEl
            // 
            this.btnEl.Location = new System.Drawing.Point(180, 195);
            this.btnEl.Name = "btnEl";
            this.btnEl.Size = new System.Drawing.Size(60, 29);
            this.btnEl.TabIndex = 14;
            this.btnEl.Text = "Ellipse";
            this.btnEl.UseVisualStyleBackColor = true;
            this.btnEl.Click += new System.EventHandler(this.btnEl_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(93, 195);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(60, 29);
            this.btnL.TabIndex = 15;
            this.btnL.Text = "Linea";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(136, 239);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 29);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "Cuadrado";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBorrarAll
            // 
            this.btnBorrarAll.Location = new System.Drawing.Point(12, 342);
            this.btnBorrarAll.Name = "btnBorrarAll";
            this.btnBorrarAll.Size = new System.Drawing.Size(81, 33);
            this.btnBorrarAll.TabIndex = 17;
            this.btnBorrarAll.Text = "Borrar todo";
            this.btnBorrarAll.UseVisualStyleBackColor = true;
            this.btnBorrarAll.Click += new System.EventHandler(this.btnBorrarAll_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(154, 313);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 18;
            this.btnG.Text = "Guardar";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "lblText";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnBorrarAll);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnEl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEl;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBorrarAll;
        private System.Windows.Forms.Button btnG;
    }
}

