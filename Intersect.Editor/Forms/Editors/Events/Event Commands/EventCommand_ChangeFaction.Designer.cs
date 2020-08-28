﻿using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeFaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandChangeFaction));
            this.grpChangeFaction = new DarkUI.Controls.DarkGroupBox();
            this.cmbFaction = new DarkUI.Controls.DarkComboBox();
            this.lblFaction = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpChangeFaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChangeFaction
            // 
            this.grpChangeFaction.BackColor = System.Drawing.Color.Teal;
            this.grpChangeFaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeFaction.Controls.Add(this.cmbFaction);
            this.grpChangeFaction.Controls.Add(this.lblFaction);
            this.grpChangeFaction.Controls.Add(this.btnCancel);
            this.grpChangeFaction.Controls.Add(this.btnSave);
            this.grpChangeFaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeFaction.Location = new System.Drawing.Point(3, 3);
            this.grpChangeFaction.Name = "grpChangeFaction";
            this.grpChangeFaction.Size = new System.Drawing.Size(185, 100);
            this.grpChangeFaction.TabIndex = 17;
            this.grpChangeFaction.TabStop = false;
            this.grpChangeFaction.Text = "Change Faction:";
            // 
            // cmbFaction
            // 
            this.cmbFaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFaction.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFaction.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFaction.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbFaction.ButtonIcon")));
            this.cmbFaction.DrawDropdownHoverOutline = false;
            this.cmbFaction.DrawFocusRectangle = false;
            this.cmbFaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Items.AddRange(new object[] {
            "Mezuk",
            "Gollik",
            "Neutral"});
            this.cmbFaction.Location = new System.Drawing.Point(47, 19);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(117, 21);
            this.cmbFaction.TabIndex = 22;
            this.cmbFaction.Text = "Mezuk";
            this.cmbFaction.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(4, 22);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(45, 13);
            this.lblFaction.TabIndex = 21;
            this.lblFaction.Text = "Faction:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandChangeFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeFaction);
            this.Name = "EventCommandChangeFaction";
            this.Size = new System.Drawing.Size(191, 106);
            this.grpChangeFaction.ResumeLayout(false);
            this.grpChangeFaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeFaction;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label lblFaction;
        private DarkComboBox cmbFaction;
    }
}
