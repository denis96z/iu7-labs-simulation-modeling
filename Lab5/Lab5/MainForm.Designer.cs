namespace Lab5
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
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.tbTimeInterval = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblReqHandled = new System.Windows.Forms.Label();
            this.lblReqDeclined = new System.Windows.Forms.Label();
            this.lblModellingTime = new System.Windows.Forms.Label();
            this.lblPDecline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(9, 9);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(117, 13);
            this.lblTimeInterval.TabIndex = 0;
            this.lblTimeInterval.Text = "Временной интервал:";
            // 
            // tbTimeInterval
            // 
            this.tbTimeInterval.Location = new System.Drawing.Point(132, 6);
            this.tbTimeInterval.Name = "tbTimeInterval";
            this.tbTimeInterval.Size = new System.Drawing.Size(140, 20);
            this.tbTimeInterval.TabIndex = 1;
            this.tbTimeInterval.Text = "0,01";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(85, 32);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(101, 23);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Моделировать";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblReqHandled
            // 
            this.lblReqHandled.AutoSize = true;
            this.lblReqHandled.Location = new System.Drawing.Point(9, 76);
            this.lblReqHandled.Name = "lblReqHandled";
            this.lblReqHandled.Size = new System.Drawing.Size(116, 13);
            this.lblReqHandled.TabIndex = 3;
            this.lblReqHandled.Text = "Обработано заявок: -";
            // 
            // lblReqDeclined
            // 
            this.lblReqDeclined.AutoSize = true;
            this.lblReqDeclined.Location = new System.Drawing.Point(9, 103);
            this.lblReqDeclined.Name = "lblReqDeclined";
            this.lblReqDeclined.Size = new System.Drawing.Size(110, 13);
            this.lblReqDeclined.TabIndex = 4;
            this.lblReqDeclined.Text = "Отклонено заявок: -";
            // 
            // lblModellingTime
            // 
            this.lblModellingTime.AutoSize = true;
            this.lblModellingTime.Location = new System.Drawing.Point(9, 130);
            this.lblModellingTime.Name = "lblModellingTime";
            this.lblModellingTime.Size = new System.Drawing.Size(132, 13);
            this.lblModellingTime.TabIndex = 5;
            this.lblModellingTime.Text = "Время моделирования: -";
            // 
            // lblPDecline
            // 
            this.lblPDecline.AutoSize = true;
            this.lblPDecline.Location = new System.Drawing.Point(9, 158);
            this.lblPDecline.Name = "lblPDecline";
            this.lblPDecline.Size = new System.Drawing.Size(119, 13);
            this.lblPDecline.TabIndex = 6;
            this.lblPDecline.Text = "Вероятность отказа: -";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.lblPDecline);
            this.Controls.Add(this.lblModellingTime);
            this.Controls.Add(this.lblReqDeclined);
            this.Controls.Add(this.lblReqHandled);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.tbTimeInterval);
            this.Controls.Add(this.lblTimeInterval);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeInterval;
        private System.Windows.Forms.TextBox tbTimeInterval;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblReqHandled;
        private System.Windows.Forms.Label lblReqDeclined;
        private System.Windows.Forms.Label lblModellingTime;
        private System.Windows.Forms.Label lblPDecline;
    }
}

