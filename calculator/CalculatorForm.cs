using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        private string HistoryDataFilePath = "memory.txt";

        Button[] buttons;
        bool isText = false; 
        bool isNum = false;
        List<double> memory = new List<double>();

        String action;
        String num1 = "";

        public CalculatorForm()
        {
            InitializeComponent();
            textBox1.ContextMenu = new ContextMenu();
        }

        private void SetToolTipForButtons() 
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(msBtn, "Memory store");
            toolTip1.SetToolTip(mcBtn, "Clear all memory");
            toolTip1.SetToolTip(mrBtn, "Memory recall");
            toolTip1.SetToolTip(mplusBtn, "Memory add");
            toolTip1.SetToolTip(mminBtn, "Memory subtract");
        }

        private void SetButtonLayout()
        {
            buttons = new Button[] { plusBtn, minusBtn, divideBtn, multiplicationBtn, num7Btn, num8Btn, num9Btn, msBtn, num4Btn, num5Btn, num6Btn, button12, num1Btn, num2Btn, num3Btn, eraseBtn, button17, num0Btn, kommaBtn, button20, mcBtn, mrBtn, mplusBtn, mminBtn };

            int buttonWidth = panel2.Width / 5;
            int buttonHeight = panel2.Height / 7;

            int columns = 4;
            int rows = 6;
            int spacing = 3;

            int x = (panel2.Width - (buttonWidth * columns + spacing * (columns - 1))) / 2;
            int y = (panel2.Height - (buttonHeight * rows + spacing * (rows - 1))) / 2;

            int buttonIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Button button = buttons[buttonIndex++];
                    button.Location = new Point(x + col * (buttonWidth + spacing), y + row * (buttonHeight + spacing));
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Margin = new Padding(0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.MinimumSize.Width + panel3.Width, this.MinimumSize.Height);

            ReadAndDisplayHistoryData();
            SetButtonLayout();
            SetToolTipForButtons();
        }

        private void Form1_Resize(object sender, EventArgs e) { 
            if (Width > MinimumSize.Width)
            {
                Width = MaximumSize.Width;
                historyPanel.Visible = true;
                historyPanel.Visible = true;
            }
            if (Width < MaximumSize.Width)
            {
                historyPanel.Visible = false;
                panel3.Visible = false;
                historyPanel.Visible = false;
                Width = MinimumSize.Width;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22 || (ModifierKeys == Keys.Control && e.KeyChar == 'v'))
            {
                string clipboardText = Clipboard.GetText(); 

                if (double.TryParse(clipboardText, out double number))
                {
                    textBox1.Text = number.ToString();
                    isNum = true;
                }
                else
                {
                    textBox1.Text = "Invalid input";
                    isText = true;

                    if (label1.Text != "")
                    {
                        label1.Text = "";
                        action = "";
                        num1 = "";
                    }
                }

                e.Handled = true;
            }

            Dictionary<char, Button> keyToButton = new Dictionary<char, Button>()
    {
        { '0', num0Btn },
        { '1', num1Btn },
        { '2', num2Btn },
        { '3', num3Btn },
        { '4', num4Btn },
        { '5', num5Btn },
        { '6', num6Btn },
        { '7', num7Btn },
        { '8', num8Btn },
        { '9', num9Btn },
        { '+', plusBtn },
        { '-', minusBtn },
        { '/', divideBtn },
        { '*', multiplicationBtn },
        { '\r', button20 }
    };

            if (char.IsDigit(e.KeyChar) || keyToButton.ContainsKey(e.KeyChar))
            {
                e.Handled = true;
                Button button;
                if (keyToButton.TryGetValue(e.KeyChar, out button))
                {
                    button.PerformClick();
                    textBox1.Select(textBox1.Text.Length, 0);
                }
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                eraseBtn.PerformClick();
                textBox1.Select(textBox1.Text.Length, 0);
            }
            else if (e.KeyChar == ',' && (textBox1.Text.Contains(",") || textBox1.Text == ""))
            {
                e.Handled = true; // Запретить повторный ввод запятой или ввод запятой в начале строки
            }
            else if (!char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Запретить ввод текста
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Увеличение максимального размера строки ввода
            int maxTextLength = 30; // Новое значение максимального размера строки
            if (textBox1.Text.Length > maxTextLength)
            {
                textBox1.Text = textBox1.Text.Substring(0, maxTextLength);
                textBox1.SelectionStart = maxTextLength;
                textBox1.SelectionLength = 0;
                textBox1.BackColor = Color.LightCoral;
            }
            else
            {
                textBox1.BackColor = SystemColors.Window;
            }

            // Изменение размера шрифта, когда текст занимает весь textBox1
            float maxFontSize = 22; // Начальный размер шрифта
            int minFontSize = 14; // Минимальный размер шрифта

            float currentFontSize = textBox1.Font.SizeInPoints;

            if (TextRenderer.MeasureText(textBox1.Text, new Font(textBox1.Font.FontFamily, currentFontSize)).Width > textBox1.Width)
            while (TextRenderer.MeasureText(textBox1.Text, new Font(textBox1.Font.FontFamily, currentFontSize)).Width > textBox1.Width)
            {
                if (currentFontSize <= minFontSize)
                {
                    break;
                }
                currentFontSize -= 1;
            }
            else
            while (TextRenderer.MeasureText(textBox1.Text, new Font(textBox1.Font.FontFamily, currentFontSize)).Width < textBox1.Width)
            {
                if (currentFontSize >= maxFontSize)
                {
                    break;
                }
                currentFontSize += 1;
            }

            textBox1.Font = new Font(textBox1.Font.FontFamily, currentFontSize);
        }

        private void eraseAndClearHistory(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";

            action = "";
            num1 = "";
            
            return;
        }

        private void writeNum(object sender, EventArgs e)
        { 
            Button btn = (Button)sender;

            if (isNum || isText || textBox1.Text == "0") textBox1.Text = "";

            if (isNum) isNum = false;
   
            if (isText) isText = false;
            
            textBox1.Text += btn.Text;
        }

        private void writeComma(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text.IndexOf(",") > 0 || textBox1.Text == "") return;
            textBox1.Text += btn.Text;
        }

        private void erase(object sender, EventArgs e)
        {

            if (isNum) return;

            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            if (textBox1.Text == "") textBox1.Text = "0";
           
        }

        private void WriteSign(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "" && action == "") return;

            if (isText)
            {
                if (Double.TryParse(textBox1.Text, out double parsedValue))
                {
                    isText = false;
                }
                else
                {
                    textBox1.Text = "Invalid input";
                    action = "";
                    return;
                }
               
            }

            char[] operators = { '—', '+', '÷', '×' };
            if (label1.Text.IndexOfAny(operators) != -1 && textBox1.Text != "" && !label1.Text.Contains("="))
            { 
                button20.PerformClick(); 
            }

            action = btn.Text;
            if (num1 == "") num1 = textBox1.Text;

            textBox1.Text = "";

            label1.Text = num1 + " " + action;
        }

        private void ShowResult(object sender, EventArgs e)
        {
            double memory;
            string lastAction;

            double n1, n2;

            try
            {
                n1 = Convert.ToDouble(num1);
            }
            catch (FormatException)
            {
                if (isText) return;
                n1 = Convert.ToDouble(textBox1.Text);
            }

            if (Double.TryParse(textBox1.Text, out double parsedValue))
            {
                n2 = parsedValue;
            }
            else
            {
                if (isText)
                {
                    label1.Text = "";
                    textBox1.Text = "Invalid input";
                    action = "";
                    num1 = "";
                    isText = true;
                    return;
                }
                   
                n2 = n1; 
            }

            if (label1.Text.Contains("=") && action == "")
            {
                string pattern = @"(?:[÷×]|(?<!E)\+|(?<!E)\—|(?!^)\—)";
                Match match = Regex.Match(label1.Text, pattern);

                if (match.Success)
                    lastAction = match.Value;
                else
                    lastAction = "";
                
                action = lastAction;

                string patt = @"(\d+|[+-]?\u221E)\s*(?:[+÷×—]|(?<!E)\+)(?!\d)\s*(\d+|[+-]?\u221E)";
                Match m = Regex.Match(label1.Text, patt);

                if (m.Success)
                {
                    n2 = Convert.ToDouble(m.Groups[2].Value); 
                }
            }

            double inf = Double.PositiveInfinity;

            switch (action)
            {
                case "+":
                    if (n1 == inf && n2 == inf)
                    {
                        memory = inf;
                    }
                    else if (n1 == -inf && n2 == -inf)
                    {
                        memory = -inf;
                    }
                    else if ((n1 == inf && n2 == -inf) || (n1 == -inf && n2 == inf))
                    {
                        textBox1.Text = "Result is undefined";
                        label1.Text += n2.ToString();
                        action = "";
                        num1 = "";
                        isText = true;
                        return;
                    }
                    else
                    {
                        memory = n1 + n2;
                    }
                    break;

                case "—":
                    if ((n1 == inf && n2 == inf) || (n1 == -inf && n2 == -inf))
                    {
                        textBox1.Text = "Result is undefined";
                        label1.Text += n2.ToString();
                        action = "";
                        num1 = "";
                        isText = true;
                        return;
                    }
                    else if (n1 == inf && n2 == -inf)
                    {
                        memory = inf;
                    }
                    else if ((n1 == -inf && n2 == inf))
                    {
                        memory = -inf;
                    }
                    else
                    {
                        memory = n1 - n2;
                    }
                    break;

                case "÷":
                    if (n2 == 0)
                    {
                        if (n1 == 0)
                        {
                            textBox1.Text = "Result is undefined";
                            isText = true;
                            action = "";
                            num1 = "";
                            label1.Text += n2.ToString();
                            return;
                        }
                        else if (n1 == inf || n1 == -inf)
                        {
                            memory = inf;
                        }
                        else
                        {
                            memory = Double.PositiveInfinity;
                        }
                    }
                    else if (n2 == inf || n2 == -inf)
                    {
                        if (n1 == inf || n1 == -inf)
                        {
                            textBox1.Text = "Result is undefined";
                            label1.Text += n2.ToString();
                            action = "";
                            num1 = "";
                            isText = true;
                            return;
                        }
                        else
                        {
                            memory = 0;
                        }
                    }
                    else
                    {
                        memory = n1 / n2;
                    }
                    break;

                case "×":
                    if (( (n1 == inf || n1 == -inf) && n2 == 0) || (n1 == 0 && (n2 == inf || n2 == -inf)))
                    {
                        textBox1.Text = "Result is undefined";
                        label1.Text += n2.ToString();
                        action = "";
                        num1 = "";
                        isText = true;
                        return;
                    }
                    else
                    {
                        memory = n1 * n2;
                    }
                    break;

                default:
                    return;
            }

            label1.Text = n1.ToString() + " " + action + " " + n2.ToString() + " = " + memory.ToString();

            string res = label1.Text;
            WriteMemoryDataToFile(res);
            AddNewHistoryEntry(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), res);

            action = ""; 
            num1 = "";
            isNum = true;
            textBox1.Text = memory.ToString();

        }

        private void WriteMemoryDataToFile(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(HistoryDataFilePath, true))
                {
                    string dateTimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine($"{dateTimeString}\n{data}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в файл: " + ex.Message);
            }
        }

        private void AddNewHistoryEntry(string date, string action)
        {
            int spacing = 15;
            int y = 5;

            Label historyLabel = new Label();
            historyLabel.Text = $"{date}\n{action}";
            historyLabel.AutoSize = true;
            historyLabel.Location = new Point(0, y);
            historyLabel.Click += HistoryLabel_Click;

            Button deleteButton = new Button();
            deleteButton.Text = "X";
            deleteButton.Size = new Size(20, 20);
            deleteButton.Location = new Point(historyLabel.Width + 5, historyLabel.Location.Y + 2);
            deleteButton.Click += DeleteHistoryLabel;
            deleteButton.Tag = historyLabel;

            List<Control> tempControls = historyPanel.Controls.Cast<Control>().ToList();
            tempControls.Reverse();
            tempControls.Add(deleteButton);
            tempControls.Add(historyLabel);
            tempControls.Reverse();

            historyPanel.Controls.Clear();
            historyPanel.Controls.AddRange(tempControls.ToArray());

            for (int i = 0; i < historyPanel.Controls.Count; i += 2)
            {
                Control histLabel = historyPanel.Controls[i];
                Control delButton = historyPanel.Controls[i + 1];

                histLabel.Location = new Point(0, y);
                delButton.Location = new Point(histLabel.Width + 5, histLabel.Location.Y + 2); 

                y += histLabel.Height + spacing;
            }

            historyPanel.Invalidate();
            historyPanel.AutoScroll = true;
        }
        
        private void HistoryLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string labelText = clickedLabel.Text;

            string[] lines = labelText.Split('\n');
            if (lines.Length >= 2)
            {
                string actionLine = lines[1];

                label1.Text = actionLine;
                isNum = true;

                int equalsIndex = actionLine.IndexOf("=");
                if (equalsIndex != -1 && equalsIndex < actionLine.Length - 1)
                {
                    string answer = actionLine.Substring(equalsIndex + 1).Trim();
                    textBox1.Text = answer;
                }
            }
        }

        private void RemoveHistoryDataFromFile(string[] linesToRemove)
        {
            try
            {
                string[] fileLines = File.ReadAllLines(HistoryDataFilePath);
                List<string> updatedLines = new List<string>();

                bool removeNextLine = false;

                for (int i = 0; i < fileLines.Length; i++)
                {
                    string line = fileLines[i];

                    if (removeNextLine)
                    {
                        removeNextLine = false;
                        continue;
                    }

                    if (Array.Exists(linesToRemove, x => x.Trim() == line.Trim()))
                    {
                        removeNextLine = true;
                        continue;
                    }

                    updatedLines.Add(line);
                }

                File.WriteAllLines(HistoryDataFilePath, updatedLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных из файла: " + ex.Message);
            }
        }

        private void DeleteHistoryLabel(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Label historyLabel = (Label)deleteButton.Tag;

            int buttonIndex = historyPanel.Controls.IndexOf(deleteButton);

            string historyData = $"{historyLabel.Text}\n"; 
            string[] linesToRemove = historyData.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            RemoveHistoryDataFromFile(linesToRemove);

            historyPanel.Controls.Remove(deleteButton);
            historyPanel.Controls.Remove(historyLabel);

            deleteButton.Dispose();
            historyLabel.Dispose();

            int spacing = 15;
            int y = 5;

            for (int i = 0; i < historyPanel.Controls.Count; i+=2)
            {
                Control histLabel = historyPanel.Controls[i];
                Control delButton = historyPanel.Controls[i+1];

                histLabel.Location = new Point(0, y);
                delButton.Location = new Point(histLabel.Width + 5, histLabel.Location.Y + 2); ;

                y += histLabel.Height + spacing;
            }
        }
        private void ReadAndDisplayHistoryData()
        {
            bool hasMistakes = false;
            try
            {
                using (StreamReader reader = new StreamReader(HistoryDataFilePath))
                {
                    int spacing = 15;
                    int y = 5;

                    List<string> actions = new List<string>();
                    List<string> dates = new List<string>();

                    string currentLine;
                    string previousLine = null;

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(currentLine))
                            continue;

                        if (IsAction(currentLine))
                        {
                            if (previousLine != null && IsDate(previousLine))
                            {
                                dates.Add(previousLine);
                                actions.Add(currentLine);
                            }
                            else
                            {
                                if (!hasMistakes)
                                {
                                    //MessageBox.Show($"Предупреждение: файл для хранения памяти содержит некорректные данные. Строки с некорректными данными были пропущены. {currentLine}");
                                    hasMistakes = true;
                                }
                            }
                        }

                        previousLine = currentLine;
                    }

                    if (actions.Count != dates.Count)
                    {
                        //MessageBox.Show("Ошибка: количество дат и действий не совпадает.");
                        return;
                    }

                    for (int i = actions.Count - 1; i >= 0; i--)
                    {
                        Label historyLabel = new Label();
                        historyLabel.Text = $"{dates[i]}\n{actions[i]}";
                        historyLabel.AutoSize = true;
                        historyLabel.Location = new Point(0, y);
                        historyLabel.Click += HistoryLabel_Click;

                        historyPanel.Controls.Add(historyLabel);

                        Button deleteButton = new Button();
                        deleteButton.Text = "X";
                        deleteButton.Size = new Size(20, 20);
                        deleteButton.Location = new Point(historyLabel.Width + 5, historyLabel.Location.Y + 2);
                        deleteButton.Click += DeleteHistoryLabel;
                        deleteButton.Tag = historyLabel; 

                        historyPanel.Controls.Add(deleteButton);

                        y += historyLabel.Height + spacing;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }
        private bool IsDate(string input)
        {
            DateTime date;
            return DateTime.TryParse(input, out date);
        }

        private bool IsAction(string input)
        {
            input = input.Replace(" ", "");
            if (input.Contains("+") || input.Contains("—") || input.Contains("×") || input.Contains("÷"))
            {
                if (input.Contains("=")) return true;
            }

            return false;
        }

        private void AddToMemory(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            try
            {
                if (double.TryParse(input, out double number))
                {
                    memory.Add(number);
                    isNum = true;
                    UpdatePanel3();
                }
                else
                {
                    throw new FormatException("Неверный формат числа.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearMemory(object sender, EventArgs e)
        {
            memory.Clear();
            UpdatePanel3();
        }

        private void changeSign(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                number = -number;
                textBox1.Text = number.ToString();
            }
            else {
                textBox1.Text = "Invalid input";
                isText = true;
            }

        }

        private void SetMemoryOnOff()
        {
            bool hasMemory = memory.Count > 0;
            mrBtn.Enabled = hasMemory;
            mcBtn.Enabled = hasMemory;
        }

        private void UpdatePanel3()
        {
            SetMemoryOnOff();

            panel3.Controls.Clear();

            int labelHeight = 30;
            int buttonWidth = Convert.ToInt32(panel3.Width / 4);
            int y = 5;

            for (int i = 0; i < memory.Count; i++)
            {
                double value = memory[i];
                int id = i;

                TableLayoutPanel itemPanel = new TableLayoutPanel();
                itemPanel.AutoSize = true;

                Label label = new Label();
                label.Text = value.ToString();
                label.AutoSize = true;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleLeft;

                Button deleteButton = new Button();
                deleteButton.Text = "X";
                deleteButton.Size = new Size(buttonWidth, labelHeight);
                deleteButton.Click += (sender, e) =>
                {
                    memory.Remove(value);
                    UpdatePanel3();
                };

                Button mPlusButton = new Button();
                mPlusButton.Text = "M+";
                mPlusButton.Size = new Size(buttonWidth, labelHeight);
                mPlusButton.Tag = id; // Привязываем идентификатор
                mPlusButton.Click += (sender, e) =>
                {
                    double textboxValue;
                    if (double.TryParse(textBox1.Text, out textboxValue))
                    {
                        if ((textboxValue == Double.NegativeInfinity && memory[id] == Double.PositiveInfinity) || (memory[id] == Double.NegativeInfinity && textboxValue == Double.PositiveInfinity))
                        {
                            MessageBox.Show($"{memory[id]} + {textboxValue} is undefined");
                            return;
                        }

                        if (memory.Count > id)
                        {
                            memory[id] += textboxValue;
                            UpdatePanel3();
                        }
                    }
                };

                Button mMinusButton = new Button();
                mMinusButton.Text = "M-";
                mMinusButton.Size = new Size(buttonWidth, labelHeight);
                mMinusButton.Tag = id; // Привязываем идентификатор
                mMinusButton.Click += (sender, e) =>
                {
                    double textboxValue;
                    if (double.TryParse(textBox1.Text, out textboxValue))
                    {
                    if ((textboxValue == Double.PositiveInfinity && memory[id] == Double.PositiveInfinity) || (memory[id] == Double.NegativeInfinity && textboxValue == Double.NegativeInfinity) )
                        {
                            MessageBox.Show($"{memory[id]} - {textboxValue} is undefined");
                            return;
                        }

                        if (memory.Count > id)
                        {
                            memory[id] -= textboxValue;
                            UpdatePanel3();
                        }
                    }
                };

                label.Font = new Font(label.Font.FontFamily, 12f, label.Font.Style);
                itemPanel.Controls.Add(label, 0, 0);

                TableLayoutPanel buttonPanel = new TableLayoutPanel();
                buttonPanel.AutoSize = true;
                buttonPanel.Dock = DockStyle.Top;

                buttonPanel.Controls.Add(deleteButton, 0, 0);
                buttonPanel.Controls.Add(mPlusButton, 1, 0);
                buttonPanel.Controls.Add(mMinusButton, 2, 0);

                itemPanel.Controls.Add(buttonPanel, 0, 1);

                panel3.Controls.Add(itemPanel);

                itemPanel.Location = new Point(0, y);
                itemPanel.Height = labelHeight;

                y += labelHeight + 35;
            }
        }

        private void mplusBtn_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            try
            {
                if (double.TryParse(input, out double number))
                {
                    if (memory.Count == 0)
                        memory.Add(number);
                    else
                        memory[memory.Count - 1] += number;

                    isNum = true;
                    UpdatePanel3();
                }
                else
                {
                    throw new FormatException("Неверный формат числа.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mminBtn_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            try 
            {
                if (double.TryParse(input, out double number))
                {
                    if (memory.Count == 0)
                        memory.Add(0 - number);
                    else
                        memory[memory.Count - 1] -= number;
      
                    isNum = true;
                    UpdatePanel3();
                }
                else
                {
                    throw new FormatException("Неверный формат числа.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mrBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory[memory.Count - 1].ToString();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            historyPanel.Visible = true;

            historyBtn.Enabled = false;
            memoryBtn.Enabled = true;
        }

        private void memoryBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            historyPanel.Visible = false;


            historyBtn.Enabled = true;
            memoryBtn.Enabled = false;
        }
    }
        
}
