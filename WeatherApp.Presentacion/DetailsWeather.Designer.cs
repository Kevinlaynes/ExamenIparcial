
namespace WeatherApp.Presentacion
{
    partial class DetailsWeather
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
            this.lblDetailValue = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetailValue
            // 
            this.lblDetailValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailValue.Location = new System.Drawing.Point(12, 26);
            this.lblDetailValue.Name = "lblDetailValue";
            this.lblDetailValue.Size = new System.Drawing.Size(153, 18);
            this.lblDetailValue.TabIndex = 3;
            this.lblDetailValue.Text = "Value";
            this.lblDetailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetail
            // 
            this.lblDetail.Location = new System.Drawing.Point(12, 9);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(153, 17);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "DetailWeather";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailsWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(180, 74);
            this.Controls.Add(this.lblDetailValue);
            this.Controls.Add(this.lblDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsWeather";
            this.Text = "DetailsWeather";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblDetailValue;
        public System.Windows.Forms.Label lblDetail;
    }
}