namespace SimonSays
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.limitTimer = new System.Windows.Forms.Timer(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueRupeeBox = new System.Windows.Forms.PictureBox();
            this.yellowRupeeBox = new System.Windows.Forms.PictureBox();
            this.redRupeeBox = new System.Windows.Forms.PictureBox();
            this.greenRupeeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blueRupeeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowRupeeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redRupeeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenRupeeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(40, 153);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(110, 110);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Location = new System.Drawing.Point(156, 153);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(110, 110);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(156, 37);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(110, 110);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.FlatAppearance.BorderSize = 0;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(40, 37);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(110, 110);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // limitTimer
            // 
            this.limitTimer.Tick += new System.EventHandler(this.limitTimer_Tick);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.Location = new System.Drawing.Point(132, 4);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(43, 30);
            this.outputLabel.TabIndex = 4;
            // 
            // blueRupeeBox
            // 
            this.blueRupeeBox.BackColor = System.Drawing.Color.Transparent;
            this.blueRupeeBox.Image = global::SimonSays.Properties.Resources.blueRupeeResize;
            this.blueRupeeBox.Location = new System.Drawing.Point(249, 221);
            this.blueRupeeBox.Name = "blueRupeeBox";
            this.blueRupeeBox.Size = new System.Drawing.Size(52, 79);
            this.blueRupeeBox.TabIndex = 8;
            this.blueRupeeBox.TabStop = false;
            // 
            // yellowRupeeBox
            // 
            this.yellowRupeeBox.BackColor = System.Drawing.Color.Transparent;
            this.yellowRupeeBox.Image = global::SimonSays.Properties.Resources.goldRupeeResize;
            this.yellowRupeeBox.Location = new System.Drawing.Point(0, 221);
            this.yellowRupeeBox.Name = "yellowRupeeBox";
            this.yellowRupeeBox.Size = new System.Drawing.Size(52, 79);
            this.yellowRupeeBox.TabIndex = 7;
            this.yellowRupeeBox.TabStop = false;
            // 
            // redRupeeBox
            // 
            this.redRupeeBox.BackColor = System.Drawing.Color.Transparent;
            this.redRupeeBox.Image = global::SimonSays.Properties.Resources.redRupeeResize;
            this.redRupeeBox.Location = new System.Drawing.Point(249, 0);
            this.redRupeeBox.Name = "redRupeeBox";
            this.redRupeeBox.Size = new System.Drawing.Size(52, 79);
            this.redRupeeBox.TabIndex = 6;
            this.redRupeeBox.TabStop = false;
            // 
            // greenRupeeBox
            // 
            this.greenRupeeBox.BackColor = System.Drawing.Color.Transparent;
            this.greenRupeeBox.Image = global::SimonSays.Properties.Resources.greenRupeeResize;
            this.greenRupeeBox.Location = new System.Drawing.Point(0, 0);
            this.greenRupeeBox.Name = "greenRupeeBox";
            this.greenRupeeBox.Size = new System.Drawing.Size(52, 79);
            this.greenRupeeBox.TabIndex = 5;
            this.greenRupeeBox.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.blueRupeeBox);
            this.Controls.Add(this.yellowRupeeBox);
            this.Controls.Add(this.redRupeeBox);
            this.Controls.Add(this.greenRupeeBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueRupeeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowRupeeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redRupeeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenRupeeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Timer limitTimer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox greenRupeeBox;
        private System.Windows.Forms.PictureBox redRupeeBox;
        private System.Windows.Forms.PictureBox yellowRupeeBox;
        private System.Windows.Forms.PictureBox blueRupeeBox;
    }
}
