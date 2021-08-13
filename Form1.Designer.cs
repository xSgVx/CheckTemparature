
namespace CheckTemperature
{
    partial class CheckTemperatureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getCurrentTemperature = new System.Windows.Forms.Button();
            this.currentTimeText = new System.Windows.Forms.Label();
            this.predictedNameLabel = new System.Windows.Forms.LinkLabel();
            this.predictedNameText = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateText = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.requestForCityNameLabel = new System.Windows.Forms.Label();
            this.temparatureLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getCurrentTemperature
            // 
            this.getCurrentTemperature.Location = new System.Drawing.Point(367, 69);
            this.getCurrentTemperature.Name = "getCurrentTemperature";
            this.getCurrentTemperature.Size = new System.Drawing.Size(139, 48);
            this.getCurrentTemperature.TabIndex = 0;
            this.getCurrentTemperature.Text = "Получить температуру";
            this.getCurrentTemperature.UseVisualStyleBackColor = true;
            this.getCurrentTemperature.Click += new System.EventHandler(this.getCurrentTemperature_Click);
            // 
            // currentTimeText
            // 
            this.currentTimeText.AutoSize = true;
            this.currentTimeText.Location = new System.Drawing.Point(24, 22);
            this.currentTimeText.Name = "currentTimeText";
            this.currentTimeText.Size = new System.Drawing.Size(118, 20);
            this.currentTimeText.TabIndex = 3;
            this.currentTimeText.Text = "Текущее время:";
            // 
            // predictedNameLabel
            // 
            this.predictedNameLabel.AutoSize = true;
            this.predictedNameLabel.Location = new System.Drawing.Point(233, 130);
            this.predictedNameLabel.Name = "predictedNameLabel";
            this.predictedNameLabel.Size = new System.Drawing.Size(104, 20);
            this.predictedNameLabel.TabIndex = 4;
            this.predictedNameLabel.TabStop = true;
            this.predictedNameLabel.Text = "*имя_города*";
            this.predictedNameLabel.Visible = false;
            // 
            // predictedNameText
            // 
            this.predictedNameText.AutoSize = true;
            this.predictedNameText.Location = new System.Drawing.Point(24, 130);
            this.predictedNameText.Name = "predictedNameText";
            this.predictedNameText.Size = new System.Drawing.Size(194, 20);
            this.predictedNameText.TabIndex = 5;
            this.predictedNameText.Text = "Возможно имелось ввиду:";
            this.predictedNameText.Visible = false;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(148, 22);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(50, 20);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "label2";
            // 
            // currentDateText
            // 
            this.currentDateText.AutoSize = true;
            this.currentDateText.Location = new System.Drawing.Point(216, 22);
            this.currentDateText.Name = "currentDateText";
            this.currentDateText.Size = new System.Drawing.Size(104, 20);
            this.currentDateText.TabIndex = 7;
            this.currentDateText.Text = "Текущая дата:";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(326, 22);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(50, 20);
            this.currentDateLabel.TabIndex = 8;
            this.currentDateLabel.Text = "label4";
            // 
            // requestForCityNameLabel
            // 
            this.requestForCityNameLabel.AutoSize = true;
            this.requestForCityNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requestForCityNameLabel.Location = new System.Drawing.Point(24, 172);
            this.requestForCityNameLabel.Name = "requestForCityNameLabel";
            this.requestForCityNameLabel.Size = new System.Drawing.Size(130, 54);
            this.requestForCityNameLabel.TabIndex = 9;
            this.requestForCityNameLabel.Text = "label2";
            // 
            // temparatureLabel
            // 
            this.temparatureLabel.AutoSize = true;
            this.temparatureLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temparatureLabel.Location = new System.Drawing.Point(284, 172);
            this.temparatureLabel.Name = "temparatureLabel";
            this.temparatureLabel.Size = new System.Drawing.Size(120, 50);
            this.temparatureLabel.TabIndex = 10;
            this.temparatureLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(24, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите название города";
            this.textBox1.Size = new System.Drawing.Size(337, 43);
            this.textBox1.TabIndex = 11;
            // 
            // CheckTemperatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 237);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.temparatureLabel);
            this.Controls.Add(this.requestForCityNameLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.currentDateText);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.predictedNameText);
            this.Controls.Add(this.predictedNameLabel);
            this.Controls.Add(this.currentTimeText);
            this.Controls.Add(this.getCurrentTemperature);
            this.Name = "CheckTemperatureForm";
            this.Text = "CheckTemparature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCurrentTemperature;
        private System.Windows.Forms.Label currentTimeText;
        private System.Windows.Forms.LinkLabel predictedNameLabel;
        private System.Windows.Forms.Label predictedNameText;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateText;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label requestForCityNameLabel;
        private System.Windows.Forms.Label temparatureLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

