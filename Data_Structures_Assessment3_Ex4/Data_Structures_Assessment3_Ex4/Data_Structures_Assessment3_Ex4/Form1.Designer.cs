namespace Data_Structures_Assessment3_Ex4
{
    partial class frmFileExtensions
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
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindProgram = new System.Windows.Forms.Button();
            this.textBoxFindProgram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(437, 106);
            this.btnListAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(115, 28);
            this.btnListAll.TabIndex = 15;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click_1);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(88, 106);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(125, 28);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clear All Entries";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 53);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Current Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnFindProgram
            // 
            this.btnFindProgram.Location = new System.Drawing.Point(236, 106);
            this.btnFindProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindProgram.Name = "btnFindProgram";
            this.btnFindProgram.Size = new System.Drawing.Size(133, 28);
            this.btnFindProgram.TabIndex = 12;
            this.btnFindProgram.Text = "Find Default Program";
            this.btnFindProgram.UseVisualStyleBackColor = true;
            this.btnFindProgram.Click += new System.EventHandler(this.btnFindProgram_Click_1);
            // 
            // textBoxFindProgram
            // 
            this.textBoxFindProgram.Location = new System.Drawing.Point(236, 36);
            this.textBoxFindProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFindProgram.Name = "textBoxFindProgram";
            this.textBoxFindProgram.Size = new System.Drawing.Size(132, 22);
            this.textBoxFindProgram.TabIndex = 11;
            this.textBoxFindProgram.Text = "File Extensions";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter File Exteension";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtProgram);
            this.groupBox2.Controls.Add(this.txtExtension);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(655, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(313, 247);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit File Exteension Defaults";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 175);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(133, 106);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(132, 22);
            this.txtProgram.TabIndex = 3;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(133, 42);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(132, 22);
            this.txtExtension.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extension";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDisplay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(560, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Extension Default Program";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(28, 23);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(212, 232);
            this.txtDisplay.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnClearAll);
            this.groupBox3.Location = new System.Drawing.Point(655, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(313, 142);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Entry";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxFindProgram);
            this.groupBox4.Controls.Add(this.btnListAll);
            this.groupBox4.Controls.Add(this.btnFindProgram);
            this.groupBox4.Location = new System.Drawing.Point(56, 402);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(560, 142);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find Default Program";
            // 
            // frmFileExtensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFileExtensions";
            this.Text = "File Extensions";
            
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindProgram;
        private System.Windows.Forms.TextBox textBoxFindProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

