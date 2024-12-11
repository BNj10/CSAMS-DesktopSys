namespace CSAMS_WebSys.UserControls
{
    partial class CheckInternet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.internetCheckText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.SuspendLayout();
            // 
            // internetCheckText_gunaLabel
            // 
            this.internetCheckText_gunaLabel.AutoSize = true;
            this.internetCheckText_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internetCheckText_gunaLabel.Location = new System.Drawing.Point(43, 15);
            this.internetCheckText_gunaLabel.Name = "internetCheckText_gunaLabel";
            this.internetCheckText_gunaLabel.Size = new System.Drawing.Size(175, 25);
            this.internetCheckText_gunaLabel.TabIndex = 0;
            this.internetCheckText_gunaLabel.Text = "Internet Connected";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Green;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(12, 16);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 9;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(25, 22);
            this.gunaElipsePanel1.TabIndex = 1;
            // 
            // CheckInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.internetCheckText_gunaLabel);
            this.Name = "CheckInternet";
            this.Size = new System.Drawing.Size(256, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel internetCheckText_gunaLabel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}
