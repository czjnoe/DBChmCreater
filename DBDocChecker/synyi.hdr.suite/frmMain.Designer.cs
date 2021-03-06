﻿namespace synyi.hdr.suite
{
    partial class frmMain
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
            this.btnExportHDRExcel = new System.Windows.Forms.Button();
            this.btnLoadSchemaAndTables = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.btnNewExcel = new System.Windows.Forms.Button();
            this.btnLoadHdr_v105 = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnLoadHdr_v106 = new System.Windows.Forms.Button();
            this.txtHDRExcelPath = new System.Windows.Forms.TextBox();
            this.btnLocationHDRExcel = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnLoad_SD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportHDRExcel
            // 
            this.btnExportHDRExcel.Location = new System.Drawing.Point(703, 56);
            this.btnExportHDRExcel.Name = "btnExportHDRExcel";
            this.btnExportHDRExcel.Size = new System.Drawing.Size(85, 34);
            this.btnExportHDRExcel.TabIndex = 0;
            this.btnExportHDRExcel.Text = "导出字典";
            this.btnExportHDRExcel.UseVisualStyleBackColor = true;
            this.btnExportHDRExcel.Click += new System.EventHandler(this.btnExportHDRExcel_Click);
            // 
            // btnLoadSchemaAndTables
            // 
            this.btnLoadSchemaAndTables.Location = new System.Drawing.Point(703, 12);
            this.btnLoadSchemaAndTables.Name = "btnLoadSchemaAndTables";
            this.btnLoadSchemaAndTables.Size = new System.Drawing.Size(85, 34);
            this.btnLoadSchemaAndTables.TabIndex = 1;
            this.btnLoadSchemaAndTables.Text = "1.加载配置";
            this.btnLoadSchemaAndTables.UseVisualStyleBackColor = true;
            this.btnLoadSchemaAndTables.Click += new System.EventHandler(this.btnLoadSchemaAndTables_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 430);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(683, 125);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Location = new System.Drawing.Point(703, 100);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(85, 34);
            this.btnReadExcel.TabIndex = 5;
            this.btnReadExcel.Text = "读取Excel";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // btnNewExcel
            // 
            this.btnNewExcel.Location = new System.Drawing.Point(703, 144);
            this.btnNewExcel.Name = "btnNewExcel";
            this.btnNewExcel.Size = new System.Drawing.Size(85, 34);
            this.btnNewExcel.TabIndex = 6;
            this.btnNewExcel.Text = "创建Excel";
            this.btnNewExcel.UseVisualStyleBackColor = true;
            this.btnNewExcel.Click += new System.EventHandler(this.btnNewExcel_Click);
            // 
            // btnLoadHdr_v105
            // 
            this.btnLoadHdr_v105.Location = new System.Drawing.Point(703, 188);
            this.btnLoadHdr_v105.Name = "btnLoadHdr_v105";
            this.btnLoadHdr_v105.Size = new System.Drawing.Size(85, 34);
            this.btnLoadHdr_v105.TabIndex = 7;
            this.btnLoadHdr_v105.Text = "读取HDR105";
            this.btnLoadHdr_v105.UseVisualStyleBackColor = true;
            this.btnLoadHdr_v105.Click += new System.EventHandler(this.btnLoadHdr_v105_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(703, 232);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(85, 34);
            this.btnLoadJson.TabIndex = 8;
            this.btnLoadJson.Text = "加载JSON";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(703, 276);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(85, 34);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLoadHdr_v106
            // 
            this.btnLoadHdr_v106.Location = new System.Drawing.Point(703, 320);
            this.btnLoadHdr_v106.Name = "btnLoadHdr_v106";
            this.btnLoadHdr_v106.Size = new System.Drawing.Size(85, 34);
            this.btnLoadHdr_v106.TabIndex = 10;
            this.btnLoadHdr_v106.Text = "读取最新HDR";
            this.btnLoadHdr_v106.UseVisualStyleBackColor = true;
            this.btnLoadHdr_v106.Click += new System.EventHandler(this.btnLoadHdr_v106_Click);
            // 
            // txtHDRExcelPath
            // 
            this.txtHDRExcelPath.Location = new System.Drawing.Point(86, 9);
            this.txtHDRExcelPath.Name = "txtHDRExcelPath";
            this.txtHDRExcelPath.Size = new System.Drawing.Size(602, 21);
            this.txtHDRExcelPath.TabIndex = 11;
            // 
            // btnLocationHDRExcel
            // 
            this.btnLocationHDRExcel.Location = new System.Drawing.Point(5, 8);
            this.btnLocationHDRExcel.Name = "btnLocationHDRExcel";
            this.btnLocationHDRExcel.Size = new System.Drawing.Size(75, 23);
            this.btnLocationHDRExcel.TabIndex = 12;
            this.btnLocationHDRExcel.Text = "浏览";
            this.btnLocationHDRExcel.UseVisualStyleBackColor = true;
            this.btnLocationHDRExcel.Click += new System.EventHandler(this.btnLocationHDRExcel_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(5, 35);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(683, 387);
            this.grid.TabIndex = 13;
            // 
            // btnLoad_SD
            // 
            this.btnLoad_SD.Location = new System.Drawing.Point(694, 422);
            this.btnLoad_SD.Name = "btnLoad_SD";
            this.btnLoad_SD.Size = new System.Drawing.Size(85, 34);
            this.btnLoad_SD.TabIndex = 14;
            this.btnLoad_SD.Text = "读取最新SD";
            this.btnLoad_SD.UseVisualStyleBackColor = true;
            this.btnLoad_SD.Click += new System.EventHandler(this.btnLoad_SD_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.btnLoad_SD);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnLocationHDRExcel);
            this.Controls.Add(this.txtHDRExcelPath);
            this.Controls.Add(this.btnLoadHdr_v106);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnLoadHdr_v105);
            this.Controls.Add(this.btnNewExcel);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLoadSchemaAndTables);
            this.Controls.Add(this.btnExportHDRExcel);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportHDRExcel;
        private System.Windows.Forms.Button btnLoadSchemaAndTables;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnReadExcel;
        private System.Windows.Forms.Button btnNewExcel;
        private System.Windows.Forms.Button btnLoadHdr_v105;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLoadHdr_v106;
        private System.Windows.Forms.TextBox txtHDRExcelPath;
        private System.Windows.Forms.Button btnLocationHDRExcel;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnLoad_SD;
    }
}

