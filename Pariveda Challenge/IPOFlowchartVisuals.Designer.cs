namespace Pariveda_Challenge
{
    partial class IPOFlowchartVisuals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPOFlowchartVisuals));
            this.radioButtonIPO = new System.Windows.Forms.RadioButton();
            this.radioButtonFlowchart = new System.Windows.Forms.RadioButton();
            this.pictureBoxIPO = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlowchart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlowchart)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonIPO
            // 
            this.radioButtonIPO.AutoSize = true;
            this.radioButtonIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIPO.Location = new System.Drawing.Point(174, 85);
            this.radioButtonIPO.Name = "radioButtonIPO";
            this.radioButtonIPO.Size = new System.Drawing.Size(79, 33);
            this.radioButtonIPO.TabIndex = 0;
            this.radioButtonIPO.TabStop = true;
            this.radioButtonIPO.Text = "IPO";
            this.radioButtonIPO.UseVisualStyleBackColor = true;
            this.radioButtonIPO.CheckedChanged += new System.EventHandler(this.radioButtonIPO_CheckedChanged);
            // 
            // radioButtonFlowchart
            // 
            this.radioButtonFlowchart.AutoSize = true;
            this.radioButtonFlowchart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFlowchart.Location = new System.Drawing.Point(444, 85);
            this.radioButtonFlowchart.Name = "radioButtonFlowchart";
            this.radioButtonFlowchart.Size = new System.Drawing.Size(143, 33);
            this.radioButtonFlowchart.TabIndex = 1;
            this.radioButtonFlowchart.TabStop = true;
            this.radioButtonFlowchart.Text = "Flowchart";
            this.radioButtonFlowchart.UseVisualStyleBackColor = true;
            this.radioButtonFlowchart.CheckedChanged += new System.EventHandler(this.radioButtonFlowchart_CheckedChanged);
            // 
            // pictureBoxIPO
            // 
            this.pictureBoxIPO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIPO.Image")));
            this.pictureBoxIPO.Location = new System.Drawing.Point(59, 149);
            this.pictureBoxIPO.Name = "pictureBoxIPO";
            this.pictureBoxIPO.Size = new System.Drawing.Size(678, 689);
            this.pictureBoxIPO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIPO.TabIndex = 2;
            this.pictureBoxIPO.TabStop = false;
            // 
            // pictureBoxFlowchart
            // 
            this.pictureBoxFlowchart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlowchart.Image")));
            this.pictureBoxFlowchart.Location = new System.Drawing.Point(59, 149);
            this.pictureBoxFlowchart.Name = "pictureBoxFlowchart";
            this.pictureBoxFlowchart.Size = new System.Drawing.Size(678, 689);
            this.pictureBoxFlowchart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlowchart.TabIndex = 3;
            this.pictureBoxFlowchart.TabStop = false;
            this.pictureBoxFlowchart.Visible = false;
            // 
            // IPOFlowchartVisuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 875);
            this.Controls.Add(this.pictureBoxFlowchart);
            this.Controls.Add(this.pictureBoxIPO);
            this.Controls.Add(this.radioButtonFlowchart);
            this.Controls.Add(this.radioButtonIPO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPOFlowchartVisuals";
            this.ShowIcon = false;
            this.Text = "IPO and Flowchart Visuals";
            this.Load += new System.EventHandler(this.IPOFlowchartVisuals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlowchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonIPO;
        private System.Windows.Forms.RadioButton radioButtonFlowchart;
        private System.Windows.Forms.PictureBox pictureBoxIPO;
        private System.Windows.Forms.PictureBox pictureBoxFlowchart;
    }
}