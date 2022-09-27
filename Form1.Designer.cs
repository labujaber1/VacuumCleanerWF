
namespace VacuumCleanerWF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmbx_VacuumPosition = new System.Windows.Forms.ComboBox();
            this.Cmbx_DirtyRoom = new System.Windows.Forms.ComboBox();
            this.Btn_RunWF = new System.Windows.Forms.Button();
            this.Btn_RunConsole = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rtbx_ActionTextDisplay = new System.Windows.Forms.RichTextBox();
            this.Pbx_BDirty = new System.Windows.Forms.PictureBox();
            this.Pbx_ADirty = new System.Windows.Forms.PictureBox();
            this.Pbx_BVacuum = new System.Windows.Forms.PictureBox();
            this.Pbx_AVacuum = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BDirty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ADirty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BVacuum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_AVacuum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select vauum position a or b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the rooms that need cleaning";
            // 
            // Cmbx_VacuumPosition
            // 
            this.Cmbx_VacuumPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbx_VacuumPosition.FormattingEnabled = true;
            this.Cmbx_VacuumPosition.Items.AddRange(new object[] {
            "a",
            "b"});
            this.Cmbx_VacuumPosition.Location = new System.Drawing.Point(349, 6);
            this.Cmbx_VacuumPosition.Name = "Cmbx_VacuumPosition";
            this.Cmbx_VacuumPosition.Size = new System.Drawing.Size(182, 33);
            this.Cmbx_VacuumPosition.TabIndex = 2;
            this.Cmbx_VacuumPosition.SelectedIndexChanged += new System.EventHandler(this.Cmbx_VacuumPosition_SelectedIndexChanged);
            // 
            // Cmbx_DirtyRoom
            // 
            this.Cmbx_DirtyRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbx_DirtyRoom.FormattingEnabled = true;
            this.Cmbx_DirtyRoom.Items.AddRange(new object[] {
            "a",
            "b",
            "ab"});
            this.Cmbx_DirtyRoom.Location = new System.Drawing.Point(349, 59);
            this.Cmbx_DirtyRoom.Name = "Cmbx_DirtyRoom";
            this.Cmbx_DirtyRoom.Size = new System.Drawing.Size(182, 33);
            this.Cmbx_DirtyRoom.TabIndex = 3;
            this.Cmbx_DirtyRoom.SelectedIndexChanged += new System.EventHandler(this.Cmbx_DirtyRoom_SelectedIndexChanged);
            // 
            // Btn_RunWF
            // 
            this.Btn_RunWF.Location = new System.Drawing.Point(76, 419);
            this.Btn_RunWF.Name = "Btn_RunWF";
            this.Btn_RunWF.Size = new System.Drawing.Size(163, 66);
            this.Btn_RunWF.TabIndex = 4;
            this.Btn_RunWF.Text = "Run";
            this.Btn_RunWF.UseVisualStyleBackColor = true;
            this.Btn_RunWF.Click += new System.EventHandler(this.Btn_RunWF_Click);
            // 
            // Btn_RunConsole
            // 
            this.Btn_RunConsole.Location = new System.Drawing.Point(276, 419);
            this.Btn_RunConsole.Name = "Btn_RunConsole";
            this.Btn_RunConsole.Size = new System.Drawing.Size(163, 66);
            this.Btn_RunConsole.TabIndex = 5;
            this.Btn_RunConsole.Text = "Run console";
            this.Btn_RunConsole.UseVisualStyleBackColor = true;
            this.Btn_RunConsole.Click += new System.EventHandler(this.Btn_RunConsole_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(671, 419);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(92, 66);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.Rtbx_ActionTextDisplay);
            this.groupBox1.Controls.Add(this.Pbx_BDirty);
            this.groupBox1.Controls.Add(this.Pbx_ADirty);
            this.groupBox1.Controls.Add(this.Pbx_BVacuum);
            this.groupBox1.Controls.Add(this.Pbx_AVacuum);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 315);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual rep.";
            // 
            // Rtbx_ActionTextDisplay
            // 
            this.Rtbx_ActionTextDisplay.Location = new System.Drawing.Point(450, 30);
            this.Rtbx_ActionTextDisplay.Name = "Rtbx_ActionTextDisplay";
            this.Rtbx_ActionTextDisplay.ReadOnly = true;
            this.Rtbx_ActionTextDisplay.Size = new System.Drawing.Size(319, 268);
            this.Rtbx_ActionTextDisplay.TabIndex = 12;
            this.Rtbx_ActionTextDisplay.Text = "";
            // 
            // Pbx_BDirty
            // 
            this.Pbx_BDirty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pbx_BDirty.Image = global::VacuumCleanerWF.Properties.Resources.Dirty;
            this.Pbx_BDirty.Location = new System.Drawing.Point(243, 187);
            this.Pbx_BDirty.Name = "Pbx_BDirty";
            this.Pbx_BDirty.Size = new System.Drawing.Size(201, 69);
            this.Pbx_BDirty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_BDirty.TabIndex = 11;
            this.Pbx_BDirty.TabStop = false;
            this.Pbx_BDirty.Visible = false;
            // 
            // Pbx_ADirty
            // 
            this.Pbx_ADirty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pbx_ADirty.Image = global::VacuumCleanerWF.Properties.Resources.Dirty;
            this.Pbx_ADirty.Location = new System.Drawing.Point(21, 187);
            this.Pbx_ADirty.Name = "Pbx_ADirty";
            this.Pbx_ADirty.Size = new System.Drawing.Size(205, 69);
            this.Pbx_ADirty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_ADirty.TabIndex = 10;
            this.Pbx_ADirty.TabStop = false;
            this.Pbx_ADirty.Visible = false;
            // 
            // Pbx_BVacuum
            // 
            this.Pbx_BVacuum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Pbx_BVacuum.Image = global::VacuumCleanerWF.Properties.Resources.Vacuum;
            this.Pbx_BVacuum.Location = new System.Drawing.Point(243, 46);
            this.Pbx_BVacuum.Name = "Pbx_BVacuum";
            this.Pbx_BVacuum.Size = new System.Drawing.Size(201, 135);
            this.Pbx_BVacuum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_BVacuum.TabIndex = 9;
            this.Pbx_BVacuum.TabStop = false;
            this.Pbx_BVacuum.Visible = false;
            // 
            // Pbx_AVacuum
            // 
            this.Pbx_AVacuum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Pbx_AVacuum.Image = global::VacuumCleanerWF.Properties.Resources.Vacuum;
            this.Pbx_AVacuum.Location = new System.Drawing.Point(21, 46);
            this.Pbx_AVacuum.Name = "Pbx_AVacuum";
            this.Pbx_AVacuum.Size = new System.Drawing.Size(205, 135);
            this.Pbx_AVacuum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_AVacuum.TabIndex = 8;
            this.Pbx_AVacuum.TabStop = false;
            this.Pbx_AVacuum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_RunConsole);
            this.Controls.Add(this.Btn_RunWF);
            this.Controls.Add(this.Cmbx_DirtyRoom);
            this.Controls.Add(this.Cmbx_VacuumPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vacuum cleaner exercise";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BDirty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ADirty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BVacuum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_AVacuum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmbx_VacuumPosition;
        private System.Windows.Forms.ComboBox Cmbx_DirtyRoom;
        private System.Windows.Forms.Button Btn_RunWF;
        private System.Windows.Forms.Button Btn_RunConsole;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Pbx_BVacuum;
        private System.Windows.Forms.PictureBox Pbx_AVacuum;
        private System.Windows.Forms.PictureBox Pbx_BDirty;
        private System.Windows.Forms.PictureBox Pbx_ADirty;
        private System.Windows.Forms.RichTextBox Rtbx_ActionTextDisplay;
    }
}
