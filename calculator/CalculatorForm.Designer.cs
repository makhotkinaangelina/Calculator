namespace calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mminBtn = new System.Windows.Forms.Button();
            this.mplusBtn = new System.Windows.Forms.Button();
            this.mrBtn = new System.Windows.Forms.Button();
            this.mcBtn = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.num0Btn = new System.Windows.Forms.Button();
            this.kommaBtn = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.num1Btn = new System.Windows.Forms.Button();
            this.num2Btn = new System.Windows.Forms.Button();
            this.num3Btn = new System.Windows.Forms.Button();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.num4Btn = new System.Windows.Forms.Button();
            this.num5Btn = new System.Windows.Forms.Button();
            this.num6Btn = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.num7Btn = new System.Windows.Forms.Button();
            this.num8Btn = new System.Windows.Forms.Button();
            this.num9Btn = new System.Windows.Forms.Button();
            this.msBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyBtn = new System.Windows.Forms.Button();
            this.memoryBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plusBtn
            // 
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(30, 30);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(75, 39);
            this.plusBtn.TabIndex = 0;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.WriteSign);
            // 
            // minusBtn
            // 
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(143, 30);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(75, 39);
            this.minusBtn.TabIndex = 1;
            this.minusBtn.Text = "—";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.WriteSign);
            // 
            // divideBtn
            // 
            this.divideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideBtn.Location = new System.Drawing.Point(260, 30);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(75, 39);
            this.divideBtn.TabIndex = 2;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.WriteSign);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationBtn.Location = new System.Drawing.Point(371, 30);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(75, 39);
            this.multiplicationBtn.TabIndex = 3;
            this.multiplicationBtn.Text = "×";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.WriteSign);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(480, 120);
            this.panel1.MinimumSize = new System.Drawing.Size(480, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 110);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(30, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.mminBtn);
            this.panel2.Controls.Add(this.mplusBtn);
            this.panel2.Controls.Add(this.mrBtn);
            this.panel2.Controls.Add(this.mcBtn);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.num0Btn);
            this.panel2.Controls.Add(this.kommaBtn);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.num1Btn);
            this.panel2.Controls.Add(this.num2Btn);
            this.panel2.Controls.Add(this.num3Btn);
            this.panel2.Controls.Add(this.eraseBtn);
            this.panel2.Controls.Add(this.num4Btn);
            this.panel2.Controls.Add(this.num5Btn);
            this.panel2.Controls.Add(this.num6Btn);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.num7Btn);
            this.panel2.Controls.Add(this.num8Btn);
            this.panel2.Controls.Add(this.num9Btn);
            this.panel2.Controls.Add(this.msBtn);
            this.panel2.Controls.Add(this.multiplicationBtn);
            this.panel2.Controls.Add(this.divideBtn);
            this.panel2.Controls.Add(this.minusBtn);
            this.panel2.Controls.Add(this.plusBtn);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MinimumSize = new System.Drawing.Size(480, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 390);
            this.panel2.TabIndex = 17;
            // 
            // mminBtn
            // 
            this.mminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mminBtn.Location = new System.Drawing.Point(371, 317);
            this.mminBtn.Name = "mminBtn";
            this.mminBtn.Size = new System.Drawing.Size(75, 41);
            this.mminBtn.TabIndex = 23;
            this.mminBtn.Text = "M-";
            this.mminBtn.UseVisualStyleBackColor = true;
            this.mminBtn.Click += new System.EventHandler(this.mminBtn_Click);
            // 
            // mplusBtn
            // 
            this.mplusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mplusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mplusBtn.Location = new System.Drawing.Point(260, 317);
            this.mplusBtn.Name = "mplusBtn";
            this.mplusBtn.Size = new System.Drawing.Size(75, 41);
            this.mplusBtn.TabIndex = 22;
            this.mplusBtn.Text = "M+";
            this.mplusBtn.UseVisualStyleBackColor = true;
            this.mplusBtn.Click += new System.EventHandler(this.mplusBtn_Click);
            // 
            // mrBtn
            // 
            this.mrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mrBtn.Enabled = false;
            this.mrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mrBtn.Location = new System.Drawing.Point(143, 317);
            this.mrBtn.Name = "mrBtn";
            this.mrBtn.Size = new System.Drawing.Size(75, 41);
            this.mrBtn.TabIndex = 21;
            this.mrBtn.Text = "MR";
            this.mrBtn.UseVisualStyleBackColor = true;
            this.mrBtn.Click += new System.EventHandler(this.mrBtn_Click);
            // 
            // mcBtn
            // 
            this.mcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcBtn.Enabled = false;
            this.mcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcBtn.Location = new System.Drawing.Point(32, 317);
            this.mcBtn.Name = "mcBtn";
            this.mcBtn.Size = new System.Drawing.Size(75, 41);
            this.mcBtn.TabIndex = 20;
            this.mcBtn.Text = "MC";
            this.mcBtn.UseVisualStyleBackColor = true;
            this.mcBtn.Click += new System.EventHandler(this.ClearMemory);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(32, 262);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 41);
            this.button17.TabIndex = 19;
            this.button17.Text = "+/-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.changeSign);
            // 
            // num0Btn
            // 
            this.num0Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num0Btn.Location = new System.Drawing.Point(143, 262);
            this.num0Btn.Name = "num0Btn";
            this.num0Btn.Size = new System.Drawing.Size(75, 41);
            this.num0Btn.TabIndex = 18;
            this.num0Btn.Text = "0";
            this.num0Btn.UseVisualStyleBackColor = true;
            this.num0Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // kommaBtn
            // 
            this.kommaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kommaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kommaBtn.Location = new System.Drawing.Point(263, 262);
            this.kommaBtn.Name = "kommaBtn";
            this.kommaBtn.Size = new System.Drawing.Size(75, 41);
            this.kommaBtn.TabIndex = 17;
            this.kommaBtn.Text = ",";
            this.kommaBtn.UseVisualStyleBackColor = true;
            this.kommaBtn.Click += new System.EventHandler(this.writeComma);
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(371, 262);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 41);
            this.button20.TabIndex = 16;
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.ShowResult);
            // 
            // num1Btn
            // 
            this.num1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num1Btn.Location = new System.Drawing.Point(32, 204);
            this.num1Btn.Name = "num1Btn";
            this.num1Btn.Size = new System.Drawing.Size(75, 41);
            this.num1Btn.TabIndex = 15;
            this.num1Btn.Text = "1";
            this.num1Btn.UseVisualStyleBackColor = true;
            this.num1Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num2Btn
            // 
            this.num2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num2Btn.Location = new System.Drawing.Point(143, 204);
            this.num2Btn.Name = "num2Btn";
            this.num2Btn.Size = new System.Drawing.Size(75, 41);
            this.num2Btn.TabIndex = 14;
            this.num2Btn.Text = "2";
            this.num2Btn.UseVisualStyleBackColor = true;
            this.num2Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num3Btn
            // 
            this.num3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num3Btn.Location = new System.Drawing.Point(260, 204);
            this.num3Btn.Name = "num3Btn";
            this.num3Btn.Size = new System.Drawing.Size(75, 41);
            this.num3Btn.TabIndex = 13;
            this.num3Btn.Text = "3";
            this.num3Btn.UseVisualStyleBackColor = true;
            this.num3Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // eraseBtn
            // 
            this.eraseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eraseBtn.Location = new System.Drawing.Point(371, 204);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(75, 41);
            this.eraseBtn.TabIndex = 12;
            this.eraseBtn.Text = "⌫";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.erase);
            // 
            // num4Btn
            // 
            this.num4Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num4Btn.Location = new System.Drawing.Point(30, 151);
            this.num4Btn.Name = "num4Btn";
            this.num4Btn.Size = new System.Drawing.Size(75, 41);
            this.num4Btn.TabIndex = 11;
            this.num4Btn.Text = "4";
            this.num4Btn.UseVisualStyleBackColor = true;
            this.num4Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num5Btn
            // 
            this.num5Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num5Btn.Location = new System.Drawing.Point(143, 151);
            this.num5Btn.Name = "num5Btn";
            this.num5Btn.Size = new System.Drawing.Size(75, 41);
            this.num5Btn.TabIndex = 10;
            this.num5Btn.Text = "5";
            this.num5Btn.UseVisualStyleBackColor = true;
            this.num5Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num6Btn
            // 
            this.num6Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num6Btn.Location = new System.Drawing.Point(260, 151);
            this.num6Btn.Name = "num6Btn";
            this.num6Btn.Size = new System.Drawing.Size(75, 41);
            this.num6Btn.TabIndex = 9;
            this.num6Btn.Text = "6";
            this.num6Btn.UseVisualStyleBackColor = true;
            this.num6Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(371, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 41);
            this.button12.TabIndex = 8;
            this.button12.Text = "С";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.eraseAndClearHistory);
            // 
            // num7Btn
            // 
            this.num7Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num7Btn.Location = new System.Drawing.Point(30, 92);
            this.num7Btn.Name = "num7Btn";
            this.num7Btn.Size = new System.Drawing.Size(75, 41);
            this.num7Btn.TabIndex = 7;
            this.num7Btn.Text = "7";
            this.num7Btn.UseVisualStyleBackColor = true;
            this.num7Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num8Btn
            // 
            this.num8Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num8Btn.Location = new System.Drawing.Point(143, 92);
            this.num8Btn.Name = "num8Btn";
            this.num8Btn.Size = new System.Drawing.Size(75, 41);
            this.num8Btn.TabIndex = 6;
            this.num8Btn.Text = "8";
            this.num8Btn.UseVisualStyleBackColor = true;
            this.num8Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // num9Btn
            // 
            this.num9Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9Btn.ForeColor = System.Drawing.Color.DimGray;
            this.num9Btn.Location = new System.Drawing.Point(260, 92);
            this.num9Btn.Name = "num9Btn";
            this.num9Btn.Size = new System.Drawing.Size(75, 41);
            this.num9Btn.TabIndex = 5;
            this.num9Btn.Text = "9";
            this.num9Btn.UseVisualStyleBackColor = true;
            this.num9Btn.Click += new System.EventHandler(this.writeNum);
            // 
            // msBtn
            // 
            this.msBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msBtn.Location = new System.Drawing.Point(371, 92);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(75, 41);
            this.msBtn.TabIndex = 4;
            this.msBtn.Text = "MS";
            this.msBtn.UseVisualStyleBackColor = true;
            this.msBtn.Click += new System.EventHandler(this.AddToMemory);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(478, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 458);
            this.panel3.TabIndex = 18;
            this.panel3.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(480, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(480, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 500);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // historyPanel
            // 
            this.historyPanel.AutoScroll = true;
            this.historyPanel.BackColor = System.Drawing.Color.Silver;
            this.historyPanel.Location = new System.Drawing.Point(481, 40);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.historyPanel.Size = new System.Drawing.Size(184, 446);
            this.historyPanel.TabIndex = 21;
            // 
            // historyBtn
            // 
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.Enabled = false;
            this.historyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyBtn.Location = new System.Drawing.Point(479, 0);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(91, 41);
            this.historyBtn.TabIndex = 22;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // memoryBtn
            // 
            this.memoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryBtn.Location = new System.Drawing.Point(569, 0);
            this.memoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.memoryBtn.Name = "memoryBtn";
            this.memoryBtn.Size = new System.Drawing.Size(94, 41);
            this.memoryBtn.TabIndex = 23;
            this.memoryBtn.Text = "Memory";
            this.memoryBtn.UseVisualStyleBackColor = true;
            this.memoryBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(666, 498);
            this.Controls.Add(this.memoryBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 545);
            this.MinimumSize = new System.Drawing.Size(490, 535);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button num0Btn;
        private System.Windows.Forms.Button kommaBtn;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button num1Btn;
        private System.Windows.Forms.Button num2Btn;
        private System.Windows.Forms.Button num3Btn;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Button num4Btn;
        private System.Windows.Forms.Button num5Btn;
        private System.Windows.Forms.Button num6Btn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button num7Btn;
        private System.Windows.Forms.Button num8Btn;
        private System.Windows.Forms.Button num9Btn;
        private System.Windows.Forms.Button msBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mminBtn;
        private System.Windows.Forms.Button mplusBtn;
        private System.Windows.Forms.Button mrBtn;
        private System.Windows.Forms.Button mcBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button memoryBtn;
    }
}

