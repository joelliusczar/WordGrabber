using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexGetColumnNames
{
    public partial class Form1 : Form
    {
        List<Match> formatList = new List<Match>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRegex_TextChanged(object sender, EventArgs e)
        {
            WorkThatRegexMagic();
            
        }

        private void textBoxFormat_TextChanged(object sender, EventArgs e)
        {
            labelFormatError.Visible = false;
            StringBuilder outputStringBuilder = new StringBuilder();
            try
            {
                
                foreach (Match m in formatList)
                {
                    Object[] groups = ConvertGroupCollectionToArray(m);
                    outputStringBuilder.AppendLine(string.Format(textBoxFormat.Text, groups));
                }
            }
            catch (FormatException ex)
            {
                labelFormatError.Visible = true;
            }

            richTextBoxOutput.Text = outputStringBuilder.ToString();
        }

        /// <summary>
        /// Uses a regex expression that the user entered into the regex textbox and finds matches inside the input textbox and then inserts those matches into format textbox
        /// </summary>
        private void WorkThatRegexMagic()
        {
            int count = 0;
            labelRegexError.Visible = false;
            labelFormatError.Visible = false;
            labelResultCount.Text = string.Format("Results: {0}", count);
            formatList.Clear();
            StringBuilder resultStringBuilder = new StringBuilder();
            StringBuilder outputStringBuilder = new StringBuilder();
            HashSet<string> uniqueMatches = new HashSet<string>();
            try
            {
               Match match = Regex.Match(richTextBoxInput.Text, textBoxRegex.Text);
                while (match.Success)
                {
                    if (!uniqueMatches.Contains(match.Value)||!checkBoxDuplicates.Checked) 
                    {
                        uniqueMatches.Add(match.Value);
                        formatList.Add(match);
                        resultStringBuilder.AppendLine(match.Value);
                        try
                        {
                            Object[] groups = ConvertGroupCollectionToArray(match);
                            outputStringBuilder.AppendLine(string.Format(textBoxFormat.Text, groups));
                        }
                        catch (FormatException ex)
                        {
                            labelFormatError.Visible = true;
                        }
                        count++;
                    }
                    match = match.NextMatch();
                    
                }
                labelResultCount.Text = string.Format("Results: {0}", count);
                richTextBoxOutput.Text = outputStringBuilder.ToString();
                richTextBoxResults.Text = resultStringBuilder.ToString();
            }
            catch (ArgumentException ex)
            {
                labelRegexError.Visible = true;
            }
            
        }

        /// <summary>
        /// We need our group collection to be an array of objects so that we can print them
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        private static object[] ConvertGroupCollectionToArray(Match match)
        {
            Object[] groups = new Object[match.Groups.Count];
            match.Groups.CopyTo(groups, 0);
            return groups;
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            WorkThatRegexMagic();
        }

        private void checkBoxDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            WorkThatRegexMagic();
        }
    }
}
