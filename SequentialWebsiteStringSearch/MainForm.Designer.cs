// https://github.com/gtg154i

namespace SequentialWebsiteStringSearch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox startBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox endBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox minLengthBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox minDelayBox;
		private System.Windows.Forms.TextBox maxDelayBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox saveFolderBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox skipTextBox;
		private System.Windows.Forms.Button loadDefaultsButton;
		private System.Windows.Forms.TextBox consoleBox;
		private System.Windows.Forms.Button openResultsFolderButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button openResultsButton;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox stopTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox regexPatternBox;
		private System.Windows.Forms.Button regexSearchButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.startBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.endBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.minLengthBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.minDelayBox = new System.Windows.Forms.TextBox();
			this.maxDelayBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.saveFolderBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.skipTextBox = new System.Windows.Forms.TextBox();
			this.loadDefaultsButton = new System.Windows.Forms.Button();
			this.consoleBox = new System.Windows.Forms.TextBox();
			this.openResultsFolderButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.openResultsButton = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.stopTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.regexPatternBox = new System.Windows.Forms.TextBox();
			this.regexSearchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// urlBox
			// 
			this.urlBox.Location = new System.Drawing.Point(80, 0);
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(932, 26);
			this.urlBox.TabIndex = 1;
			this.urlBox.Text = "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=*";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1012, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "The * in URL will be replaced by numbers starting from Start and ending at End.";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "Start:";
			// 
			// startBox
			// 
			this.startBox.Location = new System.Drawing.Point(80, 128);
			this.startBox.Name = "startBox";
			this.startBox.Size = new System.Drawing.Size(356, 26);
			this.startBox.TabIndex = 10;
			this.startBox.Text = "1007";
			this.startBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersKeyPress);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(436, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 32);
			this.label4.TabIndex = 11;
			this.label4.Text = "End:";
			// 
			// endBox
			// 
			this.endBox.Location = new System.Drawing.Point(512, 128);
			this.endBox.Name = "endBox";
			this.endBox.Size = new System.Drawing.Size(356, 26);
			this.endBox.TabIndex = 12;
			this.endBox.Text = "1040";
			this.endBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersKeyPress);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(0, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(340, 32);
			this.label5.TabIndex = 13;
			this.label5.Text = "Minimum Number Length:";
			// 
			// minLengthBox
			// 
			this.minLengthBox.Location = new System.Drawing.Point(336, 160);
			this.minLengthBox.Name = "minLengthBox";
			this.minLengthBox.Size = new System.Drawing.Size(44, 26);
			this.minLengthBox.TabIndex = 14;
			this.minLengthBox.Text = "0";
			this.minLengthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersKeyPress);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(386, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(584, 32);
			this.label6.TabIndex = 15;
			this.label6.Text = "(for example 2 will make it count 01, 02, 03...)";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(520, 32);
			this.label7.TabIndex = 16;
			this.label7.Text = "Minimum Delay Between Requests(ms):";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(562, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(281, 32);
			this.label8.TabIndex = 18;
			this.label8.Text = "Maximum Delay(ms):";
			// 
			// minDelayBox
			// 
			this.minDelayBox.Location = new System.Drawing.Point(512, 192);
			this.minDelayBox.Name = "minDelayBox";
			this.minDelayBox.Size = new System.Drawing.Size(44, 26);
			this.minDelayBox.TabIndex = 17;
			this.minDelayBox.Text = "250";
			this.minDelayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersKeyPress);
			// 
			// maxDelayBox
			// 
			this.maxDelayBox.Location = new System.Drawing.Point(835, 192);
			this.maxDelayBox.Name = "maxDelayBox";
			this.maxDelayBox.Size = new System.Drawing.Size(44, 26);
			this.maxDelayBox.TabIndex = 19;
			this.maxDelayBox.Text = "2000";
			this.maxDelayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersKeyPress);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(0, 224);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(232, 32);
			this.label9.TabIndex = 20;
			this.label9.Text = "Save Results To:";
			// 
			// saveFolderBox
			// 
			this.saveFolderBox.Location = new System.Drawing.Point(225, 224);
			this.saveFolderBox.Name = "saveFolderBox";
			this.saveFolderBox.Size = new System.Drawing.Size(786, 26);
			this.saveFolderBox.TabIndex = 21;
			// 
			// browseButton
			// 
			this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseButton.Location = new System.Drawing.Point(560, 272);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(452, 48);
			this.browseButton.TabIndex = 24;
			this.browseButton.Text = "Browse for Save Results Directory";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(0, 272);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(180, 48);
			this.startButton.TabIndex = 22;
			this.startButton.Text = "Start Search";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(0, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(164, 32);
			this.label10.TabIndex = 3;
			this.label10.Text = "Search For:";
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(160, 64);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(852, 26);
			this.searchTextBox.TabIndex = 4;
			this.searchTextBox.Text = ", GA";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(0, 96);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(292, 32);
			this.label11.TabIndex = 5;
			this.label11.Text = "Exclude If Containing:";
			// 
			// skipTextBox
			// 
			this.skipTextBox.Location = new System.Drawing.Point(292, 96);
			this.skipTextBox.Name = "skipTextBox";
			this.skipTextBox.Size = new System.Drawing.Size(246, 26);
			this.skipTextBox.TabIndex = 6;
			this.skipTextBox.Text = "vehicle purchase";
			// 
			// loadDefaultsButton
			// 
			this.loadDefaultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadDefaultsButton.Location = new System.Drawing.Point(730, 336);
			this.loadDefaultsButton.Name = "loadDefaultsButton";
			this.loadDefaultsButton.Size = new System.Drawing.Size(282, 48);
			this.loadDefaultsButton.TabIndex = 27;
			this.loadDefaultsButton.Text = "Load Default Values";
			this.loadDefaultsButton.UseVisualStyleBackColor = true;
			this.loadDefaultsButton.Click += new System.EventHandler(this.loadDefaultsButtonClick);
			// 
			// consoleBox
			// 
			this.consoleBox.Location = new System.Drawing.Point(0, 460);
			this.consoleBox.Multiline = true;
			this.consoleBox.Name = "consoleBox";
			this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.consoleBox.Size = new System.Drawing.Size(1012, 264);
			this.consoleBox.TabIndex = 31;
			// 
			// openResultsFolderButton
			// 
			this.openResultsFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openResultsFolderButton.Location = new System.Drawing.Point(0, 336);
			this.openResultsFolderButton.Name = "openResultsFolderButton";
			this.openResultsFolderButton.Size = new System.Drawing.Size(388, 48);
			this.openResultsFolderButton.TabIndex = 25;
			this.openResultsFolderButton.Text = "Open Save Results Directory";
			this.openResultsFolderButton.UseVisualStyleBackColor = true;
			this.openResultsFolderButton.Click += new System.EventHandler(this.OpenResultsFolderButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(186, 272);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(210, 48);
			this.cancelButton.TabIndex = 23;
			this.cancelButton.Text = "Cancel Search";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// openResultsButton
			// 
			this.openResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openResultsButton.Location = new System.Drawing.Point(436, 336);
			this.openResultsButton.Name = "openResultsButton";
			this.openResultsButton.Size = new System.Drawing.Size(256, 48);
			this.openResultsButton.TabIndex = 26;
			this.openResultsButton.Text = "Open Last Results";
			this.openResultsButton.UseVisualStyleBackColor = true;
			this.openResultsButton.Click += new System.EventHandler(this.OpenResultsButtonClick);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(544, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(184, 32);
			this.label12.TabIndex = 7;
			this.label12.Text = "Stop if found:";
			// 
			// stopTextBox
			// 
			this.stopTextBox.Location = new System.Drawing.Point(724, 96);
			this.stopTextBox.Name = "stopTextBox";
			this.stopTextBox.Size = new System.Drawing.Size(287, 26);
			this.stopTextBox.TabIndex = 8;
			this.stopTextBox.Text = "Page Not Found";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(0, 396);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(302, 32);
			this.label13.TabIndex = 28;
			this.label13.Text = "Regex Search Pattern:";
			// 
			// regexPatternBox
			// 
			this.regexPatternBox.Location = new System.Drawing.Point(308, 396);
			this.regexPatternBox.Name = "regexPatternBox";
			this.regexPatternBox.Size = new System.Drawing.Size(495, 26);
			this.regexPatternBox.TabIndex = 29;
			this.regexPatternBox.Text = "(?i)(gift.*card.*test.*drive)(?-i)[\\s\\S]*(, GA)";
			// 
			// regexSearchButton
			// 
			this.regexSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regexSearchButton.Location = new System.Drawing.Point(809, 396);
			this.regexSearchButton.Name = "regexSearchButton";
			this.regexSearchButton.Size = new System.Drawing.Size(202, 48);
			this.regexSearchButton.TabIndex = 30;
			this.regexSearchButton.Text = "Regex Search";
			this.regexSearchButton.UseVisualStyleBackColor = true;
			this.regexSearchButton.Click += new System.EventHandler(this.RegexSearchButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 730);
			this.Controls.Add(this.regexSearchButton);
			this.Controls.Add(this.regexPatternBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.stopTextBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.openResultsButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.openResultsFolderButton);
			this.Controls.Add(this.consoleBox);
			this.Controls.Add(this.loadDefaultsButton);
			this.Controls.Add(this.skipTextBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.saveFolderBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.maxDelayBox);
			this.Controls.Add(this.minDelayBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.minLengthBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.endBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.startBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.urlBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Sequential Website String Search by github.com/gtg154i";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
