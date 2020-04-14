namespace UsersTestApp_BigQuery
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
            this.Button_ImportDataToDatabase = new System.Windows.Forms.Button();
            this.Button_Select = new System.Windows.Forms.Button();
            this.Button_CreateDataset = new System.Windows.Forms.Button();
            this.TextBox_DatasetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SelectReplace = new System.Windows.Forms.Button();
            this.Button_SelectExcept = new System.Windows.Forms.Button();
            this.Button_SelectLimit = new System.Windows.Forms.Button();
            this.Button_SelectSample = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_SelectQualify = new System.Windows.Forms.Button();
            this.Button_SelectNotEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ImportDataToDatabase
            // 
            this.Button_ImportDataToDatabase.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_ImportDataToDatabase.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_ImportDataToDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_ImportDataToDatabase.Location = new System.Drawing.Point(541, 811);
            this.Button_ImportDataToDatabase.Name = "Button_ImportDataToDatabase";
            this.Button_ImportDataToDatabase.Size = new System.Drawing.Size(221, 78);
            this.Button_ImportDataToDatabase.TabIndex = 0;
            this.Button_ImportDataToDatabase.Text = "Import datata to database";
            this.Button_ImportDataToDatabase.UseVisualStyleBackColor = false;
            this.Button_ImportDataToDatabase.Click += new System.EventHandler(this.Button_ImportDataToDatabase_Click);
            // 
            // Button_Select
            // 
            this.Button_Select.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_Select.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_Select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_Select.Location = new System.Drawing.Point(101, 206);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new System.Drawing.Size(221, 78);
            this.Button_Select.TabIndex = 1;
            this.Button_Select.Text = "Test Select";
            this.Button_Select.UseVisualStyleBackColor = false;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // Button_CreateDataset
            // 
            this.Button_CreateDataset.Location = new System.Drawing.Point(802, 811);
            this.Button_CreateDataset.Name = "Button_CreateDataset";
            this.Button_CreateDataset.Size = new System.Drawing.Size(221, 78);
            this.Button_CreateDataset.TabIndex = 2;
            this.Button_CreateDataset.Text = "Create Dataset";
            this.Button_CreateDataset.UseVisualStyleBackColor = true;
            this.Button_CreateDataset.Click += new System.EventHandler(this.Button_CreateDataset_Click);
            // 
            // TextBox_DatasetName
            // 
            this.TextBox_DatasetName.Location = new System.Drawing.Point(802, 742);
            this.TextBox_DatasetName.Name = "TextBox_DatasetName";
            this.TextBox_DatasetName.Size = new System.Drawing.Size(221, 22);
            this.TextBox_DatasetName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dataset name";
            // 
            // Button_SelectReplace
            // 
            this.Button_SelectReplace.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_SelectReplace.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectReplace.Location = new System.Drawing.Point(359, 206);
            this.Button_SelectReplace.Name = "Button_SelectReplace";
            this.Button_SelectReplace.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectReplace.TabIndex = 5;
            this.Button_SelectReplace.Text = "Select * Replace";
            this.Button_SelectReplace.UseVisualStyleBackColor = false;
            this.Button_SelectReplace.Click += new System.EventHandler(this.Button_SelectReplace_Click);
            // 
            // Button_SelectExcept
            // 
            this.Button_SelectExcept.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_SelectExcept.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectExcept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectExcept.Location = new System.Drawing.Point(359, 324);
            this.Button_SelectExcept.Name = "Button_SelectExcept";
            this.Button_SelectExcept.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectExcept.TabIndex = 6;
            this.Button_SelectExcept.Text = "Select * Except";
            this.Button_SelectExcept.UseVisualStyleBackColor = false;
            this.Button_SelectExcept.Click += new System.EventHandler(this.Button_SelectExcept_Click);
            // 
            // Button_SelectLimit
            // 
            this.Button_SelectLimit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_SelectLimit.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectLimit.Location = new System.Drawing.Point(101, 324);
            this.Button_SelectLimit.Name = "Button_SelectLimit";
            this.Button_SelectLimit.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectLimit.TabIndex = 7;
            this.Button_SelectLimit.Text = "Select * Limit";
            this.Button_SelectLimit.UseVisualStyleBackColor = false;
            this.Button_SelectLimit.Click += new System.EventHandler(this.Button_SelectLimit_Click);
            // 
            // Button_SelectSample
            // 
            this.Button_SelectSample.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_SelectSample.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectSample.Location = new System.Drawing.Point(359, 522);
            this.Button_SelectSample.Name = "Button_SelectSample";
            this.Button_SelectSample.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectSample.TabIndex = 8;
            this.Button_SelectSample.Text = "Select * Sample";
            this.Button_SelectSample.UseVisualStyleBackColor = false;
            this.Button_SelectSample.Click += new System.EventHandler(this.Button_SelectSample_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.78151F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(917, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Test Queries For Google Big Query non-standart selects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.96639F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(555, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Working with database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.96639F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Non-standard selects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.96639F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(660, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Standard Selects to replicate non-standard";
            // 
            // Button_SelectQualify
            // 
            this.Button_SelectQualify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_SelectQualify.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectQualify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectQualify.Location = new System.Drawing.Point(101, 522);
            this.Button_SelectQualify.Name = "Button_SelectQualify";
            this.Button_SelectQualify.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectQualify.TabIndex = 13;
            this.Button_SelectQualify.Text = "Select * Qualify";
            this.Button_SelectQualify.UseVisualStyleBackColor = false;
            this.Button_SelectQualify.Click += new System.EventHandler(this.Button_SelectQualify_Click);
            // 
            // Button_SelectNotEqual
            // 
            this.Button_SelectNotEqual.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_SelectNotEqual.Font = new System.Drawing.Font("Open Sans SemiBold", 7.865546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Button_SelectNotEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_SelectNotEqual.Location = new System.Drawing.Point(101, 636);
            this.Button_SelectNotEqual.Name = "Button_SelectNotEqual";
            this.Button_SelectNotEqual.Size = new System.Drawing.Size(221, 78);
            this.Button_SelectNotEqual.TabIndex = 14;
            this.Button_SelectNotEqual.Text = "Select Not Equal";
            this.Button_SelectNotEqual.UseVisualStyleBackColor = false;
            this.Button_SelectNotEqual.Click += new System.EventHandler(this.Button_SelectNotEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1062, 1056);
            this.Controls.Add(this.Button_SelectNotEqual);
            this.Controls.Add(this.Button_SelectQualify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_SelectSample);
            this.Controls.Add(this.Button_SelectLimit);
            this.Controls.Add(this.Button_SelectExcept);
            this.Controls.Add(this.Button_SelectReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_DatasetName);
            this.Controls.Add(this.Button_CreateDataset);
            this.Controls.Add(this.Button_Select);
            this.Controls.Add(this.Button_ImportDataToDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ImportDataToDatabase;
        private System.Windows.Forms.Button Button_Select;
        private System.Windows.Forms.Button Button_CreateDataset;
        private System.Windows.Forms.TextBox TextBox_DatasetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_SelectReplace;
        private System.Windows.Forms.Button Button_SelectExcept;
        private System.Windows.Forms.Button Button_SelectLimit;
        private System.Windows.Forms.Button Button_SelectSample;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_SelectQualify;
        private System.Windows.Forms.Button Button_SelectNotEqual;
    }
}

