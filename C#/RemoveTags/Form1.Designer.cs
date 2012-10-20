namespace RemoveTags
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
         this.fbdTaggedDocument = new System.Windows.Forms.FolderBrowserDialog();
         this.btnSelectTargetDirectory = new System.Windows.Forms.Button();
         this.lblTargetDirectory = new System.Windows.Forms.Label();
         this.btnRemoveTags = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnSelectTargetDirectory
         // 
         this.btnSelectTargetDirectory.Location = new System.Drawing.Point(426, 5);
         this.btnSelectTargetDirectory.Name = "btnSelectTargetDirectory";
         this.btnSelectTargetDirectory.Size = new System.Drawing.Size(75, 35);
         this.btnSelectTargetDirectory.TabIndex = 0;
         this.btnSelectTargetDirectory.Text = "Browse";
         this.btnSelectTargetDirectory.UseVisualStyleBackColor = true;
         this.btnSelectTargetDirectory.Click += new System.EventHandler(this.btnSelectTargetDirectory_Click);
         // 
         // lblTargetDirectory
         // 
         this.lblTargetDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblTargetDirectory.Location = new System.Drawing.Point(13, 13);
         this.lblTargetDirectory.Name = "lblTargetDirectory";
         this.lblTargetDirectory.Size = new System.Drawing.Size(407, 23);
         this.lblTargetDirectory.TabIndex = 1;
         this.lblTargetDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnRemoveTags
         // 
         this.btnRemoveTags.Location = new System.Drawing.Point(210, 60);
         this.btnRemoveTags.Name = "btnRemoveTags";
         this.btnRemoveTags.Size = new System.Drawing.Size(98, 23);
         this.btnRemoveTags.TabIndex = 2;
         this.btnRemoveTags.Text = "Remove Tags";
         this.btnRemoveTags.UseVisualStyleBackColor = true;
         this.btnRemoveTags.Click += new System.EventHandler(this.btnRemoveTags_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(513, 95);
         this.Controls.Add(this.btnRemoveTags);
         this.Controls.Add(this.lblTargetDirectory);
         this.Controls.Add(this.btnSelectTargetDirectory);
         this.Name = "Form1";
         this.Text = "Remove Tags";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.FolderBrowserDialog fbdTaggedDocument;
      private System.Windows.Forms.Button btnSelectTargetDirectory;
      private System.Windows.Forms.Label lblTargetDirectory;
      private System.Windows.Forms.Button btnRemoveTags;
   }
}

