﻿namespace CSharpInClassWeek8
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
            this.lbNumberList = new System.Windows.Forms.ListBox();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.btnClearNumbers = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lbNameList = new System.Windows.Forms.ListBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnClearNames = new System.Windows.Forms.Button();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.lblTextBoxPrompt = new System.Windows.Forms.Label();
            this.btnWriteNumbers = new System.Windows.Forms.Button();
            this.btnReadNumbers = new System.Windows.Forms.Button();
            this.tbCheckName = new System.Windows.Forms.TextBox();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumberList
            // 
            this.lbNumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberList.FormattingEnabled = true;
            this.lbNumberList.ItemHeight = 24;
            this.lbNumberList.Location = new System.Drawing.Point(12, 12);
            this.lbNumberList.Name = "lbNumberList";
            this.lbNumberList.Size = new System.Drawing.Size(171, 268);
            this.lbNumberList.TabIndex = 0;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(303, 344);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(75, 23);
            this.btnExitProgram.TabIndex = 1;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // btnClearNumbers
            // 
            this.btnClearNumbers.Location = new System.Drawing.Point(108, 286);
            this.btnClearNumbers.Name = "btnClearNumbers";
            this.btnClearNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnClearNumbers.TabIndex = 2;
            this.btnClearNumbers.Text = "Clear Box";
            this.btnClearNumbers.UseVisualStyleBackColor = true;
            this.btnClearNumbers.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 286);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 3;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lbNameList
            // 
            this.lbNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameList.FormattingEnabled = true;
            this.lbNameList.ItemHeight = 24;
            this.lbNameList.Location = new System.Drawing.Point(189, 12);
            this.lbNameList.Name = "lbNameList";
            this.lbNameList.Size = new System.Drawing.Size(189, 220);
            this.lbNameList.TabIndex = 4;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(189, 286);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 5;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnClearNames
            // 
            this.btnClearNames.Location = new System.Drawing.Point(303, 286);
            this.btnClearNames.Name = "btnClearNames";
            this.btnClearNames.Size = new System.Drawing.Size(75, 23);
            this.btnClearNames.TabIndex = 6;
            this.btnClearNames.Text = "Clear Box";
            this.btnClearNames.UseVisualStyleBackColor = true;
            // 
            // tbEnterName
            // 
            this.tbEnterName.Location = new System.Drawing.Point(189, 260);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(189, 20);
            this.tbEnterName.TabIndex = 7;
            // 
            // lblTextBoxPrompt
            // 
            this.lblTextBoxPrompt.AutoSize = true;
            this.lblTextBoxPrompt.Location = new System.Drawing.Point(240, 244);
            this.lblTextBoxPrompt.Name = "lblTextBoxPrompt";
            this.lblTextBoxPrompt.Size = new System.Drawing.Size(98, 13);
            this.lblTextBoxPrompt.TabIndex = 8;
            this.lblTextBoxPrompt.Text = "Enter Name Below:";
            // 
            // btnWriteNumbers
            // 
            this.btnWriteNumbers.Location = new System.Drawing.Point(12, 315);
            this.btnWriteNumbers.Name = "btnWriteNumbers";
            this.btnWriteNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnWriteNumbers.TabIndex = 11;
            this.btnWriteNumbers.Text = "Write File";
            this.btnWriteNumbers.UseVisualStyleBackColor = true;
            this.btnWriteNumbers.Click += new System.EventHandler(this.btnWriteNumbers_Click);
            // 
            // btnReadNumbers
            // 
            this.btnReadNumbers.Location = new System.Drawing.Point(108, 315);
            this.btnReadNumbers.Name = "btnReadNumbers";
            this.btnReadNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnReadNumbers.TabIndex = 12;
            this.btnReadNumbers.Text = "Read File";
            this.btnReadNumbers.UseVisualStyleBackColor = true;
            this.btnReadNumbers.Click += new System.EventHandler(this.btnReadNumbers_Click);
            // 
            // tbCheckName
            // 
            this.tbCheckName.Location = new System.Drawing.Point(189, 315);
            this.tbCheckName.Name = "tbCheckName";
            this.tbCheckName.Size = new System.Drawing.Size(187, 20);
            this.tbCheckName.TabIndex = 13;
            // 
            // btnCheckName
            // 
            this.btnCheckName.Location = new System.Drawing.Point(189, 344);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(108, 23);
            this.btnCheckName.TabIndex = 14;
            this.btnCheckName.Text = "Check For Name";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 374);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.tbCheckName);
            this.Controls.Add(this.btnReadNumbers);
            this.Controls.Add(this.btnWriteNumbers);
            this.Controls.Add(this.lblTextBoxPrompt);
            this.Controls.Add(this.tbEnterName);
            this.Controls.Add(this.btnClearNames);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lbNameList);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnClearNumbers);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.lbNumberList);
            this.Name = "Form1";
            this.Text = "Some Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumberList;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Button btnClearNumbers;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lbNameList;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnClearNames;
        private System.Windows.Forms.TextBox tbEnterName;
        private System.Windows.Forms.Label lblTextBoxPrompt;
        private System.Windows.Forms.Button btnWriteNumbers;
        private System.Windows.Forms.Button btnReadNumbers;
        private System.Windows.Forms.TextBox tbCheckName;
        private System.Windows.Forms.Button btnCheckName;
    }
}

