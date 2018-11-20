namespace CaseProject
{
    partial class Start
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
            this.rightCornTxt = new System.Windows.Forms.TextBox();
            this.robotInitCoorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightCornTxt
            // 
            this.rightCornTxt.Location = new System.Drawing.Point(163, 48);
            this.rightCornTxt.Name = "rightCornTxt";
            this.rightCornTxt.Size = new System.Drawing.Size(154, 20);
            this.rightCornTxt.TabIndex = 0;
            // 
            // robotInitCoorTxt
            // 
            this.robotInitCoorTxt.Location = new System.Drawing.Point(163, 88);
            this.robotInitCoorTxt.Name = "robotInitCoorTxt";
            this.robotInitCoorTxt.Size = new System.Drawing.Size(154, 20);
            this.robotInitCoorTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sağ Üst Köşe Koordinatları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Robotik Gezginin İlk Koordinatı";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(183, 114);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(96, 33);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Oluştur";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 169);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.robotInitCoorTxt);
            this.Controls.Add(this.rightCornTxt);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rightCornTxt;
        private System.Windows.Forms.TextBox robotInitCoorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuild;
    }
}