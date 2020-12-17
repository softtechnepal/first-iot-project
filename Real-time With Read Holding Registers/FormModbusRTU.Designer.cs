using System.Drawing;
using System.Windows.Forms;

namespace Real_time_With_Read_Holding_Registers
{
    partial class FormModbusRTU
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
            this.txt40000 = new System.Windows.Forms.Label();
            this.txt40001 = new System.Windows.Forms.Label();
            this.lbl40000 = new System.Windows.Forms.Label();
            this.lbl40001 = new System.Windows.Forms.Label();
            this.txt40002 = new System.Windows.Forms.Label();
            this.lbl40002 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl40005 = new System.Windows.Forms.Label();
            this.lbl40004 = new System.Windows.Forms.Label();
            this.txt40005 = new System.Windows.Forms.Label();
            this.lbl40003 = new System.Windows.Forms.Label();
            this.txt40004 = new System.Windows.Forms.Label();
            this.txt40003 = new System.Windows.Forms.Label();
            this.lbl40011 = new System.Windows.Forms.Label();
            this.lbl40010 = new System.Windows.Forms.Label();
            this.txt40011 = new System.Windows.Forms.Label();
            this.lbl40009 = new System.Windows.Forms.Label();
            this.txt40010 = new System.Windows.Forms.Label();
            this.txt40009 = new System.Windows.Forms.Label();
            this.lbl40008 = new System.Windows.Forms.Label();
            this.lbl40007 = new System.Windows.Forms.Label();
            this.txt40008 = new System.Windows.Forms.Label();
            this.lbl40006 = new System.Windows.Forms.Label();
            this.txt40007 = new System.Windows.Forms.Label();
            this.txt40006 = new System.Windows.Forms.Label();
            this.lbl40017 = new System.Windows.Forms.Label();
            this.lbl40016 = new System.Windows.Forms.Label();
            this.txt40017 = new System.Windows.Forms.Label();
            this.lbl40015 = new System.Windows.Forms.Label();
            this.txt40016 = new System.Windows.Forms.Label();
            this.txt40015 = new System.Windows.Forms.Label();
            this.lbl40014 = new System.Windows.Forms.Label();
            this.lbl40013 = new System.Windows.Forms.Label();
            this.txt40014 = new System.Windows.Forms.Label();
            this.lbl40012 = new System.Windows.Forms.Label();
            this.txt40013 = new System.Windows.Forms.Label();
            this.txt40012 = new System.Windows.Forms.Label();
            this.lbl40019 = new System.Windows.Forms.Label();
            this.lbl40018 = new System.Windows.Forms.Label();
            this.txt40019 = new System.Windows.Forms.Label();
            this.txt40018 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt40000
            // 
            this.txt40000.BackColor = System.Drawing.Color.Black;
            this.txt40000.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40000.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40000.ForeColor = System.Drawing.Color.Red;
            this.txt40000.Location = new System.Drawing.Point(204, 119);
            this.txt40000.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40000.Name = "txt40000";
            this.txt40000.Size = new System.Drawing.Size(250, 90);
            this.txt40000.TabIndex = 0;
            this.txt40000.Text = "VALUE";
            this.txt40000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40001
            // 
            this.txt40001.BackColor = System.Drawing.Color.Black;
            this.txt40001.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40001.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40001.ForeColor = System.Drawing.Color.Lime;
            this.txt40001.Location = new System.Drawing.Point(669, 119);
            this.txt40001.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40001.Name = "txt40001";
            this.txt40001.Size = new System.Drawing.Size(250, 90);
            this.txt40001.TabIndex = 1;
            this.txt40001.Text = "VALUE";
            this.txt40001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40000
            // 
            this.lbl40000.BackColor = System.Drawing.Color.Black;
            this.lbl40000.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40000.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40000.ForeColor = System.Drawing.Color.White;
            this.lbl40000.Location = new System.Drawing.Point(12, 119);
            this.lbl40000.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40000.Name = "lbl40000";
            this.lbl40000.Size = new System.Drawing.Size(193, 90);
            this.lbl40000.TabIndex = 0;
            this.lbl40000.Text = "ADDRESS";
            this.lbl40000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl40000.Click += new System.EventHandler(this.lbl40000_Click);
            // 
            // lbl40001
            // 
            this.lbl40001.BackColor = System.Drawing.Color.Black;
            this.lbl40001.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40001.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40001.ForeColor = System.Drawing.Color.White;
            this.lbl40001.Location = new System.Drawing.Point(462, 119);
            this.lbl40001.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40001.Name = "lbl40001";
            this.lbl40001.Size = new System.Drawing.Size(210, 90);
            this.lbl40001.TabIndex = 1;
            this.lbl40001.Text = "ADDRESS";
            this.lbl40001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40002
            // 
            this.txt40002.BackColor = System.Drawing.Color.Black;
            this.txt40002.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40002.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40002.ForeColor = System.Drawing.Color.Yellow;
            this.txt40002.Location = new System.Drawing.Point(1134, 119);
            this.txt40002.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40002.Name = "txt40002";
            this.txt40002.Size = new System.Drawing.Size(250, 90);
            this.txt40002.TabIndex = 1;
            this.txt40002.Text = "VALUE";
            this.txt40002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40002
            // 
            this.lbl40002.BackColor = System.Drawing.Color.Black;
            this.lbl40002.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40002.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40002.ForeColor = System.Drawing.Color.White;
            this.lbl40002.Location = new System.Drawing.Point(927, 119);
            this.lbl40002.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40002.Name = "lbl40002";
            this.lbl40002.Size = new System.Drawing.Size(210, 90);
            this.lbl40002.TabIndex = 1;
            this.lbl40002.Text = "ADDRESS";
            this.lbl40002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1372, 110);
            this.label6.TabIndex = 4;
            this.label6.Text = "Read Register";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40005
            // 
            this.lbl40005.BackColor = System.Drawing.Color.Black;
            this.lbl40005.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40005.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40005.ForeColor = System.Drawing.Color.White;
            this.lbl40005.Location = new System.Drawing.Point(927, 209);
            this.lbl40005.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40005.Name = "lbl40005";
            this.lbl40005.Size = new System.Drawing.Size(208, 90);
            this.lbl40005.TabIndex = 7;
            this.lbl40005.Text = "ADDRESS";
            this.lbl40005.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40004
            // 
            this.lbl40004.BackColor = System.Drawing.Color.Black;
            this.lbl40004.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40004.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40004.ForeColor = System.Drawing.Color.White;
            this.lbl40004.Location = new System.Drawing.Point(463, 209);
            this.lbl40004.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40004.Name = "lbl40004";
            this.lbl40004.Size = new System.Drawing.Size(209, 90);
            this.lbl40004.TabIndex = 8;
            this.lbl40004.Text = "ADDRESS";
            this.lbl40004.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40005
            // 
            this.txt40005.BackColor = System.Drawing.Color.Black;
            this.txt40005.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40005.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40005.ForeColor = System.Drawing.Color.Yellow;
            this.txt40005.Location = new System.Drawing.Point(1134, 209);
            this.txt40005.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40005.Name = "txt40005";
            this.txt40005.Size = new System.Drawing.Size(250, 90);
            this.txt40005.TabIndex = 9;
            this.txt40005.Text = "VALUE";
            this.txt40005.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40003
            // 
            this.lbl40003.BackColor = System.Drawing.Color.Black;
            this.lbl40003.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40003.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40003.ForeColor = System.Drawing.Color.White;
            this.lbl40003.Location = new System.Drawing.Point(12, 209);
            this.lbl40003.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40003.Name = "lbl40003";
            this.lbl40003.Size = new System.Drawing.Size(193, 90);
            this.lbl40003.TabIndex = 5;
            this.lbl40003.Text = "ADDRESS";
            this.lbl40003.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40004
            // 
            this.txt40004.BackColor = System.Drawing.Color.Black;
            this.txt40004.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40004.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40004.ForeColor = System.Drawing.Color.Lime;
            this.txt40004.Location = new System.Drawing.Point(672, 209);
            this.txt40004.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40004.Name = "txt40004";
            this.txt40004.Size = new System.Drawing.Size(247, 90);
            this.txt40004.TabIndex = 10;
            this.txt40004.Text = "VALUE";
            this.txt40004.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40003
            // 
            this.txt40003.BackColor = System.Drawing.Color.Black;
            this.txt40003.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40003.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40003.ForeColor = System.Drawing.Color.Red;
            this.txt40003.Location = new System.Drawing.Point(204, 209);
            this.txt40003.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40003.Name = "txt40003";
            this.txt40003.Size = new System.Drawing.Size(250, 90);
            this.txt40003.TabIndex = 6;
            this.txt40003.Text = "VALUE";
            this.txt40003.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40011
            // 
            this.lbl40011.BackColor = System.Drawing.Color.Black;
            this.lbl40011.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40011.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40011.ForeColor = System.Drawing.Color.White;
            this.lbl40011.Location = new System.Drawing.Point(927, 389);
            this.lbl40011.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40011.Name = "lbl40011";
            this.lbl40011.Size = new System.Drawing.Size(208, 90);
            this.lbl40011.TabIndex = 19;
            this.lbl40011.Text = "ADDRESS";
            this.lbl40011.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40010
            // 
            this.lbl40010.BackColor = System.Drawing.Color.Black;
            this.lbl40010.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40010.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40010.ForeColor = System.Drawing.Color.White;
            this.lbl40010.Location = new System.Drawing.Point(463, 389);
            this.lbl40010.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40010.Name = "lbl40010";
            this.lbl40010.Size = new System.Drawing.Size(209, 90);
            this.lbl40010.TabIndex = 20;
            this.lbl40010.Text = "ADDRESS";
            this.lbl40010.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40011
            // 
            this.txt40011.BackColor = System.Drawing.Color.Black;
            this.txt40011.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40011.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40011.ForeColor = System.Drawing.Color.Yellow;
            this.txt40011.Location = new System.Drawing.Point(1134, 389);
            this.txt40011.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40011.Name = "txt40011";
            this.txt40011.Size = new System.Drawing.Size(250, 90);
            this.txt40011.TabIndex = 21;
            this.txt40011.Text = "VALUE";
            this.txt40011.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40009
            // 
            this.lbl40009.BackColor = System.Drawing.Color.Black;
            this.lbl40009.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40009.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40009.ForeColor = System.Drawing.Color.White;
            this.lbl40009.Location = new System.Drawing.Point(12, 389);
            this.lbl40009.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40009.Name = "lbl40009";
            this.lbl40009.Size = new System.Drawing.Size(193, 90);
            this.lbl40009.TabIndex = 17;
            this.lbl40009.Text = "ADDRESS";
            this.lbl40009.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40010
            // 
            this.txt40010.BackColor = System.Drawing.Color.Black;
            this.txt40010.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40010.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40010.ForeColor = System.Drawing.Color.Lime;
            this.txt40010.Location = new System.Drawing.Point(672, 389);
            this.txt40010.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40010.Name = "txt40010";
            this.txt40010.Size = new System.Drawing.Size(247, 90);
            this.txt40010.TabIndex = 22;
            this.txt40010.Text = "VALUE";
            this.txt40010.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40009
            // 
            this.txt40009.BackColor = System.Drawing.Color.Black;
            this.txt40009.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40009.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40009.ForeColor = System.Drawing.Color.Red;
            this.txt40009.Location = new System.Drawing.Point(204, 389);
            this.txt40009.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40009.Name = "txt40009";
            this.txt40009.Size = new System.Drawing.Size(250, 90);
            this.txt40009.TabIndex = 18;
            this.txt40009.Text = "VALUE";
            this.txt40009.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40008
            // 
            this.lbl40008.BackColor = System.Drawing.Color.Black;
            this.lbl40008.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40008.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40008.ForeColor = System.Drawing.Color.White;
            this.lbl40008.Location = new System.Drawing.Point(927, 299);
            this.lbl40008.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40008.Name = "lbl40008";
            this.lbl40008.Size = new System.Drawing.Size(210, 90);
            this.lbl40008.TabIndex = 13;
            this.lbl40008.Text = "ADDRESS";
            this.lbl40008.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40007
            // 
            this.lbl40007.BackColor = System.Drawing.Color.Black;
            this.lbl40007.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40007.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40007.ForeColor = System.Drawing.Color.White;
            this.lbl40007.Location = new System.Drawing.Point(462, 299);
            this.lbl40007.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40007.Name = "lbl40007";
            this.lbl40007.Size = new System.Drawing.Size(210, 90);
            this.lbl40007.TabIndex = 14;
            this.lbl40007.Text = "ADDRESS";
            this.lbl40007.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40008
            // 
            this.txt40008.BackColor = System.Drawing.Color.Black;
            this.txt40008.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40008.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40008.ForeColor = System.Drawing.Color.Yellow;
            this.txt40008.Location = new System.Drawing.Point(1134, 299);
            this.txt40008.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40008.Name = "txt40008";
            this.txt40008.Size = new System.Drawing.Size(250, 90);
            this.txt40008.TabIndex = 15;
            this.txt40008.Text = "VALUE";
            this.txt40008.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40006
            // 
            this.lbl40006.BackColor = System.Drawing.Color.Black;
            this.lbl40006.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40006.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40006.ForeColor = System.Drawing.Color.White;
            this.lbl40006.Location = new System.Drawing.Point(12, 299);
            this.lbl40006.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40006.Name = "lbl40006";
            this.lbl40006.Size = new System.Drawing.Size(193, 90);
            this.lbl40006.TabIndex = 11;
            this.lbl40006.Text = "ADDRESS";
            this.lbl40006.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40007
            // 
            this.txt40007.BackColor = System.Drawing.Color.Black;
            this.txt40007.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40007.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40007.ForeColor = System.Drawing.Color.Lime;
            this.txt40007.Location = new System.Drawing.Point(669, 299);
            this.txt40007.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40007.Name = "txt40007";
            this.txt40007.Size = new System.Drawing.Size(250, 90);
            this.txt40007.TabIndex = 16;
            this.txt40007.Text = "VALUE";
            this.txt40007.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40006
            // 
            this.txt40006.BackColor = System.Drawing.Color.Black;
            this.txt40006.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40006.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40006.ForeColor = System.Drawing.Color.Red;
            this.txt40006.Location = new System.Drawing.Point(204, 299);
            this.txt40006.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40006.Name = "txt40006";
            this.txt40006.Size = new System.Drawing.Size(250, 90);
            this.txt40006.TabIndex = 12;
            this.txt40006.Text = "VALUE";
            this.txt40006.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40017
            // 
            this.lbl40017.BackColor = System.Drawing.Color.Black;
            this.lbl40017.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40017.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40017.ForeColor = System.Drawing.Color.White;
            this.lbl40017.Location = new System.Drawing.Point(927, 569);
            this.lbl40017.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40017.Name = "lbl40017";
            this.lbl40017.Size = new System.Drawing.Size(208, 90);
            this.lbl40017.TabIndex = 31;
            this.lbl40017.Text = "ADDRESS";
            this.lbl40017.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40016
            // 
            this.lbl40016.BackColor = System.Drawing.Color.Black;
            this.lbl40016.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40016.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40016.ForeColor = System.Drawing.Color.White;
            this.lbl40016.Location = new System.Drawing.Point(463, 569);
            this.lbl40016.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40016.Name = "lbl40016";
            this.lbl40016.Size = new System.Drawing.Size(209, 90);
            this.lbl40016.TabIndex = 32;
            this.lbl40016.Text = "ADDRESS";
            this.lbl40016.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40017
            // 
            this.txt40017.BackColor = System.Drawing.Color.Black;
            this.txt40017.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40017.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40017.ForeColor = System.Drawing.Color.Yellow;
            this.txt40017.Location = new System.Drawing.Point(1134, 569);
            this.txt40017.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40017.Name = "txt40017";
            this.txt40017.Size = new System.Drawing.Size(250, 90);
            this.txt40017.TabIndex = 33;
            this.txt40017.Text = "VALUE";
            this.txt40017.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40015
            // 
            this.lbl40015.BackColor = System.Drawing.Color.Black;
            this.lbl40015.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40015.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40015.ForeColor = System.Drawing.Color.White;
            this.lbl40015.Location = new System.Drawing.Point(12, 569);
            this.lbl40015.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40015.Name = "lbl40015";
            this.lbl40015.Size = new System.Drawing.Size(193, 90);
            this.lbl40015.TabIndex = 29;
            this.lbl40015.Text = "ADDRESS";
            this.lbl40015.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40016
            // 
            this.txt40016.BackColor = System.Drawing.Color.Black;
            this.txt40016.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40016.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40016.ForeColor = System.Drawing.Color.Lime;
            this.txt40016.Location = new System.Drawing.Point(672, 569);
            this.txt40016.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40016.Name = "txt40016";
            this.txt40016.Size = new System.Drawing.Size(247, 90);
            this.txt40016.TabIndex = 34;
            this.txt40016.Text = "VALUE";
            this.txt40016.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40015
            // 
            this.txt40015.BackColor = System.Drawing.Color.Black;
            this.txt40015.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40015.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40015.ForeColor = System.Drawing.Color.Red;
            this.txt40015.Location = new System.Drawing.Point(204, 569);
            this.txt40015.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40015.Name = "txt40015";
            this.txt40015.Size = new System.Drawing.Size(250, 90);
            this.txt40015.TabIndex = 30;
            this.txt40015.Text = "VALUE";
            this.txt40015.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40014
            // 
            this.lbl40014.BackColor = System.Drawing.Color.Black;
            this.lbl40014.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40014.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40014.ForeColor = System.Drawing.Color.White;
            this.lbl40014.Location = new System.Drawing.Point(927, 479);
            this.lbl40014.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40014.Name = "lbl40014";
            this.lbl40014.Size = new System.Drawing.Size(210, 90);
            this.lbl40014.TabIndex = 25;
            this.lbl40014.Text = "ADDRESS";
            this.lbl40014.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40013
            // 
            this.lbl40013.BackColor = System.Drawing.Color.Black;
            this.lbl40013.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40013.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40013.ForeColor = System.Drawing.Color.White;
            this.lbl40013.Location = new System.Drawing.Point(462, 479);
            this.lbl40013.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40013.Name = "lbl40013";
            this.lbl40013.Size = new System.Drawing.Size(210, 90);
            this.lbl40013.TabIndex = 26;
            this.lbl40013.Text = "ADDRESS";
            this.lbl40013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40014
            // 
            this.txt40014.BackColor = System.Drawing.Color.Black;
            this.txt40014.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40014.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40014.ForeColor = System.Drawing.Color.Yellow;
            this.txt40014.Location = new System.Drawing.Point(1134, 479);
            this.txt40014.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40014.Name = "txt40014";
            this.txt40014.Size = new System.Drawing.Size(250, 90);
            this.txt40014.TabIndex = 27;
            this.txt40014.Text = "VALUE";
            this.txt40014.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40012
            // 
            this.lbl40012.BackColor = System.Drawing.Color.Black;
            this.lbl40012.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40012.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40012.ForeColor = System.Drawing.Color.White;
            this.lbl40012.Location = new System.Drawing.Point(12, 479);
            this.lbl40012.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40012.Name = "lbl40012";
            this.lbl40012.Size = new System.Drawing.Size(193, 90);
            this.lbl40012.TabIndex = 23;
            this.lbl40012.Text = "ADDRESS";
            this.lbl40012.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40013
            // 
            this.txt40013.BackColor = System.Drawing.Color.Black;
            this.txt40013.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40013.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40013.ForeColor = System.Drawing.Color.Lime;
            this.txt40013.Location = new System.Drawing.Point(669, 479);
            this.txt40013.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40013.Name = "txt40013";
            this.txt40013.Size = new System.Drawing.Size(250, 90);
            this.txt40013.TabIndex = 28;
            this.txt40013.Text = "VALUE";
            this.txt40013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40012
            // 
            this.txt40012.BackColor = System.Drawing.Color.Black;
            this.txt40012.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40012.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40012.ForeColor = System.Drawing.Color.Red;
            this.txt40012.Location = new System.Drawing.Point(204, 479);
            this.txt40012.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40012.Name = "txt40012";
            this.txt40012.Size = new System.Drawing.Size(250, 90);
            this.txt40012.TabIndex = 24;
            this.txt40012.Text = "VALUE";
            this.txt40012.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40019
            // 
            this.lbl40019.BackColor = System.Drawing.Color.Black;
            this.lbl40019.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40019.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40019.ForeColor = System.Drawing.Color.White;
            this.lbl40019.Location = new System.Drawing.Point(455, 659);
            this.lbl40019.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40019.Name = "lbl40019";
            this.lbl40019.Size = new System.Drawing.Size(209, 90);
            this.lbl40019.TabIndex = 37;
            this.lbl40019.Text = "ADDRESS";
            this.lbl40019.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl40018
            // 
            this.lbl40018.BackColor = System.Drawing.Color.Black;
            this.lbl40018.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl40018.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl40018.ForeColor = System.Drawing.Color.White;
            this.lbl40018.Location = new System.Drawing.Point(11, 659);
            this.lbl40018.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl40018.Name = "lbl40018";
            this.lbl40018.Size = new System.Drawing.Size(193, 90);
            this.lbl40018.TabIndex = 35;
            this.lbl40018.Text = "ADDRESS";
            this.lbl40018.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40019
            // 
            this.txt40019.BackColor = System.Drawing.Color.Black;
            this.txt40019.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40019.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40019.ForeColor = System.Drawing.Color.Lime;
            this.txt40019.Location = new System.Drawing.Point(671, 659);
            this.txt40019.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40019.Name = "txt40019";
            this.txt40019.Size = new System.Drawing.Size(247, 90);
            this.txt40019.TabIndex = 38;
            this.txt40019.Text = "VALUE";
            this.txt40019.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt40018
            // 
            this.txt40018.BackColor = System.Drawing.Color.Black;
            this.txt40018.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt40018.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt40018.ForeColor = System.Drawing.Color.Red;
            this.txt40018.Location = new System.Drawing.Point(203, 659);
            this.txt40018.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt40018.Name = "txt40018";
            this.txt40018.Size = new System.Drawing.Size(250, 90);
            this.txt40018.TabIndex = 36;
            this.txt40018.Text = "VALUE";
            this.txt40018.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormModbusRTU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 752);
            this.Controls.Add(this.lbl40019);
            this.Controls.Add(this.lbl40018);
            this.Controls.Add(this.txt40019);
            this.Controls.Add(this.txt40018);
            this.Controls.Add(this.lbl40017);
            this.Controls.Add(this.lbl40016);
            this.Controls.Add(this.txt40017);
            this.Controls.Add(this.lbl40015);
            this.Controls.Add(this.txt40016);
            this.Controls.Add(this.txt40015);
            this.Controls.Add(this.lbl40014);
            this.Controls.Add(this.lbl40013);
            this.Controls.Add(this.txt40014);
            this.Controls.Add(this.lbl40012);
            this.Controls.Add(this.txt40013);
            this.Controls.Add(this.txt40012);
            this.Controls.Add(this.lbl40011);
            this.Controls.Add(this.lbl40010);
            this.Controls.Add(this.txt40011);
            this.Controls.Add(this.lbl40009);
            this.Controls.Add(this.txt40010);
            this.Controls.Add(this.txt40009);
            this.Controls.Add(this.lbl40008);
            this.Controls.Add(this.lbl40007);
            this.Controls.Add(this.txt40008);
            this.Controls.Add(this.lbl40006);
            this.Controls.Add(this.txt40007);
            this.Controls.Add(this.txt40006);
            this.Controls.Add(this.lbl40005);
            this.Controls.Add(this.lbl40004);
            this.Controls.Add(this.txt40005);
            this.Controls.Add(this.lbl40003);
            this.Controls.Add(this.txt40004);
            this.Controls.Add(this.txt40003);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl40002);
            this.Controls.Add(this.lbl40001);
            this.Controls.Add(this.txt40002);
            this.Controls.Add(this.lbl40000);
            this.Controls.Add(this.txt40001);
            this.Controls.Add(this.txt40000);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModbusRTU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real-Time: Read Holding Registers With Modbus RTU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModbusRTU_FormClosing);
            this.Load += new System.EventHandler(this.FormModbusRTU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt40000;
        private System.Windows.Forms.Label txt40001;
        private System.Windows.Forms.Label lbl40000;
        private System.Windows.Forms.Label lbl40001;
        private System.Windows.Forms.Label txt40002;
        private System.Windows.Forms.Label lbl40002;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl40005;
        private System.Windows.Forms.Label lbl40004;
        private System.Windows.Forms.Label txt40005;
        private System.Windows.Forms.Label lbl40003;
        private System.Windows.Forms.Label txt40004;
        private System.Windows.Forms.Label txt40003;
        private Label lbl40011;
        private Label lbl40010;
        private Label txt40011;
        private Label lbl40009;
        private Label txt40010;
        private Label txt40009;
        private Label lbl40008;
        private Label lbl40007;
        private Label txt40008;
        private Label lbl40006;
        private Label txt40007;
        private Label txt40006;
        private Label lbl40017;
        private Label lbl40016;
        private Label txt40017;
        private Label lbl40015;
        private Label txt40016;
        private Label txt40015;
        private Label lbl40014;
        private Label lbl40013;
        private Label txt40014;
        private Label lbl40012;
        private Label txt40013;
        private Label txt40012;
        private Label lbl40019;
        private Label lbl40018;
        private Label txt40019;
        private Label txt40018;
    }
}

