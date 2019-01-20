﻿using System;
using LibraryManagment.Models;

namespace LibraryManagment.Forms
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.DgvReservations = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSearch = new System.Windows.Forms.ComboBox();
            this.GrbClientNumber = new System.Windows.Forms.GroupBox();
            this.LblError = new System.Windows.Forms.Label();
            this.TxtClientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrbBookDetails = new System.Windows.Forms.GroupBox();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbAuthors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbUsers = new System.Windows.Forms.GroupBox();
            this.CmbUsers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrbDateDetails = new System.Windows.Forms.GroupBox();
            this.CmbWhichDates = new System.Windows.Forms.ComboBox();
            this.LblTo = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.DtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDeleteReservation = new System.Windows.Forms.Button();
            this.BtnStopReservation = new System.Windows.Forms.Button();
            this.BtnAddReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).BeginInit();
            this.GrbClientNumber.SuspendLayout();
            this.GrbBookDetails.SuspendLayout();
            this.GrbUsers.SuspendLayout();
            this.GrbDateDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvReservations
            // 
            this.DgvReservations.AllowUserToAddRows = false;
            this.DgvReservations.AllowUserToDeleteRows = false;
            this.DgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column13,
            this.Column12,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DgvReservations.Location = new System.Drawing.Point(12, 103);
            this.DgvReservations.Name = "DgvReservations";
            this.DgvReservations.ReadOnly = true;
            this.DgvReservations.Size = new System.Drawing.Size(1346, 310);
            this.DgvReservations.TabIndex = 0;
            this.DgvReservations.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvReservations_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Oxucu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Oxucu №";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Müəllif";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitab";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "Müddət";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Verib";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Verilmə vaxtı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Alıb";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Alınma vaxtı";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 70F;
            this.Column9.HeaderText = "Cərimə";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Kitabın durumu";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axtar";
            // 
            // CmbSearch
            // 
            this.CmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbSearch.FormattingEnabled = true;
            this.CmbSearch.Location = new System.Drawing.Point(12, 43);
            this.CmbSearch.Name = "CmbSearch";
            this.CmbSearch.Size = new System.Drawing.Size(132, 24);
            this.CmbSearch.TabIndex = 2;
            this.CmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
            // 
            // GrbClientNumber
            // 
            this.GrbClientNumber.Controls.Add(this.LblError);
            this.GrbClientNumber.Controls.Add(this.TxtClientNumber);
            this.GrbClientNumber.Controls.Add(this.label2);
            this.GrbClientNumber.Location = new System.Drawing.Point(173, 5);
            this.GrbClientNumber.Name = "GrbClientNumber";
            this.GrbClientNumber.Size = new System.Drawing.Size(216, 92);
            this.GrbClientNumber.TabIndex = 9;
            this.GrbClientNumber.TabStop = false;
            this.GrbClientNumber.Visible = false;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.LblError.Location = new System.Drawing.Point(7, 72);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 11;
            // 
            // TxtClientNumber
            // 
            this.TxtClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientNumber.Location = new System.Drawing.Point(6, 41);
            this.TxtClientNumber.Name = "TxtClientNumber";
            this.TxtClientNumber.Size = new System.Drawing.Size(188, 23);
            this.TxtClientNumber.TabIndex = 10;
            this.TxtClientNumber.TextChanged += new System.EventHandler(this.TxtClientNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oxucu nömrəsi:";
            // 
            // GrbBookDetails
            // 
            this.GrbBookDetails.Controls.Add(this.CmbBooks);
            this.GrbBookDetails.Controls.Add(this.label4);
            this.GrbBookDetails.Controls.Add(this.CmbAuthors);
            this.GrbBookDetails.Controls.Add(this.label3);
            this.GrbBookDetails.Location = new System.Drawing.Point(172, 17);
            this.GrbBookDetails.Name = "GrbBookDetails";
            this.GrbBookDetails.Size = new System.Drawing.Size(417, 74);
            this.GrbBookDetails.TabIndex = 12;
            this.GrbBookDetails.TabStop = false;
            this.GrbBookDetails.Visible = false;
            // 
            // CmbBooks
            // 
            this.CmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(224, 36);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(187, 24);
            this.CmbBooks.TabIndex = 3;
            this.CmbBooks.SelectedIndexChanged += new System.EventHandler(this.CmbBooks_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(221, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kitab";
            // 
            // CmbAuthors
            // 
            this.CmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbAuthors.FormattingEnabled = true;
            this.CmbAuthors.Location = new System.Drawing.Point(6, 36);
            this.CmbAuthors.Name = "CmbAuthors";
            this.CmbAuthors.Size = new System.Drawing.Size(179, 24);
            this.CmbAuthors.TabIndex = 1;
            this.CmbAuthors.SelectedIndexChanged += new System.EventHandler(this.CmbAuthors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müəllif";
            // 
            // GrbUsers
            // 
            this.GrbUsers.Controls.Add(this.CmbUsers);
            this.GrbUsers.Controls.Add(this.label5);
            this.GrbUsers.Location = new System.Drawing.Point(169, 16);
            this.GrbUsers.Name = "GrbUsers";
            this.GrbUsers.Size = new System.Drawing.Size(231, 74);
            this.GrbUsers.TabIndex = 4;
            this.GrbUsers.TabStop = false;
            this.GrbUsers.Visible = false;
            // 
            // CmbUsers
            // 
            this.CmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbUsers.FormattingEnabled = true;
            this.CmbUsers.Location = new System.Drawing.Point(10, 38);
            this.CmbUsers.Name = "CmbUsers";
            this.CmbUsers.Size = new System.Drawing.Size(208, 24);
            this.CmbUsers.TabIndex = 1;
            this.CmbUsers.SelectedIndexChanged += new System.EventHandler(this.CmbUsers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "İşçi";
            // 
            // GrbDateDetails
            // 
            this.GrbDateDetails.Controls.Add(this.CmbWhichDates);
            this.GrbDateDetails.Controls.Add(this.LblTo);
            this.GrbDateDetails.Controls.Add(this.LblFrom);
            this.GrbDateDetails.Controls.Add(this.DtpTo);
            this.GrbDateDetails.Controls.Add(this.DtpFrom);
            this.GrbDateDetails.Location = new System.Drawing.Point(169, 12);
            this.GrbDateDetails.Name = "GrbDateDetails";
            this.GrbDateDetails.Size = new System.Drawing.Size(629, 79);
            this.GrbDateDetails.TabIndex = 13;
            this.GrbDateDetails.TabStop = false;
            this.GrbDateDetails.Visible = false;
            // 
            // CmbWhichDates
            // 
            this.CmbWhichDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbWhichDates.FormattingEnabled = true;
            this.CmbWhichDates.Location = new System.Drawing.Point(6, 31);
            this.CmbWhichDates.Name = "CmbWhichDates";
            this.CmbWhichDates.Size = new System.Drawing.Size(136, 24);
            this.CmbWhichDates.TabIndex = 4;
            this.CmbWhichDates.SelectedIndexChanged += new System.EventHandler(this.CmbWhichDates_SelectedIndexChanged);
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTo.Location = new System.Drawing.Point(414, 15);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(53, 18);
            this.LblTo.TabIndex = 3;
            this.LblTo.Text = "Qədər:";
            this.LblTo.Visible = false;
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFrom.Location = new System.Drawing.Point(163, 15);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(85, 18);
            this.LblFrom.TabIndex = 2;
            this.LblFrom.Text = "Başlayaraq:";
            this.LblFrom.Visible = false;
            // 
            // DtpTo
            // 
            this.DtpTo.CustomFormat = "dd.MM.yyyy";
            this.DtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTo.Location = new System.Drawing.Point(417, 42);
            this.DtpTo.MaxDate = new System.DateTime(2019, 1, 20, 20, 5, 45, 757);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(200, 24);
            this.DtpTo.TabIndex = 1;
            this.DtpTo.Value = new System.DateTime(2019, 1, 20, 20, 5, 45, 757);
            this.DtpTo.Visible = false;
            this.DtpTo.ValueChanged += new System.EventHandler(this.Dtps_ValueChanged);
            // 
            // DtpFrom
            // 
            this.DtpFrom.CustomFormat = "dd.MM.yyyy";
            this.DtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFrom.Location = new System.Drawing.Point(166, 43);
            this.DtpFrom.MaxDate = new System.DateTime(2019, 1, 20, 20, 5, 45, 760);
            this.DtpFrom.Name = "DtpFrom";
            this.DtpFrom.Size = new System.Drawing.Size(200, 24);
            this.DtpFrom.TabIndex = 0;
            this.DtpFrom.Value = new System.DateTime(2019, 1, 20, 0, 0, 0, 0);
            this.DtpFrom.Visible = false;
            this.DtpFrom.ValueChanged += new System.EventHandler(this.Dtps_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1048, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seçimləri sıfırlamaq üçün boş sahəyə iki dəfə klik edin...";
            // 
            // BtnDeleteReservation
            // 
            this.BtnDeleteReservation.BackgroundImage = global::LibraryManagment.Properties.Resources.Delete;
            this.BtnDeleteReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeleteReservation.FlatAppearance.BorderSize = 0;
            this.BtnDeleteReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteReservation.Location = new System.Drawing.Point(265, 419);
            this.BtnDeleteReservation.Name = "BtnDeleteReservation";
            this.BtnDeleteReservation.Size = new System.Drawing.Size(72, 72);
            this.BtnDeleteReservation.TabIndex = 17;
            this.BtnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // BtnStopReservation
            // 
            this.BtnStopReservation.BackgroundImage = global::LibraryManagment.Properties.Resources.Stop;
            this.BtnStopReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnStopReservation.FlatAppearance.BorderSize = 0;
            this.BtnStopReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStopReservation.Location = new System.Drawing.Point(141, 419);
            this.BtnStopReservation.Name = "BtnStopReservation";
            this.BtnStopReservation.Size = new System.Drawing.Size(72, 72);
            this.BtnStopReservation.TabIndex = 16;
            this.BtnStopReservation.UseVisualStyleBackColor = true;
            // 
            // BtnAddReservation
            // 
            this.BtnAddReservation.BackColor = System.Drawing.Color.White;
            this.BtnAddReservation.BackgroundImage = global::LibraryManagment.Properties.Resources.book_and_plus_sign;
            this.BtnAddReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddReservation.FlatAppearance.BorderSize = 0;
            this.BtnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddReservation.Location = new System.Drawing.Point(12, 419);
            this.BtnAddReservation.Name = "BtnAddReservation";
            this.BtnAddReservation.Size = new System.Drawing.Size(72, 72);
            this.BtnAddReservation.TabIndex = 15;
            this.BtnAddReservation.UseVisualStyleBackColor = false;
            this.BtnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 606);
            this.Controls.Add(this.BtnDeleteReservation);
            this.Controls.Add(this.BtnStopReservation);
            this.Controls.Add(this.BtnAddReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GrbDateDetails);
            this.Controls.Add(this.GrbUsers);
            this.Controls.Add(this.GrbBookDetails);
            this.Controls.Add(this.GrbClientNumber);
            this.Controls.Add(this.CmbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvReservations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reservations";
            this.Text = "Kitab Verilişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.DoubleClick += new System.EventHandler(this.Reservations_DoubleClick);
            this.Resize += new System.EventHandler(this.Reservations_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).EndInit();
            this.GrbClientNumber.ResumeLayout(false);
            this.GrbClientNumber.PerformLayout();
            this.GrbBookDetails.ResumeLayout(false);
            this.GrbBookDetails.PerformLayout();
            this.GrbUsers.ResumeLayout(false);
            this.GrbUsers.PerformLayout();
            this.GrbDateDetails.ResumeLayout(false);
            this.GrbDateDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSearch;
        private System.Windows.Forms.GroupBox GrbClientNumber;
        private System.Windows.Forms.TextBox TxtClientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrbBookDetails;
        private System.Windows.Forms.ComboBox CmbBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrbUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbUsers;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.GroupBox GrbDateDetails;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker DtpFrom;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.ComboBox CmbWhichDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAddReservation;
        private System.Windows.Forms.Button BtnStopReservation;
        private System.Windows.Forms.Button BtnDeleteReservation;
    }
}