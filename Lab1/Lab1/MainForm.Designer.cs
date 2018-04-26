namespace Lab1
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
            this.components = new System.ComponentModel.Container();
            this.tbMathExpectation = new System.Windows.Forms.TextBox();
            this.tbDispersion = new System.Windows.Forms.TextBox();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graphControl = new ZedGraph.ZedGraphControl();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMathExpectation
            // 
            this.tbMathExpectation.Location = new System.Drawing.Point(12, 25);
            this.tbMathExpectation.Name = "tbMathExpectation";
            this.tbMathExpectation.Size = new System.Drawing.Size(100, 20);
            this.tbMathExpectation.TabIndex = 0;
            this.tbMathExpectation.Text = "0";
            this.toolTip.SetToolTip(this.tbMathExpectation, "Математическое ожидание");
            // 
            // tbDispersion
            // 
            this.tbDispersion.Location = new System.Drawing.Point(12, 64);
            this.tbDispersion.Name = "tbDispersion";
            this.tbDispersion.Size = new System.Drawing.Size(100, 20);
            this.tbDispersion.TabIndex = 1;
            this.tbDispersion.Text = "1";
            this.toolTip.SetToolTip(this.tbDispersion, "Дисперсия");
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(11, 168);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(100, 23);
            this.btnDrawGraph.TabIndex = 2;
            this.btnDrawGraph.Text = "Построить";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мат. ожидание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дисперсия:";
            // 
            // graphControl
            // 
            this.graphControl.Location = new System.Drawing.Point(118, 9);
            this.graphControl.Name = "graphControl";
            this.graphControl.ScrollGrace = 0D;
            this.graphControl.ScrollMaxX = 0D;
            this.graphControl.ScrollMaxY = 0D;
            this.graphControl.ScrollMaxY2 = 0D;
            this.graphControl.ScrollMinX = 0D;
            this.graphControl.ScrollMinY = 0D;
            this.graphControl.ScrollMinY2 = 0D;
            this.graphControl.Size = new System.Drawing.Size(654, 540);
            this.graphControl.TabIndex = 6;
            this.graphControl.UseExtendedPrintDialog = true;
            // 
            // nudFrom
            // 
            this.nudFrom.Location = new System.Drawing.Point(11, 103);
            this.nudFrom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(99, 20);
            this.nudFrom.TabIndex = 7;
            this.nudFrom.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "До:";
            // 
            // nudTo
            // 
            this.nudTo.Location = new System.Drawing.Point(12, 142);
            this.nudTo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(99, 20);
            this.nudTo.TabIndex = 9;
            this.nudTo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.graphControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.tbDispersion);
            this.Controls.Add(this.tbMathExpectation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMathExpectation;
        private System.Windows.Forms.TextBox tbDispersion;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl graphControl;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTo;
    }
}

