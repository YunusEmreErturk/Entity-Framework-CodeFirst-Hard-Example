namespace CodeFirst_MtoMRelation
{
    partial class FormRelationshipscs
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.dataGridViewRelations = new System.Windows.Forms.DataGridView();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.btnMakeRelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(291, 71);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStudents.Size = new System.Drawing.Size(175, 212);
            this.listBoxStudents.TabIndex = 0;
            // 
            // dataGridViewRelations
            // 
            this.dataGridViewRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelations.Location = new System.Drawing.Point(37, 71);
            this.dataGridViewRelations.Name = "dataGridViewRelations";
            this.dataGridViewRelations.Size = new System.Drawing.Size(219, 271);
            this.dataGridViewRelations.TabIndex = 1;
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(105, 23);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTeachers.TabIndex = 2;
         //   this.comboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachers_SelectedIndexChanged);
            this.comboBoxTeachers.TextChanged += new System.EventHandler(this.comboBoxTeachers_TextChanged);
            // 
            // btnMakeRelation
            // 
            this.btnMakeRelation.Location = new System.Drawing.Point(326, 305);
            this.btnMakeRelation.Name = "btnMakeRelation";
            this.btnMakeRelation.Size = new System.Drawing.Size(98, 37);
            this.btnMakeRelation.TabIndex = 3;
            this.btnMakeRelation.Text = "Add";
            this.btnMakeRelation.UseVisualStyleBackColor = true;
            this.btnMakeRelation.Click += new System.EventHandler(this.btnMakeRelation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // FormRelationshipscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeRelation);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.dataGridViewRelations);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "FormRelationshipscs";
            this.Text = "FormRelationshipscs";
            this.Load += new System.EventHandler(this.FormRelationshipscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.DataGridView dataGridViewRelations;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Button btnMakeRelation;
        private System.Windows.Forms.Label label1;
    }
}