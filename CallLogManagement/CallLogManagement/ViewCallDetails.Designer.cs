namespace CallLogManagement
{
    partial class ViewCallDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgName,
            this.dgFatherName,
            this.dgTime,
            this.dgAddress,
            this.dgMobile,
            this.dgDate,
            this.dgDuration,
            this.dgRemarks,
            this.dgStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(823, 397);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No.";
            this.dgSno.Name = "dgSno";
            this.dgSno.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgFatherName
            // 
            this.dgFatherName.HeaderText = "FatherName";
            this.dgFatherName.Name = "dgFatherName";
            this.dgFatherName.ReadOnly = true;
            // 
            // dgTime
            // 
            this.dgTime.HeaderText = "Time";
            this.dgTime.Name = "dgTime";
            this.dgTime.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            this.dgAddress.Width = 150;
            // 
            // dgMobile
            // 
            this.dgMobile.HeaderText = "Mobile";
            this.dgMobile.Name = "dgMobile";
            this.dgMobile.ReadOnly = true;
            // 
            // dgDate
            // 
            this.dgDate.HeaderText = "Date ";
            this.dgDate.Name = "dgDate";
            this.dgDate.ReadOnly = true;
            // 
            // dgDuration
            // 
            this.dgDuration.HeaderText = "Duration";
            this.dgDuration.Name = "dgDuration";
            this.dgDuration.ReadOnly = true;
            // 
            // dgRemarks
            // 
            this.dgRemarks.HeaderText = "Remarks";
            this.dgRemarks.Name = "dgRemarks";
            this.dgRemarks.ReadOnly = true;
            // 
            // dgStatus
            // 
            this.dgStatus.HeaderText = "Status";
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.ReadOnly = true;
            // 
            // ViewCallDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ViewCallDetails";
            this.Text = "ViewCallDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
    }
}