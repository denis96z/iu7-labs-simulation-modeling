namespace Lab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tbNumConditions = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomFillTable = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lbSolution = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(172, 12);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(400, 337);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellEndEdit);
            // 
            // tbNumConditions
            // 
            this.tbNumConditions.Location = new System.Drawing.Point(8, 28);
            this.tbNumConditions.Maximum = 9;
            this.tbNumConditions.Minimum = 1;
            this.tbNumConditions.Name = "tbNumConditions";
            this.tbNumConditions.Size = new System.Drawing.Size(158, 45);
            this.tbNumConditions.TabIndex = 1;
            this.tbNumConditions.Value = 1;
            this.tbNumConditions.Scroll += new System.EventHandler(this.tbNumConditions_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число состояний:";
            // 
            // btnRandomFillTable
            // 
            this.btnRandomFillTable.Location = new System.Drawing.Point(15, 65);
            this.btnRandomFillTable.Name = "btnRandomFillTable";
            this.btnRandomFillTable.Size = new System.Drawing.Size(143, 23);
            this.btnRandomFillTable.TabIndex = 3;
            this.btnRandomFillTable.Text = "Заполнить сл. числами";
            this.btnRandomFillTable.UseVisualStyleBackColor = true;
            this.btnRandomFillTable.Click += new System.EventHandler(this.btnRandomFillTable_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(15, 94);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(143, 23);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Найти ср. отн. время";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lbSolution
            // 
            this.lbSolution.FormattingEnabled = true;
            this.lbSolution.Location = new System.Drawing.Point(15, 137);
            this.lbSolution.Name = "lbSolution";
            this.lbSolution.Size = new System.Drawing.Size(143, 212);
            this.lbSolution.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ср. отн. время:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSolution);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnRandomFillTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumConditions);
            this.Controls.Add(this.dgvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumConditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TrackBar tbNumConditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomFillTable;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox lbSolution;
        private System.Windows.Forms.Label label2;
    }
}

