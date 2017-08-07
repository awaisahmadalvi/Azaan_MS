using Azaan.Core.UI;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace Azaan
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timePickerFajar = new Azaan.Core.UI.TimePickerMillisPanel();
            this.timePickerZohar = new Azaan.Core.UI.TimePickerMillisPanel();
            this.timePickerAsar = new Azaan.Core.UI.TimePickerMillisPanel();
            this.timePickerMaghrib = new Azaan.Core.UI.TimePickerMillisPanel();
            this.timePickerIsha = new Azaan.Core.UI.TimePickerMillisPanel();
            this.timePickerJumma = new Azaan.Core.UI.TimePickerMillisPanel();
            this.lblFajar = new System.Windows.Forms.Label();
            this.lblZohar = new System.Windows.Forms.Label();
            this.lblAsar = new System.Windows.Forms.Label();
            this.lblMaghrib = new System.Windows.Forms.Label();
            this.lblIsha = new System.Windows.Forms.Label();
            this.lblJumma = new System.Windows.Forms.Label();
            this.pbFajar = new System.Windows.Forms.PictureBox();
            this.pbZohar = new System.Windows.Forms.PictureBox();
            this.pbAsar = new System.Windows.Forms.PictureBox();
            this.pbMaghrib = new System.Windows.Forms.PictureBox();
            this.pbIsha = new System.Windows.Forms.PictureBox();
            this.pbJumma = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZohar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaghrib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJumma)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.CausesValidation = false;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(483, 467);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "اوقاتِ نماز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.timePickerFajar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.timePickerZohar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.timePickerAsar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.timePickerMaghrib, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.timePickerIsha, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.timePickerJumma, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFajar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZohar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAsar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaghrib, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIsha, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblJumma, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pbFajar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbZohar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbAsar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbMaghrib, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbIsha, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbJumma, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 104);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 264);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // timePickerFajar
            // 
            this.timePickerFajar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePickerFajar.AutoSize = true;
            this.timePickerFajar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerFajar.Location = new System.Drawing.Point(279, 8);
            this.timePickerFajar.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerFajar.Name = "timePickerFajar";
            this.timePickerFajar.Size = new System.Drawing.Size(72, 29);
            this.timePickerFajar.TabIndex = 0;
            // 
            // timePickerZohar
            // 
            this.timePickerZohar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePickerZohar.AutoSize = true;
            this.timePickerZohar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerZohar.Location = new System.Drawing.Point(279, 51);
            this.timePickerZohar.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerZohar.Name = "timePickerZohar";
            this.timePickerZohar.Size = new System.Drawing.Size(72, 29);
            this.timePickerZohar.TabIndex = 1;
            // 
            // timePickerAsar
            // 
            this.timePickerAsar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePickerAsar.AutoSize = true;
            this.timePickerAsar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerAsar.Location = new System.Drawing.Point(279, 94);
            this.timePickerAsar.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerAsar.Name = "timePickerAsar";
            this.timePickerAsar.Size = new System.Drawing.Size(72, 29);
            this.timePickerAsar.TabIndex = 2;
            // 
            // timePickerMaghrib
            // 
            this.timePickerMaghrib.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePickerMaghrib.AutoSize = true;
            this.timePickerMaghrib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerMaghrib.Location = new System.Drawing.Point(279, 137);
            this.timePickerMaghrib.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerMaghrib.Name = "timePickerMaghrib";
            this.timePickerMaghrib.Size = new System.Drawing.Size(72, 29);
            this.timePickerMaghrib.TabIndex = 3;
            // 
            // timePickerIsha
            // 
            this.timePickerIsha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePickerIsha.AutoSize = true;
            this.timePickerIsha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerIsha.Location = new System.Drawing.Point(279, 180);
            this.timePickerIsha.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerIsha.Name = "timePickerIsha";
            this.timePickerIsha.Size = new System.Drawing.Size(72, 29);
            this.timePickerIsha.TabIndex = 4;
            // 
            // timePickerJumma
            // 
            this.timePickerJumma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePickerJumma.AutoSize = true;
            this.timePickerJumma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePickerJumma.Location = new System.Drawing.Point(279, 224);
            this.timePickerJumma.Margin = new System.Windows.Forms.Padding(6);
            this.timePickerJumma.Name = "timePickerJumma";
            this.timePickerJumma.Size = new System.Drawing.Size(72, 32);
            this.timePickerJumma.TabIndex = 5;
            // 
            // lblFajar
            // 
            this.lblFajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFajar.AutoSize = true;
            this.lblFajar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFajar.Location = new System.Drawing.Point(177, 2);
            this.lblFajar.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblFajar.Name = "lblFajar";
            this.lblFajar.Size = new System.Drawing.Size(51, 32);
            this.lblFajar.TabIndex = 0;
            this.lblFajar.Text = "فجر";
            // 
            // lblZohar
            // 
            this.lblZohar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZohar.AutoSize = true;
            this.lblZohar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZohar.Location = new System.Drawing.Point(171, 45);
            this.lblZohar.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblZohar.Name = "lblZohar";
            this.lblZohar.Size = new System.Drawing.Size(57, 32);
            this.lblZohar.TabIndex = 1;
            this.lblZohar.Text = "ظہر";
            // 
            // lblAsar
            // 
            this.lblAsar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAsar.AutoSize = true;
            this.lblAsar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsar.Location = new System.Drawing.Point(167, 88);
            this.lblAsar.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblAsar.Name = "lblAsar";
            this.lblAsar.Size = new System.Drawing.Size(61, 32);
            this.lblAsar.TabIndex = 2;
            this.lblAsar.Text = "عصر";
            // 
            // lblMaghrib
            // 
            this.lblMaghrib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaghrib.AutoSize = true;
            this.lblMaghrib.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaghrib.Location = new System.Drawing.Point(155, 131);
            this.lblMaghrib.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblMaghrib.Name = "lblMaghrib";
            this.lblMaghrib.Size = new System.Drawing.Size(73, 32);
            this.lblMaghrib.TabIndex = 3;
            this.lblMaghrib.Text = "مغرب";
            // 
            // lblIsha
            // 
            this.lblIsha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsha.AutoSize = true;
            this.lblIsha.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsha.Location = new System.Drawing.Point(163, 174);
            this.lblIsha.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblIsha.Name = "lblIsha";
            this.lblIsha.Size = new System.Drawing.Size(65, 32);
            this.lblIsha.TabIndex = 4;
            this.lblIsha.Text = "عشاء";
            // 
            // lblJumma
            // 
            this.lblJumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJumma.AutoSize = true;
            this.lblJumma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumma.Location = new System.Drawing.Point(72, 217);
            this.lblJumma.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblJumma.Name = "lblJumma";
            this.lblJumma.Size = new System.Drawing.Size(156, 32);
            this.lblJumma.TabIndex = 5;
            this.lblJumma.Text = "جمعتہ المبارک";
            // 
            // pbFajar
            // 
            this.pbFajar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFajar.Image = global::Azaan.Properties.Resources.Done;
            this.pbFajar.Location = new System.Drawing.Point(5, 5);
            this.pbFajar.Name = "pbFajar";
            this.pbFajar.Size = new System.Drawing.Size(30, 35);
            this.pbFajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFajar.TabIndex = 6;
            this.pbFajar.TabStop = false;
            this.pbFajar.Tag = "";
            this.pbFajar.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pbZohar
            // 
            this.pbZohar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbZohar.Image = global::Azaan.Properties.Resources.Done;
            this.pbZohar.Location = new System.Drawing.Point(5, 48);
            this.pbZohar.Name = "pbZohar";
            this.pbZohar.Size = new System.Drawing.Size(30, 35);
            this.pbZohar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZohar.TabIndex = 7;
            this.pbZohar.TabStop = false;
            this.pbZohar.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pbAsar
            // 
            this.pbAsar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAsar.Image = global::Azaan.Properties.Resources.Wait;
            this.pbAsar.Location = new System.Drawing.Point(5, 91);
            this.pbAsar.Name = "pbAsar";
            this.pbAsar.Size = new System.Drawing.Size(30, 35);
            this.pbAsar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAsar.TabIndex = 8;
            this.pbAsar.TabStop = false;
            this.pbAsar.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pbMaghrib
            // 
            this.pbMaghrib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMaghrib.Image = global::Azaan.Properties.Resources.Ok;
            this.pbMaghrib.Location = new System.Drawing.Point(5, 134);
            this.pbMaghrib.Name = "pbMaghrib";
            this.pbMaghrib.Size = new System.Drawing.Size(30, 35);
            this.pbMaghrib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaghrib.TabIndex = 9;
            this.pbMaghrib.TabStop = false;
            this.pbMaghrib.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pbIsha
            // 
            this.pbIsha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIsha.Image = global::Azaan.Properties.Resources.Ok;
            this.pbIsha.Location = new System.Drawing.Point(5, 177);
            this.pbIsha.Name = "pbIsha";
            this.pbIsha.Size = new System.Drawing.Size(30, 35);
            this.pbIsha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsha.TabIndex = 10;
            this.pbIsha.TabStop = false;
            this.pbIsha.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pbJumma
            // 
            this.pbJumma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbJumma.Image = global::Azaan.Properties.Resources.Ok;
            this.pbJumma.Location = new System.Drawing.Point(5, 220);
            this.pbJumma.Name = "pbJumma";
            this.pbJumma.Size = new System.Drawing.Size(30, 39);
            this.pbJumma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJumma.TabIndex = 11;
            this.pbJumma.TabStop = false;
            this.pbJumma.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.AutoSize = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(201, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Azaan.Properties.Resources.Wait;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Checking Service ...";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azaan Alarm Manager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZohar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaghrib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJumma)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblFajar;
        private Label lblZohar;
        private Label lblAsar;
        private Label lblMaghrib;
        private Label lblIsha;
        private Label lblJumma;
        private Button btnExit;
        private PictureBox pbFajar;
        private PictureBox pbZohar;
        private PictureBox pbAsar;
        private TimePickerMillisPanel timePickerFajar;
        private TimePickerMillisPanel timePickerZohar;
        private TimePickerMillisPanel timePickerAsar;
        private TimePickerMillisPanel timePickerMaghrib;
        private TimePickerMillisPanel timePickerIsha;
        private TimePickerMillisPanel timePickerJumma;
        private PictureBox pbMaghrib;
        private PictureBox pbIsha;
        private PictureBox pbJumma;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;

    }


}