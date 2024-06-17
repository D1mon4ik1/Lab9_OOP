namespace Lab9OOP
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtX0 = new TextBox();
            txtR = new TextBox();
            txtY0 = new TextBox();
            txtRsmall = new TextBox();
            btnPlot = new Button();
            picGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGraph).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "X0:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 1;
            label2.Text = "R:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 9);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 2;
            label3.Text = "Y0:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 9);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 3;
            label4.Text = "r:";
            // 
            // txtX0
            // 
            txtX0.Location = new Point(44, 6);
            txtX0.Name = "txtX0";
            txtX0.Size = new Size(125, 27);
            txtX0.TabIndex = 4;
            // 
            // txtR
            // 
            txtR.Location = new Point(236, 6);
            txtR.Name = "txtR";
            txtR.Size = new Size(125, 27);
            txtR.TabIndex = 5;
            // 
            // txtY0
            // 
            txtY0.Location = new Point(449, 9);
            txtY0.Name = "txtY0";
            txtY0.Size = new Size(125, 27);
            txtY0.TabIndex = 6;
            // 
            // txtRsmall
            // 
            txtRsmall.Location = new Point(625, 9);
            txtRsmall.Name = "txtRsmall";
            txtRsmall.Size = new Size(125, 27);
            txtRsmall.TabIndex = 7;
            // 
            // btnPlot
            // 
            btnPlot.Location = new Point(860, 9);
            btnPlot.Name = "btnPlot";
            btnPlot.Size = new Size(154, 35);
            btnPlot.TabIndex = 8;
            btnPlot.Text = "Плот";
            btnPlot.UseVisualStyleBackColor = true;
            btnPlot.Click += btnPlot_Click;
            // 
            // picGraph
            // 
            picGraph.Location = new Point(12, 61);
            picGraph.Name = "picGraph";
            picGraph.Size = new Size(1061, 653);
            picGraph.TabIndex = 9;
            picGraph.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 726);
            Controls.Add(picGraph);
            Controls.Add(btnPlot);
            Controls.Add(txtRsmall);
            Controls.Add(txtY0);
            Controls.Add(txtR);
            Controls.Add(txtX0);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtX0;
        private TextBox txtR;
        private TextBox txtY0;
        private TextBox txtRsmall;
        private Button btnPlot;
        private PictureBox picGraph;
    }
}
