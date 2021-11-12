
namespace santafactory
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCar = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.Button();
            this.colorRibbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(0, 274);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(799, 152);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(39, 24);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(120, 72);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "CAR";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(181, 24);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(120, 72);
            this.btnBall.TabIndex = 2;
            this.btnBall.Text = "BALL";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(507, 24);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(99, 20);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming Next";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.Location = new System.Drawing.Point(181, 112);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 28);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(323, 24);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(120, 72);
            this.btnPresent.TabIndex = 5;
            this.btnPresent.Text = "PRESENT";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Red;
            this.colorBox.Location = new System.Drawing.Point(323, 112);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(120, 28);
            this.colorBox.TabIndex = 6;
            this.colorBox.UseVisualStyleBackColor = false;
            // 
            // colorRibbon
            // 
            this.colorRibbon.BackColor = System.Drawing.Color.Yellow;
            this.colorRibbon.Location = new System.Drawing.Point(323, 146);
            this.colorRibbon.Name = "colorRibbon";
            this.colorRibbon.Size = new System.Drawing.Size(120, 28);
            this.colorRibbon.TabIndex = 7;
            this.colorRibbon.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorRibbon);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button colorRibbon;
    }
}

