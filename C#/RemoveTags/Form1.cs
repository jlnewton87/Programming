using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace RemoveTags
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      public string targetDirectory;

      private void btnSelectTargetDirectory_Click(object sender, EventArgs e)
      {
         fbdTaggedDocument.RootFolder = System.Environment.SpecialFolder.Desktop;
         fbdTaggedDocument.ShowDialog();
         this.targetDirectory = fbdTaggedDocument.SelectedPath;
         lblTargetDirectory.Text = this.targetDirectory;
      }

      private void btnRemoveTags_Click(object sender, EventArgs e)
      {
         string[] allFiles = Directory.GetFiles(this.targetDirectory);
         List<string> listAllFiles = allFiles.ToList();
         DialogResult result = MessageBox.Show("Are you sure you want to remove tags from " + listAllFiles.Count + "Files?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
         if (result == DialogResult.Yes)
         {

            foreach (var i in listAllFiles)
            {
               removeTags(i);
            }
            MessageBox.Show("Tags Removed!", "Complete");
         }
         else
            MessageBox.Show("Operation Aborted");
      }

      public void removeTags(string p_Path)
      {
         var shellFile = ShellFile.FromFilePath(p_Path);
         shellFile.Properties.System.Keywords.ClearValue();
      }

   }
}
