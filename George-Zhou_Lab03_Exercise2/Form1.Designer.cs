namespace George_Zhou_Lab03_Exercise2
{
    partial class Exercise2
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
            this.gBoxCalcAsync = new System.Windows.Forms.GroupBox();
            this.GBoxCLC = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxFacInput = new System.Windows.Forms.TextBox();
            this.buttonCalculateFac = new System.Windows.Forms.Button();
            this.tBoxResultFac = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.tbxLoanAmount = new System.Windows.Forms.TextBox();
            this.tbxIntRate = new System.Windows.Forms.TextBox();
            this.lblIntRate = new System.Windows.Forms.Label();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnCalcInterest = new System.Windows.Forms.Button();
            this.tbxIntResult = new System.Windows.Forms.TextBox();
            this.gBoxCalcAsync.SuspendLayout();
            this.GBoxCLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCalcAsync
            // 
            this.gBoxCalcAsync.Controls.Add(this.tBoxResultFac);
            this.gBoxCalcAsync.Controls.Add(this.buttonCalculateFac);
            this.gBoxCalcAsync.Controls.Add(this.tBoxFacInput);
            this.gBoxCalcAsync.Controls.Add(this.label1);
            this.gBoxCalcAsync.Location = new System.Drawing.Point(12, 12);
            this.gBoxCalcAsync.Name = "gBoxCalcAsync";
            this.gBoxCalcAsync.Size = new System.Drawing.Size(493, 312);
            this.gBoxCalcAsync.TabIndex = 0;
            this.gBoxCalcAsync.TabStop = false;
            this.gBoxCalcAsync.Text = "Calcuate Asynchronously";
            // 
            // GBoxCLC
            // 
            this.GBoxCLC.Controls.Add(this.tbxIntResult);
            this.GBoxCLC.Controls.Add(this.btnCalcInterest);
            this.GBoxCLC.Controls.Add(this.tbxDuration);
            this.GBoxCLC.Controls.Add(this.lblDuration);
            this.GBoxCLC.Controls.Add(this.tbxIntRate);
            this.GBoxCLC.Controls.Add(this.lblIntRate);
            this.GBoxCLC.Controls.Add(this.tbxLoanAmount);
            this.GBoxCLC.Controls.Add(this.lblLoanAmount);
            this.GBoxCLC.Location = new System.Drawing.Point(527, 12);
            this.GBoxCLC.Name = "GBoxCLC";
            this.GBoxCLC.Size = new System.Drawing.Size(657, 427);
            this.GBoxCLC.TabIndex = 1;
            this.GBoxCLC.TabStop = false;
            this.GBoxCLC.Text = "Car Loan Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial Of:";
            // 
            // tBoxFacInput
            // 
            this.tBoxFacInput.Location = new System.Drawing.Point(138, 62);
            this.tBoxFacInput.Name = "tBoxFacInput";
            this.tBoxFacInput.Size = new System.Drawing.Size(349, 26);
            this.tBoxFacInput.TabIndex = 1;
            // 
            // buttonCalculateFac
            // 
            this.buttonCalculateFac.Location = new System.Drawing.Point(181, 94);
            this.buttonCalculateFac.Name = "buttonCalculateFac";
            this.buttonCalculateFac.Size = new System.Drawing.Size(117, 64);
            this.buttonCalculateFac.TabIndex = 2;
            this.buttonCalculateFac.Text = "Calculate";
            this.buttonCalculateFac.UseVisualStyleBackColor = true;
            this.buttonCalculateFac.Click += new System.EventHandler(this.buttonCalculateFac_Click);
            // 
            // tBoxResultFac
            // 
            this.tBoxResultFac.Enabled = false;
            this.tBoxResultFac.Location = new System.Drawing.Point(10, 199);
            this.tBoxResultFac.Name = "tBoxResultFac";
            this.tBoxResultFac.Size = new System.Drawing.Size(477, 26);
            this.tBoxResultFac.TabIndex = 3;
            this.tBoxResultFac.Text = "Factorial is:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(80, 62);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(109, 20);
            this.lblLoanAmount.TabIndex = 1;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // tbxLoanAmount
            // 
            this.tbxLoanAmount.Location = new System.Drawing.Point(195, 56);
            this.tbxLoanAmount.Name = "tbxLoanAmount";
            this.tbxLoanAmount.Size = new System.Drawing.Size(349, 26);
            this.tbxLoanAmount.TabIndex = 2;
            // 
            // tbxIntRate
            // 
            this.tbxIntRate.Location = new System.Drawing.Point(195, 110);
            this.tbxIntRate.Name = "tbxIntRate";
            this.tbxIntRate.Size = new System.Drawing.Size(349, 26);
            this.tbxIntRate.TabIndex = 4;
            // 
            // lblIntRate
            // 
            this.lblIntRate.AutoSize = true;
            this.lblIntRate.Location = new System.Drawing.Point(80, 116);
            this.lblIntRate.Name = "lblIntRate";
            this.lblIntRate.Size = new System.Drawing.Size(107, 20);
            this.lblIntRate.TabIndex = 3;
            this.lblIntRate.Text = "Interest Rate:";
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(195, 167);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(349, 26);
            this.tbxDuration.TabIndex = 6;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(80, 173);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration:";
            // 
            // btnCalcInterest
            // 
            this.btnCalcInterest.Location = new System.Drawing.Point(266, 199);
            this.btnCalcInterest.Name = "btnCalcInterest";
            this.btnCalcInterest.Size = new System.Drawing.Size(117, 64);
            this.btnCalcInterest.TabIndex = 7;
            this.btnCalcInterest.Text = "Calculate Interest";
            this.btnCalcInterest.UseVisualStyleBackColor = true;
            this.btnCalcInterest.Click += new System.EventHandler(this.btnCalcInterest_Click);
            // 
            // tbxIntResult
            // 
            this.tbxIntResult.Enabled = false;
            this.tbxIntResult.Location = new System.Drawing.Point(84, 286);
            this.tbxIntResult.Name = "tbxIntResult";
            this.tbxIntResult.Size = new System.Drawing.Size(477, 26);
            this.tbxIntResult.TabIndex = 8;
            this.tbxIntResult.Text = "Interest is:";
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 447);
            this.Controls.Add(this.GBoxCLC);
            this.Controls.Add(this.gBoxCalcAsync);
            this.Name = "Exercise2";
            this.Text = "Asynchronous Programming";
            this.gBoxCalcAsync.ResumeLayout(false);
            this.gBoxCalcAsync.PerformLayout();
            this.GBoxCLC.ResumeLayout(false);
            this.GBoxCLC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCalcAsync;
        private System.Windows.Forms.TextBox tBoxResultFac;
        private System.Windows.Forms.Button buttonCalculateFac;
        private System.Windows.Forms.TextBox tBoxFacInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBoxCLC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbxIntResult;
        private System.Windows.Forms.Button btnCalcInterest;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbxIntRate;
        private System.Windows.Forms.Label lblIntRate;
        private System.Windows.Forms.TextBox tbxLoanAmount;
        private System.Windows.Forms.Label lblLoanAmount;
    }
}

