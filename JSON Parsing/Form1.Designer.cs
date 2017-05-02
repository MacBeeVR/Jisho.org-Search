namespace JSON_Parsing
{
    partial class searchWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.japaneseWord = new System.Windows.Forms.TextBox();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.wordDetailBox = new System.Windows.Forms.GroupBox();
            this.tags = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reading = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.definition = new System.Windows.Forms.Label();
            this.partOfSpeechGroup = new System.Windows.Forms.GroupBox();
            this.wordTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otherFormsBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.wordDetailBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.partOfSpeechGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Term:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // japaneseWord
            // 
            this.japaneseWord.Location = new System.Drawing.Point(159, 13);
            this.japaneseWord.Name = "japaneseWord";
            this.japaneseWord.Size = new System.Drawing.Size(154, 20);
            this.japaneseWord.TabIndex = 3;
            // 
            // wordListBox
            // 
            this.wordListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.Location = new System.Drawing.Point(12, 54);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(141, 433);
            this.wordListBox.TabIndex = 4;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(319, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 21);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wordDetailBox
            // 
            this.wordDetailBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wordDetailBox.Controls.Add(this.info);
            this.wordDetailBox.Controls.Add(this.label6);
            this.wordDetailBox.Controls.Add(this.subtag);
            this.wordDetailBox.Controls.Add(this.label5);
            this.wordDetailBox.Controls.Add(this.partOfSpeechGroup);
            this.wordDetailBox.Controls.Add(this.groupBox2);
            this.wordDetailBox.Controls.Add(this.tags);
            this.wordDetailBox.Controls.Add(this.label4);
            this.wordDetailBox.Controls.Add(this.reading);
            this.wordDetailBox.Controls.Add(this.word);
            this.wordDetailBox.Controls.Add(this.label3);
            this.wordDetailBox.Controls.Add(this.label2);
            this.wordDetailBox.Location = new System.Drawing.Point(159, 50);
            this.wordDetailBox.MaximumSize = new System.Drawing.Size(318, 1000);
            this.wordDetailBox.MinimumSize = new System.Drawing.Size(258, 114);
            this.wordDetailBox.Name = "wordDetailBox";
            this.wordDetailBox.Size = new System.Drawing.Size(318, 309);
            this.wordDetailBox.TabIndex = 6;
            this.wordDetailBox.TabStop = false;
            this.wordDetailBox.Text = "Word Details";
            // 
            // tags
            // 
            this.tags.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tags.Location = new System.Drawing.Point(84, 79);
            this.tags.MaximumSize = new System.Drawing.Size(227, 23);
            this.tags.MinimumSize = new System.Drawing.Size(167, 23);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(227, 23);
            this.tags.TabIndex = 8;
            this.tags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tags:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reading
            // 
            this.reading.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reading.Location = new System.Drawing.Point(84, 51);
            this.reading.MaximumSize = new System.Drawing.Size(227, 23);
            this.reading.MinimumSize = new System.Drawing.Size(167, 23);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(227, 23);
            this.reading.TabIndex = 4;
            this.reading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.word.Location = new System.Drawing.Point(84, 20);
            this.word.MaximumSize = new System.Drawing.Size(227, 23);
            this.word.MinimumSize = new System.Drawing.Size(167, 23);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(227, 23);
            this.word.TabIndex = 3;
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reading:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Word:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.definition);
            this.groupBox1.Location = new System.Drawing.Point(159, 365);
            this.groupBox1.MaximumSize = new System.Drawing.Size(318, 1000);
            this.groupBox1.MinimumSize = new System.Drawing.Size(258, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definition (Based on Word Type)";
            // 
            // definition
            // 
            this.definition.Location = new System.Drawing.Point(7, 16);
            this.definition.MaximumSize = new System.Drawing.Size(304, 1000);
            this.definition.MinimumSize = new System.Drawing.Size(244, 87);
            this.definition.Name = "definition";
            this.definition.Size = new System.Drawing.Size(304, 103);
            this.definition.TabIndex = 0;
            // 
            // partOfSpeechGroup
            // 
            this.partOfSpeechGroup.Controls.Add(this.wordTypeComboBox);
            this.partOfSpeechGroup.Location = new System.Drawing.Point(10, 246);
            this.partOfSpeechGroup.MaximumSize = new System.Drawing.Size(318, 52);
            this.partOfSpeechGroup.MinimumSize = new System.Drawing.Size(258, 52);
            this.partOfSpeechGroup.Name = "partOfSpeechGroup";
            this.partOfSpeechGroup.Size = new System.Drawing.Size(301, 52);
            this.partOfSpeechGroup.TabIndex = 8;
            this.partOfSpeechGroup.TabStop = false;
            this.partOfSpeechGroup.Text = "Word Type";
            // 
            // wordTypeComboBox
            // 
            this.wordTypeComboBox.FormattingEnabled = true;
            this.wordTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.wordTypeComboBox.Name = "wordTypeComboBox";
            this.wordTypeComboBox.Size = new System.Drawing.Size(289, 21);
            this.wordTypeComboBox.TabIndex = 0;
            this.wordTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.wordTypeBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherFormsBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 191);
            this.groupBox2.MaximumSize = new System.Drawing.Size(318, 49);
            this.groupBox2.MinimumSize = new System.Drawing.Size(258, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Forms";
            // 
            // otherFormsBox
            // 
            this.otherFormsBox.FormattingEnabled = true;
            this.otherFormsBox.Location = new System.Drawing.Point(6, 20);
            this.otherFormsBox.MaximumSize = new System.Drawing.Size(301, 0);
            this.otherFormsBox.MinimumSize = new System.Drawing.Size(241, 0);
            this.otherFormsBox.Name = "otherFormsBox";
            this.otherFormsBox.Size = new System.Drawing.Size(289, 21);
            this.otherFormsBox.TabIndex = 0;
            this.otherFormsBox.SelectedIndexChanged += new System.EventHandler(this.otherFormsBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtags:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtag
            // 
            this.subtag.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subtag.Location = new System.Drawing.Point(84, 110);
            this.subtag.MaximumSize = new System.Drawing.Size(227, 23);
            this.subtag.MinimumSize = new System.Drawing.Size(167, 23);
            this.subtag.Name = "subtag";
            this.subtag.Size = new System.Drawing.Size(227, 23);
            this.subtag.TabIndex = 11;
            this.subtag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Info:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.info.Location = new System.Drawing.Point(84, 140);
            this.info.MaximumSize = new System.Drawing.Size(227, 23);
            this.info.MinimumSize = new System.Drawing.Size(167, 23);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(227, 23);
            this.info.TabIndex = 13;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wordDetailBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.japaneseWord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 10000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 0);
            this.Name = "searchWindow";
            this.Text = "Jisho.org Quick Search";
            this.Load += new System.EventHandler(this.searchWindow_Load);
            this.wordDetailBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.partOfSpeechGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox japaneseWord;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox wordDetailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reading;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label tags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label definition;
        private System.Windows.Forms.GroupBox partOfSpeechGroup;
        private System.Windows.Forms.ComboBox wordTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox otherFormsBox;
        private System.Windows.Forms.Label subtag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label6;
    }
}

