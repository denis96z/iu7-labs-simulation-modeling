namespace Lab4
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
            this.lblMethod = new System.Windows.Forms.Label();
            this.rbEvent = new System.Windows.Forms.RadioButton();
            this.rbDeltaT = new System.Windows.Forms.RadioButton();
            this.lblG = new System.Windows.Forms.Label();
            this.tbGm = new System.Windows.Forms.TextBox();
            this.tbGd = new System.Windows.Forms.TextBox();
            this.tbOAd = new System.Windows.Forms.TextBox();
            this.tbOAm = new System.Windows.Forms.TextBox();
            this.lblOA = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.lblOptQueueLen = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblDt = new System.Windows.Forms.Label();
            this.tbDt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(9, 9);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(42, 13);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Метод:";
            // 
            // rbEvent
            // 
            this.rbEvent.AutoSize = true;
            this.rbEvent.Location = new System.Drawing.Point(12, 48);
            this.rbEvent.Name = "rbEvent";
            this.rbEvent.Size = new System.Drawing.Size(89, 17);
            this.rbEvent.TabIndex = 1;
            this.rbEvent.Text = "Событийный";
            this.rbEvent.UseVisualStyleBackColor = true;
            this.rbEvent.CheckedChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // rbDeltaT
            // 
            this.rbDeltaT.AutoSize = true;
            this.rbDeltaT.Checked = true;
            this.rbDeltaT.Location = new System.Drawing.Point(12, 25);
            this.rbDeltaT.Name = "rbDeltaT";
            this.rbDeltaT.Size = new System.Drawing.Size(35, 17);
            this.rbDeltaT.TabIndex = 2;
            this.rbDeltaT.TabStop = true;
            this.rbDeltaT.Text = "Δt";
            this.rbDeltaT.UseVisualStyleBackColor = true;
            this.rbDeltaT.CheckedChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(9, 73);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(63, 13);
            this.lblG.TabIndex = 3;
            this.lblG.Text = "Генератор:";
            // 
            // tbGm
            // 
            this.tbGm.Location = new System.Drawing.Point(12, 89);
            this.tbGm.Name = "tbGm";
            this.tbGm.Size = new System.Drawing.Size(89, 20);
            this.tbGm.TabIndex = 4;
            this.tbGm.Text = "0";
            this.tbGm.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // tbGd
            // 
            this.tbGd.Location = new System.Drawing.Point(12, 115);
            this.tbGd.Name = "tbGd";
            this.tbGd.Size = new System.Drawing.Size(89, 20);
            this.tbGd.TabIndex = 5;
            this.tbGd.Text = "1";
            this.tbGd.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // tbOAd
            // 
            this.tbOAd.Location = new System.Drawing.Point(107, 115);
            this.tbOAd.Name = "tbOAd";
            this.tbOAd.Size = new System.Drawing.Size(89, 20);
            this.tbOAd.TabIndex = 8;
            this.tbOAd.Text = "1";
            this.tbOAd.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // tbOAm
            // 
            this.tbOAm.Location = new System.Drawing.Point(107, 89);
            this.tbOAm.Name = "tbOAm";
            this.tbOAm.Size = new System.Drawing.Size(89, 20);
            this.tbOAm.TabIndex = 7;
            this.tbOAm.Text = "0";
            this.tbOAm.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblOA
            // 
            this.lblOA.AutoSize = true;
            this.lblOA.Location = new System.Drawing.Point(104, 73);
            this.lblOA.Name = "lblOA";
            this.lblOA.Size = new System.Drawing.Size(25, 13);
            this.lblOA.TabIndex = 6;
            this.lblOA.Text = "ОА:";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(202, 26);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(122, 20);
            this.tbN.TabIndex = 12;
            this.tbN.Text = "1000";
            this.tbN.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(199, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(81, 13);
            this.lblN.TabIndex = 11;
            this.lblN.Text = "Число заявок:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(199, 73);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(125, 13);
            this.lblP.TabIndex = 13;
            this.lblP.Text = "Вероятность возврата:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(202, 89);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(122, 20);
            this.tbP.TabIndex = 14;
            this.tbP.Text = "0,2";
            this.tbP.TextChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblOptQueueLen
            // 
            this.lblOptQueueLen.AutoSize = true;
            this.lblOptQueueLen.Location = new System.Drawing.Point(124, 170);
            this.lblOptQueueLen.Name = "lblOptQueueLen";
            this.lblOptQueueLen.Size = new System.Drawing.Size(165, 13);
            this.lblOptQueueLen.TabIndex = 15;
            this.lblOptQueueLen.Text = "Оптимальная длина очереди: ?";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(21, 165);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(97, 23);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "Моделировать";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Location = new System.Drawing.Point(104, 9);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(92, 13);
            this.lblDt.TabIndex = 17;
            this.lblDt.Text = "Шаг по времени:";
            // 
            // tbDt
            // 
            this.tbDt.Location = new System.Drawing.Point(107, 26);
            this.tbDt.Name = "tbDt";
            this.tbDt.Size = new System.Drawing.Size(89, 20);
            this.tbDt.TabIndex = 18;
            this.tbDt.Text = "0,01";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 210);
            this.Controls.Add(this.tbDt);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.lblOptQueueLen);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.tbOAd);
            this.Controls.Add(this.tbOAm);
            this.Controls.Add(this.lblOA);
            this.Controls.Add(this.tbGd);
            this.Controls.Add(this.tbGm);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.rbDeltaT);
            this.Controls.Add(this.rbEvent);
            this.Controls.Add(this.lblMethod);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.RadioButton rbEvent;
        private System.Windows.Forms.RadioButton rbDeltaT;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox tbGm;
        private System.Windows.Forms.TextBox tbGd;
        private System.Windows.Forms.TextBox tbOAd;
        private System.Windows.Forms.TextBox tbOAm;
        private System.Windows.Forms.Label lblOA;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label lblOptQueueLen;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.TextBox tbDt;
    }
}

