namespace Lab6
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMinArrivalInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxArrivalInt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaxQueueLength = new System.Windows.Forms.TextBox();
            this.tbMinStyleTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxStyleTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMinDelay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxDelay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbClientHasStylistProb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNumStyles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNumStylists = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шаг по времени:";
            // 
            // tbTimeInterval
            // 
            this.tbTimeInterval.Location = new System.Drawing.Point(12, 25);
            this.tbTimeInterval.Name = "tbTimeInterval";
            this.tbTimeInterval.Size = new System.Drawing.Size(89, 20);
            this.tbTimeInterval.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальная длина очереди:";
            // 
            // tbMinArrivalInt
            // 
            this.tbMinArrivalInt.Location = new System.Drawing.Point(12, 64);
            this.tbMinArrivalInt.Name = "tbMinArrivalInt";
            this.tbMinArrivalInt.Size = new System.Drawing.Size(89, 20);
            this.tbMinArrivalInt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимальный интервал прибытия клиентов:";
            // 
            // tbMaxArrivalInt
            // 
            this.tbMaxArrivalInt.Location = new System.Drawing.Point(253, 64);
            this.tbMaxArrivalInt.Name = "tbMaxArrivalInt";
            this.tbMaxArrivalInt.Size = new System.Drawing.Size(89, 20);
            this.tbMaxArrivalInt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальный интервал прибытия клиентов:";
            // 
            // tbMaxQueueLength
            // 
            this.tbMaxQueueLength.Location = new System.Drawing.Point(253, 25);
            this.tbMaxQueueLength.Name = "tbMaxQueueLength";
            this.tbMaxQueueLength.Size = new System.Drawing.Size(89, 20);
            this.tbMaxQueueLength.TabIndex = 8;
            // 
            // tbMinStyleTime
            // 
            this.tbMinStyleTime.Location = new System.Drawing.Point(12, 103);
            this.tbMinStyleTime.Name = "tbMinStyleTime";
            this.tbMinStyleTime.Size = new System.Drawing.Size(89, 20);
            this.tbMinStyleTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Минимальное время на стрижку:";
            // 
            // tbMaxStyleTime
            // 
            this.tbMaxStyleTime.Location = new System.Drawing.Point(253, 103);
            this.tbMaxStyleTime.Name = "tbMaxStyleTime";
            this.tbMaxStyleTime.Size = new System.Drawing.Size(89, 20);
            this.tbMaxStyleTime.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Максимальное время на стрижку:";
            // 
            // tbMinDelay
            // 
            this.tbMinDelay.Location = new System.Drawing.Point(12, 142);
            this.tbMinDelay.Name = "tbMinDelay";
            this.tbMinDelay.Size = new System.Drawing.Size(89, 20);
            this.tbMinDelay.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Минимальная задержка:";
            // 
            // tbMaxDelay
            // 
            this.tbMaxDelay.Location = new System.Drawing.Point(253, 142);
            this.tbMaxDelay.Name = "tbMaxDelay";
            this.tbMaxDelay.Size = new System.Drawing.Size(89, 20);
            this.tbMaxDelay.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Максимальная задержка:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 331);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Результат";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(186, 296);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(98, 23);
            this.btnSimulate.TabIndex = 18;
            this.btnSimulate.Text = "Моделировать";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Время моделирования:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(12, 182);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(89, 20);
            this.tbTime.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Вероятность того, что клиент идет к определенному парикмахеру:";
            // 
            // tbClientHasStylistProb
            // 
            this.tbClientHasStylistProb.Location = new System.Drawing.Point(12, 221);
            this.tbClientHasStylistProb.Name = "tbClientHasStylistProb";
            this.tbClientHasStylistProb.Size = new System.Drawing.Size(89, 20);
            this.tbClientHasStylistProb.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Количество причесок:";
            // 
            // tbNumStyles
            // 
            this.tbNumStyles.Location = new System.Drawing.Point(12, 260);
            this.tbNumStyles.Name = "tbNumStyles";
            this.tbNumStyles.Size = new System.Drawing.Size(89, 20);
            this.tbNumStyles.TabIndex = 24;
            this.tbNumStyles.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Количество парикмахеров:";
            // 
            // tbNumStylists
            // 
            this.tbNumStylists.Location = new System.Drawing.Point(253, 260);
            this.tbNumStylists.Name = "tbNumStylists";
            this.tbNumStylists.Size = new System.Drawing.Size(89, 20);
            this.tbNumStylists.TabIndex = 26;
            this.tbNumStylists.Text = "4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 410);
            this.Controls.Add(this.tbNumStylists);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNumStyles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbClientHasStylistProb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbMaxDelay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMinDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMaxStyleTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMinStyleTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMaxQueueLength);
            this.Controls.Add(this.tbMaxArrivalInt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMinArrivalInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimeInterval);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №6 - Модель парикмахерской";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinArrivalInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxArrivalInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaxQueueLength;
        private System.Windows.Forms.TextBox tbMinStyleTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxStyleTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMinDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbClientHasStylistProb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNumStyles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNumStylists;
    }
}

