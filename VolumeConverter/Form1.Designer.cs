namespace VolumeConverter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.initVolTextBox = new System.Windows.Forms.TextBox();
            this.answerVolTextBox = new System.Windows.Forms.TextBox();
            this.convertingFromTextBox = new System.Windows.Forms.ComboBox();
            this.convertToDropDown = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.initVolLabel = new System.Windows.Forms.Label();
            this.answerVolumeLabel = new System.Windows.Forms.Label();
            this.convertingFromLable = new System.Windows.Forms.Label();
            this.convertingToLabel = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(309, 269);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(440, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // initVolTextBox
            // 
            this.initVolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initVolTextBox.Location = new System.Drawing.Point(193, 211);
            this.initVolTextBox.Name = "initVolTextBox";
            this.initVolTextBox.Size = new System.Drawing.Size(189, 23);
            this.initVolTextBox.TabIndex = 2;
            // 
            // answerVolTextBox
            // 
            this.answerVolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerVolTextBox.Location = new System.Drawing.Point(452, 211);
            this.answerVolTextBox.Name = "answerVolTextBox";
            this.answerVolTextBox.Size = new System.Drawing.Size(189, 23);
            this.answerVolTextBox.TabIndex = 3;
            // 
            // convertingFromTextBox
            // 
            this.convertingFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingFromTextBox.FormattingEnabled = true;
            this.convertingFromTextBox.Location = new System.Drawing.Point(225, 127);
            this.convertingFromTextBox.Name = "convertingFromTextBox";
            this.convertingFromTextBox.Size = new System.Drawing.Size(121, 24);
            this.convertingFromTextBox.TabIndex = 4;
            // 
            // convertToDropDown
            // 
            this.convertToDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertToDropDown.FormattingEnabled = true;
            this.convertToDropDown.Location = new System.Drawing.Point(486, 127);
            this.convertToDropDown.Name = "convertToDropDown";
            this.convertToDropDown.Size = new System.Drawing.Size(121, 24);
            this.convertToDropDown.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(621, 39);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Convert From One Volume to Another";
            // 
            // initVolLabel
            // 
            this.initVolLabel.AutoSize = true;
            this.initVolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initVolLabel.Location = new System.Drawing.Point(194, 165);
            this.initVolLabel.Name = "initVolLabel";
            this.initVolLabel.Size = new System.Drawing.Size(190, 31);
            this.initVolLabel.TabIndex = 7;
            this.initVolLabel.Text = "Initial Volume";
            // 
            // answerVolumeLabel
            // 
            this.answerVolumeLabel.AutoSize = true;
            this.answerVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerVolumeLabel.Location = new System.Drawing.Point(446, 165);
            this.answerVolumeLabel.Name = "answerVolumeLabel";
            this.answerVolumeLabel.Size = new System.Drawing.Size(216, 31);
            this.answerVolumeLabel.TabIndex = 8;
            this.answerVolumeLabel.Text = "Answer Volume";
            // 
            // convertingFromLable
            // 
            this.convertingFromLable.AutoSize = true;
            this.convertingFromLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingFromLable.Location = new System.Drawing.Point(201, 99);
            this.convertingFromLable.Name = "convertingFromLable";
            this.convertingFromLable.Size = new System.Drawing.Size(172, 25);
            this.convertingFromLable.TabIndex = 9;
            this.convertingFromLable.Text = "Converting From";
            // 
            // convertingToLabel
            // 
            this.convertingToLabel.AutoSize = true;
            this.convertingToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingToLabel.Location = new System.Drawing.Point(472, 99);
            this.convertingToLabel.Name = "convertingToLabel";
            this.convertingToLabel.Size = new System.Drawing.Size(149, 25);
            this.convertingToLabel.TabIndex = 10;
            this.convertingToLabel.Text = "Converting To";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(VolumeConverter.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(VolumeConverter.Form1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(841, 357);
            this.Controls.Add(this.convertingToLabel);
            this.Controls.Add(this.convertingFromLable);
            this.Controls.Add(this.answerVolumeLabel);
            this.Controls.Add(this.initVolLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.convertToDropDown);
            this.Controls.Add(this.convertingFromTextBox);
            this.Controls.Add(this.answerVolTextBox);
            this.Controls.Add(this.initVolTextBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume Converter";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox initVolTextBox;
        private System.Windows.Forms.TextBox answerVolTextBox;
        private System.Windows.Forms.ComboBox convertingFromTextBox;
        private System.Windows.Forms.ComboBox convertToDropDown;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label initVolLabel;
        private System.Windows.Forms.Label answerVolumeLabel;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Label convertingFromLable;
        private System.Windows.Forms.Label convertingToLabel;
    }
}

