
namespace TicTacToe
{
    partial class formTicTacToe
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
            this.labelGameStatus = new System.Windows.Forms.Label();
            this.buttonRow0Column0 = new System.Windows.Forms.Button();
            this.buttonRow0Column1 = new System.Windows.Forms.Button();
            this.buttonRow0Column2 = new System.Windows.Forms.Button();
            this.buttonRow1Column0 = new System.Windows.Forms.Button();
            this.buttonRow1Column1 = new System.Windows.Forms.Button();
            this.buttonRow1Column2 = new System.Windows.Forms.Button();
            this.buttonRow2Column0 = new System.Windows.Forms.Button();
            this.buttonRow2Column1 = new System.Windows.Forms.Button();
            this.buttonRow2Column2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameStatus
            // 
            this.labelGameStatus.Location = new System.Drawing.Point(14, 24);
            this.labelGameStatus.Name = "labelGameStatus";
            this.labelGameStatus.Size = new System.Drawing.Size(164, 23);
            this.labelGameStatus.TabIndex = 0;
            this.labelGameStatus.Text = "X\'s Turn";
            this.labelGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRow0Column0
            // 
            this.buttonRow0Column0.Location = new System.Drawing.Point(14, 50);
            this.buttonRow0Column0.Name = "buttonRow0Column0";
            this.buttonRow0Column0.Size = new System.Drawing.Size(50, 50);
            this.buttonRow0Column0.TabIndex = 1;
            this.buttonRow0Column0.UseVisualStyleBackColor = true;
            this.buttonRow0Column0.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow0Column1
            // 
            this.buttonRow0Column1.Location = new System.Drawing.Point(71, 50);
            this.buttonRow0Column1.Name = "buttonRow0Column1";
            this.buttonRow0Column1.Size = new System.Drawing.Size(50, 50);
            this.buttonRow0Column1.TabIndex = 2;
            this.buttonRow0Column1.UseVisualStyleBackColor = true;
            this.buttonRow0Column1.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow0Column2
            // 
            this.buttonRow0Column2.Location = new System.Drawing.Point(128, 50);
            this.buttonRow0Column2.Name = "buttonRow0Column2";
            this.buttonRow0Column2.Size = new System.Drawing.Size(50, 50);
            this.buttonRow0Column2.TabIndex = 3;
            this.buttonRow0Column2.UseVisualStyleBackColor = true;
            this.buttonRow0Column2.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow1Column0
            // 
            this.buttonRow1Column0.Location = new System.Drawing.Point(14, 106);
            this.buttonRow1Column0.Name = "buttonRow1Column0";
            this.buttonRow1Column0.Size = new System.Drawing.Size(50, 50);
            this.buttonRow1Column0.TabIndex = 4;
            this.buttonRow1Column0.UseVisualStyleBackColor = true;
            this.buttonRow1Column0.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow1Column1
            // 
            this.buttonRow1Column1.Location = new System.Drawing.Point(71, 106);
            this.buttonRow1Column1.Name = "buttonRow1Column1";
            this.buttonRow1Column1.Size = new System.Drawing.Size(50, 50);
            this.buttonRow1Column1.TabIndex = 5;
            this.buttonRow1Column1.UseVisualStyleBackColor = true;
            this.buttonRow1Column1.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow1Column2
            // 
            this.buttonRow1Column2.Location = new System.Drawing.Point(128, 106);
            this.buttonRow1Column2.Name = "buttonRow1Column2";
            this.buttonRow1Column2.Size = new System.Drawing.Size(50, 50);
            this.buttonRow1Column2.TabIndex = 6;
            this.buttonRow1Column2.UseVisualStyleBackColor = true;
            this.buttonRow1Column2.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow2Column0
            // 
            this.buttonRow2Column0.Location = new System.Drawing.Point(14, 162);
            this.buttonRow2Column0.Name = "buttonRow2Column0";
            this.buttonRow2Column0.Size = new System.Drawing.Size(50, 50);
            this.buttonRow2Column0.TabIndex = 7;
            this.buttonRow2Column0.UseVisualStyleBackColor = true;
            this.buttonRow2Column0.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow2Column1
            // 
            this.buttonRow2Column1.Location = new System.Drawing.Point(71, 162);
            this.buttonRow2Column1.Name = "buttonRow2Column1";
            this.buttonRow2Column1.Size = new System.Drawing.Size(50, 50);
            this.buttonRow2Column1.TabIndex = 8;
            this.buttonRow2Column1.UseVisualStyleBackColor = true;
            this.buttonRow2Column1.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonRow2Column2
            // 
            this.buttonRow2Column2.Location = new System.Drawing.Point(128, 162);
            this.buttonRow2Column2.Name = "buttonRow2Column2";
            this.buttonRow2Column2.Size = new System.Drawing.Size(50, 50);
            this.buttonRow2Column2.TabIndex = 9;
            this.buttonRow2Column2.UseVisualStyleBackColor = true;
            this.buttonRow2Column2.Click += new System.EventHandler(this.TicTacToeSquareClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(14, 228);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(164, 28);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset Game";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // formTicTacToe
            // 
            this.AcceptButton = this.buttonRow1Column1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(192, 283);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRow2Column2);
            this.Controls.Add(this.buttonRow2Column1);
            this.Controls.Add(this.buttonRow2Column0);
            this.Controls.Add(this.buttonRow1Column2);
            this.Controls.Add(this.buttonRow1Column1);
            this.Controls.Add(this.buttonRow1Column0);
            this.Controls.Add(this.buttonRow0Column2);
            this.Controls.Add(this.buttonRow0Column1);
            this.Controls.Add(this.buttonRow0Column0);
            this.Controls.Add(this.labelGameStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGameStatus;
        private System.Windows.Forms.Button buttonRow0Column0;
        private System.Windows.Forms.Button buttonRow0Column1;
        private System.Windows.Forms.Button buttonRow0Column2;
        private System.Windows.Forms.Button buttonRow1Column0;
        private System.Windows.Forms.Button buttonRow1Column1;
        private System.Windows.Forms.Button buttonRow1Column2;
        private System.Windows.Forms.Button buttonRow2Column0;
        private System.Windows.Forms.Button buttonRow2Column1;
        private System.Windows.Forms.Button buttonRow2Column2;
        private System.Windows.Forms.Button buttonReset;
    }
}

