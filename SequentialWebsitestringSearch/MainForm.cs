// https://github.com/gtg154i

using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SequentialWebsiteStringSearch
{
	/// <summary>
	/// The UI and functions are in MainForm class.
	/// </summary>
	public partial class MainForm : Form
	{
		private String CONFIG_PATH = System.Environment.CurrentDirectory + "\\SequentialWebSiteStringSearch.ini";

		private String DEFAULT_RESULTS_PATH = System.Environment.CurrentDirectory + "\\Results\\";

		private Boolean cancelSearch = false;

		private String lastOutputFileName = "";

		/// <summary>
		/// Button for browsing for directory to save results. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowseButtonClick(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				saveFolderBox.Text = folderBrowserDialog.SelectedPath + "\\";
			}
		}

		/// <summary>
		/// Cancel button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButtonClick(object sender, EventArgs e)
		{
			cancelSearch = true;
		}

		/// <summary>
		/// Same as Console.WriteLine but for the textBox consoleBox.
		/// </summary>
		/// <param name="text"></param>
		private void consoleAppendLine(String text)
		{
			consoleBox.AppendText(text + Environment.NewLine);
		}
		
		/// <summary>
		/// Same as Console.WriteLine but for the textBox consoleBox.
		/// </summary>
		private void consoleAppendLine()
		{
			consoleBox.AppendText(Environment.NewLine);
		}

		/// <summary>
		/// Loads default settings.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void loadDefaultsButtonClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Load Default Values?", "Load Default Values?", MessageBoxButtons.YesNo);
			if
				(dialogResult == DialogResult.Yes)
			{
				
				urlBox.Text = "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=*";
				searchTextBox.Text = ", GA";
				skipTextBox.Text = "vehicle purchase";
				stopTextBox.Text = "Page Not Found";
				startBox.Text = "1007";
				endBox.Text = "1040";
				minLengthBox.Text = "0";
				minDelayBox.Text = "250";
				maxDelayBox.Text = "2000";
				saveFolderBox.Text = DEFAULT_RESULTS_PATH;
				lastOutputFileName = "";
				regexPatternBox.Text = "(?i)(gift.*card.*test.*drive)(?-i)[\\s\\S]*(, GA)";
			}
		}
		
		/// <summary>
		/// Loads settings.
		/// </summary>
		private void LoadValues()
		{
			if (File.Exists(CONFIG_PATH))
			{
				String configText = File.ReadAllText(CONFIG_PATH);
				
				String[] configReadLines = configText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
				
				urlBox.Text = configReadLines[0];
				searchTextBox.Text = configReadLines[1];
				skipTextBox.Text = configReadLines[2];
				stopTextBox.Text = configReadLines[3];
				startBox.Text = configReadLines[4];
				endBox.Text = configReadLines[5];
				minLengthBox.Text = configReadLines[6];
				minDelayBox.Text = configReadLines[7];
				maxDelayBox.Text = configReadLines[8];
				saveFolderBox.Text = configReadLines[9];
				regexPatternBox.Text = configReadLines[10];
				lastOutputFileName = configReadLines[11];
				
			}
			
			if (!File.Exists(CONFIG_PATH))
			{
				//no config.ini exists so we take current values and write them into one
				SaveValues();
			}
		}

		/// <summary>
		/// Creates the UI, sets doublebuffered to true to prevent flickering,
		/// sets default path if none exists, and loads values.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			
			DoubleBuffered = true;
			
			//If there's no value we always use this as a default so they don't try
			//to output results to empty path.
			saveFolderBox.Text = DEFAULT_RESULTS_PATH;
			Directory.CreateDirectory(saveFolderBox.Text);
			
			LoadValues();
		}
		
		/// <summary>
		/// Saves settings on exit.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveValues();
		}
		
		/// <summary>
		/// Prevents input of non number values into the number fields.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnlyNumbersKeyPress(object sender, KeyPressEventArgs e)
		{
			
			//only allow numbers
			var regex = new Regex(@"[^0-9\b]");
			if (regex.IsMatch(e.KeyChar.ToString()))
			{
				e.Handled = true;
				return;
			}
		}

		/// <summary>
		/// Opens last results of sequential website string search.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenResultsButtonClick(object sender, EventArgs e)
		{
			if (lastOutputFileName.Length == 0)
			{
				MessageBox.Show("Output file does not exist. Run a search first.");
				return;
			}
			
			if (File.Exists(lastOutputFileName))
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() {
				                                 	FileName = lastOutputFileName,
				                                 	UseShellExecute = true,
				                                 	Verb = "open"
				                                 });
			}
			else
			{
				MessageBox.Show("Output file does not exist. Run a search first.");
			}
			
		}
		
		/// <summary>
		/// Opens folder where sequential website string search results are stored.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenResultsFolderButtonClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() {
			                                 	FileName = saveFolderBox.Text,
			                                 	UseShellExecute = true,
			                                 	Verb = "open"
			                                 });
		}
		
		/// <summary>
		/// Searches using Regex pattern.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="evArgs"></param>
		private async void RegexSearchButtonClick(object sender, EventArgs evArgs)
		{
			Directory.CreateDirectory(saveFolderBox.Text);
			
			String outputFileName = String.Format("{0:yyyyMMddtHHmmss}", DateTime.Now) + ".html";
			
			cancelSearch = false;
			
			consoleBox.Text = "";
			consoleBox.Refresh();
			
			string html = string.Empty;

			int minLengthInt = Convert.ToInt32(minLengthBox.Text);
			
			int minDelayInt = Convert.ToInt32(minDelayBox.Text);
			
			int maxDelayInt = Convert.ToInt32(maxDelayBox.Text);
			
			if (minDelayInt > maxDelayInt)
				minDelayInt = maxDelayInt;
			
			if (maxDelayInt < minDelayInt)
				maxDelayInt = minDelayInt;
			
			Random rnd = new Random();
			
			ArrayList found = new ArrayList();
			
			int start = Convert.ToInt32(startBox.Text);
			int end = Convert.ToInt32(endBox.Text);
			
			if (start > end)
			{
				int temp = end;
				end = start;
				start = temp;
				startBox.Text = start.ToString();
				endBox.Text = end.ToString();
			}
			
			String pattern = regexPatternBox.Text;
			
			String results = "RESULTS: ";
			String url = "";
			
			consoleAppendLine(urlBox.Text);
			consoleAppendLine();
			consoleAppendLine("Searching pages " + start + " to " + end + " for Regex pattern " + pattern);
			consoleAppendLine();
			
			for (int i = start;i <= end;i++)
			{
				if (cancelSearch)
					break;
				html = string.Empty;
				
				//url = @"https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=" + i.ToString();
				
				String number = i.ToString();
				
				//add on the 0's if they specify minimum length
				while (number.Length < minLengthInt)
				{
					number = "0" + number;
				}
				
				//turn a URL such as "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=*"
				//into "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=1025"
				url = urlBox.Text.Replace("*",number);
				
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

				//Sleep a random amount between min and max in ms to prevent
				//server from thinking we are hammering
				int delay = rnd.Next(minDelayInt, maxDelayInt);
				await Task.Delay(delay);
				
				try
				{
					using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
						using (Stream stream = response.GetResponseStream())
							using (StreamReader reader = new StreamReader(stream))
					{
						
						html = reader.ReadToEnd();
					}
					if (System.Text.RegularExpressions.Regex.IsMatch(html, pattern))
					{
						results += " " + i;
						found.Add(number);
						consoleAppendLine(number + " FOUND");
					}
					else
						consoleAppendLine("\t\t" + number + " NOT FOUND");
				}
				catch (SystemException e)
				{
					consoleAppendLine("\t\t" + number + " " + e.Message);
				}
			}
			
			consoleAppendLine();
			consoleAppendLine(results);
			consoleAppendLine();
			
			if (found.Count > 0)
			{
				String outputContents = results + Environment.NewLine + "<br><br>" + Environment.NewLine;
				
				for (int i = 0;i < found.Count;i++)
				{
					url = urlBox.Text.Replace("*",(String)found[i]);
					consoleAppendLine(url);
					
					outputContents += "<a href=\"";
					outputContents += url;
					outputContents += "\">";
					outputContents += url;
					outputContents += "</a>";
					outputContents += Environment.NewLine;
					outputContents += "<br><br>";
					outputContents += Environment.NewLine;
					
					consoleAppendLine();
				}
				
				lastOutputFileName = saveFolderBox.Text + outputFileName;
				
				consoleAppendLine("Saved results to " + lastOutputFileName);
				
				File.WriteAllText(lastOutputFileName, outputContents);
			}
			else
				consoleAppendLine("No results found.");
		}
	
		/// <summary>
		/// Saves settings. Called during program exit.
		/// </summary>
		private void SaveValues()
		{
			String url = urlBox.Text;
			String searchText = searchTextBox.Text;
			String skipText = skipTextBox.Text;
			String stopText = stopTextBox.Text;
			String start = startBox.Text;
			String end = endBox.Text;
			String minLength = minLengthBox.Text;
			String minDelay = minDelayBox.Text;
			String maxDelay = maxDelayBox.Text;
			String saveFolder = saveFolderBox.Text;
			String regexPattern = regexPatternBox.Text;
			String lastOutput = lastOutputFileName;
			
			String configText = "";
			configText += url + Environment.NewLine;
			configText += searchText + Environment.NewLine;
			configText += skipText + Environment.NewLine;
			configText += stopText + Environment.NewLine;
			configText += start + Environment.NewLine;
			configText += end + Environment.NewLine;
			configText += minLength + Environment.NewLine;
			configText += minDelay + Environment.NewLine;
			configText += maxDelay + Environment.NewLine;
			configText += saveFolder + Environment.NewLine;
			configText += regexPattern + Environment.NewLine;
			configText += lastOutput;
			File.WriteAllText(CONFIG_PATH, configText);
		}

		/// <summary>
		/// Performs the string search based on include, exclude, stop criteria.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="evArgs"></param>
		private async void StartButtonClick(object sender, EventArgs evArgs)
		{
			Directory.CreateDirectory(saveFolderBox.Text);
			
			String outputFileName = String.Format("{0:yyyyMMddtHHmmss}", DateTime.Now) + ".html";
			
			cancelSearch = false;
			
			consoleBox.Text = "";
			consoleBox.Refresh();
			
			string html = string.Empty;

			int minLengthInt = Convert.ToInt32(minLengthBox.Text);
			
			int minDelayInt = Convert.ToInt32(minDelayBox.Text);
			
			int maxDelayInt = Convert.ToInt32(maxDelayBox.Text);
			
			if (minDelayInt > maxDelayInt)
				minDelayInt = maxDelayInt;
			
			if (maxDelayInt < minDelayInt)
				maxDelayInt = minDelayInt;
			
			Random rnd = new Random();
			
			ArrayList found = new ArrayList();
			
			int start = Convert.ToInt32(startBox.Text);
			int end = Convert.ToInt32(endBox.Text);
			
			if (start > end)
			{
				int temp = end;
				end = start;
				start = temp;
				startBox.Text = start.ToString();
				endBox.Text = end.ToString();
			}
			
			String reportCriteria = searchTextBox.Text;
			String skipCriteria = skipTextBox.Text;
			String stopCriteria = stopTextBox.Text;
			
			String results = "RESULTS: ";
			String url = "";
			
			consoleAppendLine(urlBox.Text);
			consoleAppendLine();
			consoleAppendLine("Searching pages " + start + " to " + end + " for " + reportCriteria
			                  + " excluding " + skipCriteria + " stopping if found " + stopCriteria);
			consoleAppendLine();
			
			for (int i = start;i <= end;i++)
			{
				if (cancelSearch)
					break;
				html = string.Empty;
				
				//url = @"https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=" + i.ToString();
				
				String number = i.ToString();
				
				//add on the 0's if they specify minimum length
				while (number.Length < minLengthInt)
				{
					number = "0" + number;
				}
				
				//turn a URL such as "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=*"
				//into "https://www.cargurus.com/Cars/promos/viewPromotion.action?promotion=1025"
				url = urlBox.Text.Replace("*",number);
				
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

				//Sleep a random amount between min and max in ms to prevent
				//server from thinking we are hammering
				int delay = rnd.Next(minDelayInt, maxDelayInt);
				await Task.Delay(delay);
				
				try
				{
					using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
						using (Stream stream = response.GetResponseStream())
							using (StreamReader reader = new StreamReader(stream))
					{
						
						html = reader.ReadToEnd();
					}
					if (stopCriteria.Length > 0)
					{
						if (html.Contains(stopCriteria))
						{
							consoleAppendLine("\t\t" + number + " STOPPED");
							break;
						}
					}
					if (skipCriteria.Length > 0)
					{
						if (html.Contains(skipCriteria))
						{
							consoleAppendLine("\t\t" + number + " SKIPPED");
							continue;
						}
					}
					if (html.Contains(reportCriteria))
					{
						results += " " + i;
						found.Add(number);
						consoleAppendLine(number + " FOUND");
					}
					else
						consoleAppendLine("\t\t" + number + " NOT FOUND");
				}
				catch (SystemException e)
				{
					consoleAppendLine("\t\t" + number + " " + e.Message);
				}
			}
			
			consoleAppendLine();
			consoleAppendLine(results);
			consoleAppendLine();
			
			String outputContents = results + Environment.NewLine + "<br><br>" + Environment.NewLine;
			
			if (found.Count > 0)
			{
				for (int i = 0;i < found.Count;i++)
				{
					url = urlBox.Text.Replace("*",(String)found[i]);
					consoleAppendLine(url);
					
					outputContents += "<a href=\"";
					outputContents += url;
					outputContents += "\">";
					outputContents += url;
					outputContents += "</a>";
					outputContents += Environment.NewLine;
					outputContents += "<br><br>";
					outputContents += Environment.NewLine;
					
					consoleAppendLine();
				}
				
				lastOutputFileName = saveFolderBox.Text + outputFileName;
				
				consoleAppendLine("Saved results to " + lastOutputFileName);
				
				File.WriteAllText(lastOutputFileName, outputContents);
			}
			else
				consoleAppendLine("No results found.");
		}

	}

}