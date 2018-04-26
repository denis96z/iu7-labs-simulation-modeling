namespace Lab3
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
            this.btnFillTable = new System.Windows.Forms.Button();
            this.btnEstimateRandomness = new System.Windows.Forms.Button();
            this.tbSequenceLength = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSequenceLength)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 12);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(760, 486);
            this.dgvTable.TabIndex = 0;
            // 
            // btnFillTable
            // 
            this.btnFillTable.Location = new System.Drawing.Point(616, 504);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(75, 23);
            this.btnFillTable.TabIndex = 1;
            this.btnFillTable.Text = "Заполнить";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // btnEstimateRandomness
            // 
            this.btnEstimateRandomness.Location = new System.Drawing.Point(697, 504);
            this.btnEstimateRandomness.Name = "btnEstimateRandomness";
            this.btnEstimateRandomness.Size = new System.Drawing.Size(75, 23);
            this.btnEstimateRandomness.TabIndex = 2;
            this.btnEstimateRandomness.Text = "Рассчет";
            this.btnEstimateRandomness.UseVisualStyleBackColor = true;
            this.btnEstimateRandomness.Click += new System.EventHandler(this.btnEstimateRandomness_Click);
            // 
            // tbSequenceLength
            // 
            this.tbSequenceLength.Location = new System.Drawing.Point(12, 504);
            this.tbSequenceLength.Maximum = 100;
            this.tbSequenceLength.Minimum = 1;
            this.tbSequenceLength.Name = "tbSequenceLength";
            this.tbSequenceLength.Size = new System.Drawing.Size(598, 45);
            this.tbSequenceLength.TabIndex = 3;
            this.tbSequenceLength.Value = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbSequenceLength);
            this.Controls.Add(this.btnEstimateRandomness);
            this.Controls.Add(this.btnFillTable);
            this.Controls.Add(this.dgvTable);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSequenceLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.Button btnEstimateRandomness;
        private System.Windows.Forms.TrackBar tbSequenceLength;
    }
}

