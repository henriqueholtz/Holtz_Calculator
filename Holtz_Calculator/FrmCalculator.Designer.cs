namespace Holtz_Calculator
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnMore = new System.Windows.Forms.Button();
            this.BtnLower = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnComma = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnTrue = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnShare = new System.Windows.Forms.Button();
            this.BtnPorcentage = new System.Windows.Forms.Button();
            this.BtnDoubleZero = new System.Windows.Forms.Button();
            this.BtnSound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(372, 65);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.Text = "0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Location = new System.Drawing.Point(332, 174);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(54, 86);
            this.BtnEqual.TabIndex = 1;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnMore
            // 
            this.BtnMore.Location = new System.Drawing.Point(285, 221);
            this.BtnMore.Name = "BtnMore";
            this.BtnMore.Size = new System.Drawing.Size(41, 39);
            this.BtnMore.TabIndex = 2;
            this.BtnMore.Text = "+";
            this.BtnMore.UseVisualStyleBackColor = true;
            this.BtnMore.Click += new System.EventHandler(this.BtnMore_Click);
            // 
            // BtnLower
            // 
            this.BtnLower.Location = new System.Drawing.Point(285, 174);
            this.BtnLower.Name = "BtnLower";
            this.BtnLower.Size = new System.Drawing.Size(41, 39);
            this.BtnLower.TabIndex = 3;
            this.BtnLower.Text = "-";
            this.BtnLower.UseVisualStyleBackColor = true;
            this.BtnLower.Click += new System.EventHandler(this.BtnLower_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.Location = new System.Drawing.Point(14, 237);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(75, 23);
            this.BtnZero.TabIndex = 4;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Location = new System.Drawing.Point(14, 203);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(75, 23);
            this.BtnOne.TabIndex = 5;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Location = new System.Drawing.Point(14, 174);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(75, 23);
            this.BtnFour.TabIndex = 6;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Location = new System.Drawing.Point(14, 145);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(75, 23);
            this.BtnSeven.TabIndex = 7;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(14, 114);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(169, 25);
            this.BtnClean.TabIndex = 8;
            this.BtnClean.Text = "<--";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnComma
            // 
            this.BtnComma.Location = new System.Drawing.Point(200, 236);
            this.BtnComma.Name = "BtnComma";
            this.BtnComma.Size = new System.Drawing.Size(77, 23);
            this.BtnComma.TabIndex = 9;
            this.BtnComma.Text = ",";
            this.BtnComma.UseVisualStyleBackColor = true;
            this.BtnComma.Click += new System.EventHandler(this.BtnComma_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(108, 203);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(75, 23);
            this.BtnTwo.TabIndex = 10;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnTrue
            // 
            this.BtnTrue.Location = new System.Drawing.Point(202, 203);
            this.BtnTrue.Name = "BtnTrue";
            this.BtnTrue.Size = new System.Drawing.Size(75, 23);
            this.BtnTrue.TabIndex = 11;
            this.BtnTrue.Text = "3";
            this.BtnTrue.UseVisualStyleBackColor = true;
            this.BtnTrue.Click += new System.EventHandler(this.BtnTrue_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Location = new System.Drawing.Point(108, 173);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(75, 23);
            this.BtnFive.TabIndex = 12;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Location = new System.Drawing.Point(202, 173);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(75, 23);
            this.BtnSix.TabIndex = 13;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Location = new System.Drawing.Point(108, 144);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(75, 23);
            this.BtnEight.TabIndex = 14;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Location = new System.Drawing.Point(202, 144);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(75, 23);
            this.BtnNine.TabIndex = 15;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(285, 129);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(41, 39);
            this.BtnMultiply.TabIndex = 16;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            // 
            // BtnShare
            // 
            this.BtnShare.Location = new System.Drawing.Point(285, 83);
            this.BtnShare.Name = "BtnShare";
            this.BtnShare.Size = new System.Drawing.Size(41, 39);
            this.BtnShare.TabIndex = 17;
            this.BtnShare.Text = "/";
            this.BtnShare.UseVisualStyleBackColor = true;
            // 
            // BtnPorcentage
            // 
            this.BtnPorcentage.Location = new System.Drawing.Point(335, 129);
            this.BtnPorcentage.Name = "BtnPorcentage";
            this.BtnPorcentage.Size = new System.Drawing.Size(41, 39);
            this.BtnPorcentage.TabIndex = 18;
            this.BtnPorcentage.Text = "%";
            this.BtnPorcentage.UseVisualStyleBackColor = true;
            // 
            // BtnDoubleZero
            // 
            this.BtnDoubleZero.Location = new System.Drawing.Point(108, 236);
            this.BtnDoubleZero.Name = "BtnDoubleZero";
            this.BtnDoubleZero.Size = new System.Drawing.Size(75, 23);
            this.BtnDoubleZero.TabIndex = 20;
            this.BtnDoubleZero.Text = "00";
            this.BtnDoubleZero.UseVisualStyleBackColor = true;
            this.BtnDoubleZero.Click += new System.EventHandler(this.BtnDoubleZero_Click);
            // 
            // BtnSound
            // 
            this.BtnSound.BackgroundImage = global::Holtz_Calculator.Properties.Resources.sound_on_icon_icons_com_53883;
            this.BtnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSound.Location = new System.Drawing.Point(14, 84);
            this.BtnSound.Name = "BtnSound";
            this.BtnSound.Size = new System.Drawing.Size(75, 23);
            this.BtnSound.TabIndex = 21;
            this.BtnSound.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Holtz_Calculator.Properties.Resources.square_root_box_icon_137155;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(335, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 269);
            this.Controls.Add(this.BtnSound);
            this.Controls.Add(this.BtnDoubleZero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPorcentage);
            this.Controls.Add(this.BtnShare);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnTrue);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnComma);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnLower);
            this.Controls.Add(this.BtnMore);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.txtVisor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCalculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnMore;
        private System.Windows.Forms.Button BtnLower;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnComma;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnTrue;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnShare;
        private System.Windows.Forms.Button BtnPorcentage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDoubleZero;
        private System.Windows.Forms.Button BtnSound;
    }
}

