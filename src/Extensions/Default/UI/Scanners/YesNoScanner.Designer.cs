﻿namespace ACAT.Extensions.Default.UI.Menus
{
    partial class YesNoScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YesNoScanner));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Row1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemText1 = new ACAT.Lib.Core.WidgetManagement.ScannerButtonControl();
            this.ItemText2 = new ACAT.Lib.Core.WidgetManagement.ScannerButtonControl();
            this.ItemText3 = new ACAT.Lib.Core.WidgetManagement.ScannerButtonControl();
            this.ItemText4 = new ACAT.Lib.Core.WidgetManagement.ScannerButtonControl();
            this.PromptRow = new System.Windows.Forms.TableLayoutPanel();
            this.Prompt = new ACAT.Lib.Core.WidgetManagement.ScannerButtonControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.Row1.SuspendLayout();
            this.PromptRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Row1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PromptRow, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Row1
            // 
            resources.ApplyResources(this.Row1, "Row1");
            this.Row1.Controls.Add(this.ItemText1, 0, 0);
            this.Row1.Controls.Add(this.ItemText2, 1, 0);
            this.Row1.Controls.Add(this.ItemText3, 2, 0);
            this.Row1.Controls.Add(this.ItemText4, 3, 0);
            this.Row1.Name = "Row1";
            // 
            // ItemText1
            // 
            resources.ApplyResources(this.ItemText1, "ItemText1");
            this.ItemText1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ItemText1.Name = "ItemText1";
            this.ItemText1.UseMnemonic = false;
            this.ItemText1.UseVisualStyleBackColor = true;
            // 
            // ItemText2
            // 
            resources.ApplyResources(this.ItemText2, "ItemText2");
            this.ItemText2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ItemText2.Name = "ItemText2";
            this.ItemText2.UseMnemonic = false;
            this.ItemText2.UseVisualStyleBackColor = true;
            // 
            // ItemText3
            // 
            resources.ApplyResources(this.ItemText3, "ItemText3");
            this.ItemText3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ItemText3.Name = "ItemText3";
            this.ItemText3.UseMnemonic = false;
            this.ItemText3.UseVisualStyleBackColor = true;
            // 
            // ItemText4
            // 
            resources.ApplyResources(this.ItemText4, "ItemText4");
            this.ItemText4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ItemText4.Name = "ItemText4";
            this.ItemText4.UseMnemonic = false;
            this.ItemText4.UseVisualStyleBackColor = true;
            // 
            // PromptRow
            // 
            resources.ApplyResources(this.PromptRow, "PromptRow");
            this.PromptRow.Controls.Add(this.Prompt, 0, 0);
            this.PromptRow.Name = "PromptRow";
            this.tableLayoutPanel1.SetRowSpan(this.PromptRow, 2);
            // 
            // Prompt
            // 
            resources.ApplyResources(this.Prompt, "Prompt");
            this.Prompt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Prompt.FlatAppearance.BorderSize = 0;
            this.Prompt.Name = "Prompt";
            this.PromptRow.SetRowSpan(this.Prompt, 2);
            this.Prompt.UseMnemonic = false;
            this.Prompt.UseVisualStyleBackColor = true;
            // 
            // YesNoScanner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YesNoScanner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Row1.ResumeLayout(false);
            this.PromptRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Row1;
        private System.Windows.Forms.TableLayoutPanel PromptRow;
        private ACAT.Lib.Core.WidgetManagement.ScannerButtonControl Prompt;
        private Lib.Core.WidgetManagement.ScannerButtonControl ItemText1;
        private Lib.Core.WidgetManagement.ScannerButtonControl ItemText2;
        private Lib.Core.WidgetManagement.ScannerButtonControl ItemText3;
        private Lib.Core.WidgetManagement.ScannerButtonControl ItemText4;
    }
}