using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using reNamenator;

namespace TheSortingHat
{
    public partial class reNamenator : Form
    {
        TextInfo textInfo = new CultureInfo("en-US", true).TextInfo;
        string tempDir = Path.GetTempPath();
        string logFile = string.Empty;
        bool minimize = false;

        string version = Application.ProductVersion;

        public reNamenator()
        {
            InitializeComponent();
            defaultOptions();
        }

        private void defaultOptions()
        {

            // Characters to Replace
            cb_underScore.Checked = true;
            cb_fullStop.Checked = true;
            cb_dash.Checked = true;
            cb_multiSpace.Checked = true;
            cb_multiSpace.Checked = true;

            // Characters we are replacing with
            rb_space.Checked = true;

            // Casing
            rb_caseTitle.Checked = true;

            // Status
            lbl_dynamic_status.Text = "Ready! - Drop Files or Folders";

            // Prefix and Suffix
            cb_prefix.Checked = false;
            cb_suffix.Checked = false;

        }

        // Enable or Disable the Replacing Custom Characters text Field
        private void rb_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_custom.Checked) {
                tb_customCharReplace.Enabled = true;
            }
            else
            {
                tb_customCharReplace.Enabled = false;
            }
        }

        private void rb_nothing_CheckedChanged(object sender, EventArgs e)
        {
        }
     
        private void rb_space_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Enable or Disable the Custom Characters text Field
        private void cb_customChars_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_customChars.Checked)
            {
                tb_customChars.Enabled = true;
            }
            else
            {
                tb_customChars.Enabled = false;
            }
        }

        private void pnl_main_DragDrop(object sender, DragEventArgs e)
        {
            main(e);
        }

        private void pnl_main_DragEnter(object sender, DragEventArgs e)
        {
            lbl_dynamic_status.Text = "Drop the files!!";
            e.Effect = DragDropEffects.All;
        }

        private void cb_prefix_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_prefix.Checked) {
                tb_prefix.Enabled = true;
            }else
            {
                tb_prefix.Enabled = false;
            }
        }

        private void main(DragEventArgs e)
        {
            string[] dragged_items = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            lbl_dynamic_status.Text = "Processing!";

            for (int i = 0; i < dragged_items.Length; i++)
            {    
                try
                {
                    string oldName = string.Empty;
                    string oldFullPath = string.Empty;
                    string parent = string.Empty;
                    string newName = string.Empty;
                    string extension = string.Empty;
                    bool isFile = false;

                    if (File.Exists(dragged_items[i]))
                    {
                        // This path is a file
                        FileInfo file = new FileInfo(dragged_items[i]);

                        oldName = file.Name;
                        oldFullPath = file.FullName;
                        parent = file.DirectoryName;
                        extension = file.Extension;
                        // Remove the Extension from the filename otherwise the FullStop check will mess with files
                        // Duplicates as a sanitation function for files that stupidly have more than one extension.
                        if (oldName.Contains(file.Extension) && file.Extension != null && file.Extension != "")
                        {
                            oldName = oldName.Replace(file.Extension, "");
                        }

                        isFile = true;

                    }
                    else if (Directory.Exists(dragged_items[i]))
                    {
                        // This path is a directory
                        DirectoryInfo dir = new DirectoryInfo(dragged_items[i]);
                        oldName = dir.Name;
                        oldFullPath = dir.FullName;
                        // Seemingly unavoidable crappy way to get the parent directories path.
                        parent = oldFullPath.Replace("\\"+oldName, "");
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", dragged_items[i]);
                    }

                    // Clean the unwanted chars away
                    newName = Sanitize(oldName);

                    // Set the Case
                    newName = SetCase(newName);

                    // Set Prefix & Suffix
                    newName = SetPreSuffix(newName);

                    // Rename function
                    Rename(oldName, oldFullPath, newName, parent, extension, isFile);

                    // Debug
                    Console.WriteLine(newName);
                    Console.WriteLine(parent);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Has the file or folder suddenly gone missing? \n" + exc, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }

        private void Rename(string oldName, string oldFullName, string newName, string parent, string extension, bool isFile)
        {
            if (newName != oldName)
            {
                string newFullName = string.Empty;

                if (isFile)
                {
                    newFullName = parent + "\\" + newName + extension;
                }
                else
                {
                    newFullName = parent + "\\" + newName;
                }

                string tempFullName = oldFullName + "~";

                // Move to Temporary directory or File to force changes that only involved Case
                try
                {
                    if (isFile) {
                        File.Move(oldFullName, tempFullName);
                    }else
                    {
                        Directory.Move(oldFullName, tempFullName);
                    }                 
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Issue Creating Temporary Directory or File! \n" + tempFullName + "\n" + exc, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Rename the temporary file or folder to the new Name
                try
                {
                    if (isFile)
                    {
                        File.Move(tempFullName, newFullName);
                    }
                    else
                    {
                        Directory.Move(tempFullName, newFullName);
                    }

                    lbl_dynamic_oldName.Text = oldName;
                    lbl_dynamic_NewName.Text = newName;
                    lbl_dynamic_status.Text = "Done! Ready for the next drop :)";
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Issue Renaming the Directory or File! \n" + newFullName + "\n" + exc, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbl_dynamic_status.Text = "Last File/Folder had nothing to change! Ready to go.";
            }
        }

        private string SetPreSuffix(string newName)
        {
            if (cb_prefix.Checked)
            {
                newName = tb_prefix.Text + newName;
            }

            if (cb_suffix.Checked)
            {
                newName = newName + tb_suffix.Text;
            }

            return newName;
        }

        private string Sanitize(string oldName)
        {
            string newNameOut = oldName;
            string replacementString = GetReplacementCharacter();
            string customReplacementString = GetCustomReplacementString();

            // Replace Underscores
            if (cb_underScore.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace("_", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Underscores \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Fullstops
            if (cb_fullStop.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace(".", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing dots \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Dashes
            if (cb_dash.Checked){
                try
                {
                    newNameOut = newNameOut.Replace("-", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Dashes \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Equals
            if (cb_equals.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace("=", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Equals \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Commas
            if (cb_comma.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace(",", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Commas \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Brackets
            if (cb_bracketsNormal.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace("(", replacementString);
                    newNameOut = newNameOut.Replace(")", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Brackets \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Curly Brackets
            if (cb_bracketsCurly.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace("{", replacementString);
                    newNameOut = newNameOut.Replace("}", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Curly Brackets \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Square Brackets
            if (cb_bracketsSquare.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace("[", replacementString);
                    newNameOut = newNameOut.Replace("]", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing Square Brackets \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Custom Chars
            if (cb_customChars.Checked)
            {
                try
                {
                    foreach (char c in customReplacementString)
                    {
                        newNameOut = newNameOut.Replace(c.ToString(), replacementString);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing custom characters \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            // Replace Spaces
            if (cb_space.Checked)
            {
                try
                {
                    newNameOut = newNameOut.Replace(" ", replacementString);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing spaces \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace Multiple Spaces
            // Many of these could be generated by file or folder names that have spaces next to replacement 
            // characters or many replacement characters next to each other, or just silly file names.
            if (cb_multiSpace.Checked)
            {
                try
                { 
                    newNameOut = Regex.Replace(newNameOut, @"\s+", " ");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Replacing multiple spaces \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Char.IsWhiteSpace(newNameOut[0]) || Char.IsWhiteSpace(newNameOut[newNameOut.Length-1]))
            {
                try
                {
                    newNameOut = newNameOut.Trim(' ');
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Trimming a Space from Start or End of String \n" + e, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return newNameOut;
        }

        private string GetCustomReplacementString()
        {
            string replacementCharacter = string.Empty;

            if (cb_customChars.Checked && tb_customChars.Text != null && tb_customChars.Text != "")
            {
                replacementCharacter = tb_customChars.Text;
            }
            return replacementCharacter;
        }

        private string GetReplacementCharacter()
        {
            string replacementCharacter = string.Empty;

            if (rb_space.Checked)
            {
                replacementCharacter = " ";
            }

            if (rb_nothing.Checked)
            {
                replacementCharacter = "";
            }

            if (rb_custom.Checked)
            {
                if (!CheckForIllegalCharacters(tb_customCharReplace))
                {
                    replacementCharacter = tb_customCharReplace.Text;
                }     
            }

            return replacementCharacter;
        }

        private bool CheckForIllegalCharacters(TextBox tb_in)
        {
            bool illegal = false;
            string text_in = tb_in.Text;
            string foundIllegalChars = string.Empty;

            // Lets check for illegal File Name Characters 
            if (text_in != null || text_in == "")
            {
                char[] illegalChars = Path.GetInvalidFileNameChars();

                foreach (char c in illegalChars)
                {
                    if (text_in.Contains(c))
                    {
                        foundIllegalChars += c + " ";
                        illegal = true;
                        text_in = text_in.Replace(c.ToString(), "");
                        tb_in.Text = text_in;
                    }
                }

                if (foundIllegalChars.Length > 0 && foundIllegalChars.Length <= 2)
                {

                    lbl_dynamic_status.ForeColor = Color.Red;
                    lbl_dynamic_status.Text = "Illegal Character detected!";

                    MessageBox.Show(foundIllegalChars + " is an illegal Character for a File or Folder Name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lbl_dynamic_status.ForeColor = Color.FromName("HighLight");
                    lbl_dynamic_status.Text = "Ready! - Drop Files or Folders";
                }

                if (foundIllegalChars.Length > 2)
                {
                    lbl_dynamic_status.ForeColor = Color.Red;
                    lbl_dynamic_status.Text = "Illegal Character detected!";

                    MessageBox.Show(foundIllegalChars + " are illegal Characters for a File or Folder Name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lbl_dynamic_status.ForeColor = Color.FromName("HighLight");
                    lbl_dynamic_status.Text = "Ready! - Drop Files or Folders";
                }
            }
            return illegal;
        }

        private string SetCase(string text_in)
        {
            string text_out = string.Empty;

            if (rb_caseSame.Checked)
            {
                text_out = text_in;
            }
            else if (rb_caseLower.Checked)
            {
                text_out = textInfo.ToLower(text_in);
            }
            else if (rb_caseTitle.Checked)
            {
                text_out = textInfo.ToLower(text_in);
                text_out = textInfo.ToTitleCase(text_out);
            }
            else if (rb_caseUpper.Checked)
            {
                text_out = textInfo.ToLower(text_in);
                text_out = textInfo.ToUpper(text_out);
            }

            return text_out;
        }

        private void tb_customCharReplace_TextChanged(object sender, EventArgs e)
        {
            CheckForIllegalCharacters(tb_customCharReplace);
        }

        private void tb_customChars_TextChanged(object sender, EventArgs e)
        {
            CheckForIllegalCharacters(tb_customChars);
        }

        private void tb_prefix_TextChanged(object sender, EventArgs e)
        {
            CheckForIllegalCharacters(tb_prefix);
        }

        private void tb_suffix_TextChanged(object sender, EventArgs e)
        {
            CheckForIllegalCharacters(tb_suffix);
        }

        private void cb_suffix_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_suffix.Checked)
            {
                tb_suffix.Enabled = true;
            }
            else
            {
                tb_suffix.Enabled = false;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (!minimize)
            {
                this.Size = new Size(204, 140);
                this.MaximumSize = new Size(204, 140);
                this.MinimumSize = new Size(204, 140);

                pnl_names.Visible = pnl_replaceTo.Visible = pnl_replaceWith.Visible = pnl_Status.Visible = false;

                pnl_min.Location = new Point(4, 4);

                btn_min.Text = "Maximize!";
                minimize = true;
            }
            else
            {

                this.Size = new Size(477, 423);
                this.MaximumSize = new Size(477, 423);
                this.MinimumSize = new Size(477, 423);

                pnl_names.Visible = pnl_replaceTo.Visible = pnl_replaceWith.Visible = pnl_Status.Visible = true;

                pnl_min.Location = new Point(268, 243);

                btn_min.Text = "Minimize!";
                minimize = false;
            }

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            About box = new About();           
            box.ShowDialog();
        }
    }
}
