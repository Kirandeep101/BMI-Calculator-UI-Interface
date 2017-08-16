/*
 * Name:Kirandeep Kaur
 * Student Id: 300915966
 * Date:15/08/2017
 * Description:- Implement Formula for switching radio and imperial buttons
 * Version:- 0.4 finally calculate bmi 
 */
namespace BMI_Calculator_UI_Interface
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.Heighttext = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.weighttextBox = new System.Windows.Forms.TextBox();
            this.BMIbutton = new System.Windows.Forms.Button();
            this.Resulttext = new System.Windows.Forms.TextBox();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.meterlabel = new System.Windows.Forms.Label();
            this.kiloglabel = new System.Windows.Forms.Label();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Heighttext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Weightlabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weighttextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BMIbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Resulttext, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Resetbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.meterlabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.kiloglabel, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.54772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.45228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlabel.Location = new System.Drawing.Point(3, 0);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(129, 31);
            this.Heightlabel.TabIndex = 0;
            this.Heightlabel.Text = "MyHeight";
            // 
            // Heighttext
            // 
            this.Heighttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heighttext.Location = new System.Drawing.Point(146, 3);
            this.Heighttext.Name = "Heighttext";
            this.Heighttext.Size = new System.Drawing.Size(100, 38);
            this.Heighttext.TabIndex = 1;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weightlabel.Location = new System.Drawing.Point(3, 102);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(134, 31);
            this.Weightlabel.TabIndex = 2;
            this.Weightlabel.Text = "MyWeight";
            // 
            // weighttextBox
            // 
            this.weighttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weighttextBox.Location = new System.Drawing.Point(146, 105);
            this.weighttextBox.Name = "weighttextBox";
            this.weighttextBox.Size = new System.Drawing.Size(100, 38);
            this.weighttextBox.TabIndex = 3;
            // 
            // BMIbutton
            // 
            this.BMIbutton.AutoSize = true;
            this.BMIbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIbutton.Location = new System.Drawing.Point(3, 213);
            this.BMIbutton.Name = "BMIbutton";
            this.BMIbutton.Size = new System.Drawing.Size(137, 41);
            this.BMIbutton.TabIndex = 4;
            this.BMIbutton.Text = "Calculate BMI";
            this.BMIbutton.UseVisualStyleBackColor = true;
            this.BMIbutton.Click += new System.EventHandler(this.BMIbutton_Click);
            // 
            // Resulttext
            // 
            this.Resulttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resulttext.Location = new System.Drawing.Point(146, 213);
            this.Resulttext.Name = "Resulttext";
            this.Resulttext.Size = new System.Drawing.Size(100, 38);
            this.Resulttext.TabIndex = 5;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.Location = new System.Drawing.Point(3, 292);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(137, 41);
            this.Resetbutton.TabIndex = 4;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // meterlabel
            // 
            this.meterlabel.AutoSize = true;
            this.meterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterlabel.Location = new System.Drawing.Point(289, 0);
            this.meterlabel.Name = "meterlabel";
            this.meterlabel.Size = new System.Drawing.Size(29, 25);
            this.meterlabel.TabIndex = 6;
            this.meterlabel.Text = "m";
            // 
            // kiloglabel
            // 
            this.kiloglabel.AutoSize = true;
            this.kiloglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiloglabel.Location = new System.Drawing.Point(289, 102);
            this.kiloglabel.Name = "kiloglabel";
            this.kiloglabel.Size = new System.Drawing.Size(35, 25);
            this.kiloglabel.TabIndex = 7;
            this.kiloglabel.Text = "kg";
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(12, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(135, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial ";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.Location = new System.Drawing.Point(207, 3);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(106, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 442);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.TextBox Heighttext;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.TextBox weighttextBox;
        private System.Windows.Forms.Button BMIbutton;
        private System.Windows.Forms.TextBox Resulttext;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label meterlabel;
        private System.Windows.Forms.Label kiloglabel;
    }
}

