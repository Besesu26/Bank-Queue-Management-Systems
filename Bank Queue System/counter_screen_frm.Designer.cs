
namespace Bank_Queue_System
{
    partial class counter_screen_frm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_timer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ticket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_recall = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.ticket_List = new System.Windows.Forms.DataGridView();
            this.Tick_List = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ticket_List);
            this.splitContainer1.Size = new System.Drawing.Size(1162, 479);
            this.splitContainer1.SplitterDistance = 973;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer2.Panel2.Controls.Add(this.btn_close);
            this.splitContainer2.Panel2.Controls.Add(this.btn_start);
            this.splitContainer2.Panel2.Controls.Add(this.btn_recall);
            this.splitContainer2.Panel2.Controls.Add(this.btn_next);
            this.splitContainer2.Size = new System.Drawing.Size(973, 479);
            this.splitContainer2.SplitterDistance = 731;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lb_timer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_ticket);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(105, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 406);
            this.panel2.TabIndex = 4;
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timer.Location = new System.Drawing.Point(107, 332);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(159, 39);
            this.lb_timer.TabIndex = 3;
            this.lb_timer.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serving Time";
            // 
            // lb_ticket
            // 
            this.lb_ticket.AutoSize = true;
            this.lb_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ticket.Location = new System.Drawing.Point(85, 121);
            this.lb_ticket.Name = "lb_ticket";
            this.lb_ticket.Size = new System.Drawing.Size(0, 108);
            this.lb_ticket.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Serving Ticket Number";
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_close.Location = new System.Drawing.Point(0, 411);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(238, 68);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_start
            // 
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_start.Location = new System.Drawing.Point(0, 136);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(238, 68);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_recall
            // 
            this.btn_recall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recall.Location = new System.Drawing.Point(0, 68);
            this.btn_recall.Name = "btn_recall";
            this.btn_recall.Size = new System.Drawing.Size(238, 68);
            this.btn_recall.TabIndex = 1;
            this.btn_recall.Text = "Recall";
            this.btn_recall.UseVisualStyleBackColor = true;
            this.btn_recall.Click += new System.EventHandler(this.btn_Recall_Click);
            // 
            // btn_next
            // 
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_next.Location = new System.Drawing.Point(0, 0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(238, 68);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // ticket_List
            // 
            this.ticket_List.AllowUserToAddRows = false;
            this.ticket_List.AllowUserToDeleteRows = false;
            this.ticket_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticket_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tick_List});
            this.ticket_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket_List.Location = new System.Drawing.Point(0, 0);
            this.ticket_List.Name = "ticket_List";
            this.ticket_List.ReadOnly = true;
            this.ticket_List.RowHeadersVisible = false;
            this.ticket_List.Size = new System.Drawing.Size(185, 479);
            this.ticket_List.TabIndex = 0;
            // 
            // Tick_List
            // 
            this.Tick_List.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tick_List.HeaderText = "Ticket Queue";
            this.Tick_List.Name = "Tick_List";
            this.Tick_List.ReadOnly = true;
            this.Tick_List.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tick_List.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.lb_time);
            this.panel1.Controls.Add(this.lb_Date);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 52);
            this.panel1.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(731, 14);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(60, 24);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "label2";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(989, 22);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(35, 13);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "label4";
            // 
            // lb_Date
            // 
            this.lb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(989, 9);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(35, 13);
            this.lb_Date.TabIndex = 1;
            this.lb_Date.Text = "label3";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(977, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(185, 52);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // counter_screen_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 531);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "counter_screen_frm";
            this.Text = "counter_screen_frm";
            this.Load += new System.EventHandler(this.counter_screen_frm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ticket_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tick_List;
        private System.Windows.Forms.Label lb_ticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_recall;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer4;
    }
}