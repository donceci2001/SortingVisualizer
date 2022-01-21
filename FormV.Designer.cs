
namespace SortV
{
    partial class FormVisualization
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
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.panelVisualization = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxArrayElements = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(12, 22);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(148, 20);
            this.labelAlgorithm.TabIndex = 1;
            this.labelAlgorithm.Text = "Number of elements:";
            // 
            // panelVisualization
            // 
            this.panelVisualization.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelVisualization.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVisualization.Location = new System.Drawing.Point(0, 103);
            this.panelVisualization.Name = "panelVisualization";
            this.panelVisualization.Size = new System.Drawing.Size(893, 534);
            this.panelVisualization.TabIndex = 3;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(682, 24);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(800, 24);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(93, 28);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxArrayElements
            // 
            this.textBoxArrayElements.Location = new System.Drawing.Point(166, 22);
            this.textBoxArrayElements.Name = "textBoxArrayElements";
            this.textBoxArrayElements.Size = new System.Drawing.Size(97, 27);
            this.textBoxArrayElements.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(398, 24);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(164, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Min Speed";
            // 
            // FormVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBoxArrayElements);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.panelVisualization);
            this.Controls.Add(this.labelAlgorithm);
            this.Name = "FormVisualization";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel panelVisualization;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxArrayElements;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

