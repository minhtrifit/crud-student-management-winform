namespace CRUD_Student
{
    partial class Management
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.inputSex = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.studentView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AGE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(315, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(284, 33);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "QUẢN LÝ HỌC SINH";
            this.mainTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(149, 84);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(212, 29);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Mã Số Sinh Viên:";
            // 
            // inputId
            // 
            this.inputId.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputId.Location = new System.Drawing.Point(387, 81);
            this.inputId.Margin = new System.Windows.Forms.Padding(33, 5, 5, 5);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(374, 36);
            this.inputId.TabIndex = 6;
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(387, 143);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(374, 36);
            this.inputName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(149, 146);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(143, 29);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Họ Và Tên:";
            this.labelName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // inputAge
            // 
            this.inputAge.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAge.Location = new System.Drawing.Point(387, 207);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(374, 36);
            this.inputAge.TabIndex = 10;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(149, 210);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(74, 29);
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Tuổi:";
            // 
            // inputSex
            // 
            this.inputSex.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSex.Location = new System.Drawing.Point(387, 272);
            this.inputSex.Name = "inputSex";
            this.inputSex.Size = new System.Drawing.Size(374, 36);
            this.inputSex.TabIndex = 12;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(149, 275);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(123, 29);
            this.labelSex.TabIndex = 11;
            this.labelSex.Text = "Giới tính:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(214, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 49);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(387, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 49);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(559, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 49);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // studentView
            // 
            this.studentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME,
            this.AGE,
            this.SEX});
            this.studentView.HideSelection = false;
            this.studentView.Location = new System.Drawing.Point(154, 452);
            this.studentView.Name = "studentView";
            this.studentView.Size = new System.Drawing.Size(607, 97);
            this.studentView.TabIndex = 16;
            this.studentView.UseCompatibleStateImageBehavior = false;
            this.studentView.View = System.Windows.Forms.View.Details;
            this.studentView.SelectedIndexChanged += new System.EventHandler(this.studentView_SelectedIndexChanged);
            this.studentView.Click += new System.EventHandler(this.studentView_Click_1);
            // 
            // ID
            // 
            this.ID.Width = 120;
            // 
            // NAME
            // 
            this.NAME.Width = 120;
            // 
            // AGE
            // 
            this.AGE.Width = 120;
            // 
            // SEX
            // 
            this.SEX.Width = 120;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(703, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(195, 49);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "ĐĂNG XUẤT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(923, 582);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.studentView);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputSex);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.mainTitle);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox inputSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView studentView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader AGE;
        private System.Windows.Forms.ColumnHeader SEX;
        private System.Windows.Forms.Button btnLogOut;
    }
}

