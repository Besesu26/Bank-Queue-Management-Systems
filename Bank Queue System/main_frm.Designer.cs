
namespace Bank_Queue_System
{
    partial class main_frm
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
            this.btn_ticketScreen = new System.Windows.Forms.Button();
            this.btn_counter = new System.Windows.Forms.Button();
            this.btn_TVDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ticketScreen
            // 
            this.btn_ticketScreen.Location = new System.Drawing.Point(55, 116);
            this.btn_ticketScreen.Name = "btn_ticketScreen";
            this.btn_ticketScreen.Size = new System.Drawing.Size(186, 50);
            this.btn_ticketScreen.TabIndex = 0;
            this.btn_ticketScreen.Text = "Ticket Screen";
            this.btn_ticketScreen.UseVisualStyleBackColor = true;
            this.btn_ticketScreen.Click += new System.EventHandler(this.btn_ticketScreen_Click);
            // 
            // btn_counter
            // 
            this.btn_counter.Location = new System.Drawing.Point(55, 172);
            this.btn_counter.Name = "btn_counter";
            this.btn_counter.Size = new System.Drawing.Size(186, 50);
            this.btn_counter.TabIndex = 1;
            this.btn_counter.Text = "Counter Screen";
            this.btn_counter.UseVisualStyleBackColor = true;
            this.btn_counter.Click += new System.EventHandler(this.btn_counter_Click);
            // 
            // btn_TVDisplay
            // 
            this.btn_TVDisplay.Location = new System.Drawing.Point(55, 228);
            this.btn_TVDisplay.Name = "btn_TVDisplay";
            this.btn_TVDisplay.Size = new System.Drawing.Size(186, 50);
            this.btn_TVDisplay.TabIndex = 2;
            this.btn_TVDisplay.Text = "TV Display Screen";
            this.btn_TVDisplay.UseVisualStyleBackColor = true;
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 324);
            this.Controls.Add(this.btn_TVDisplay);
            this.Controls.Add(this.btn_counter);
            this.Controls.Add(this.btn_ticketScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main_frm";
            this.Text = "Wellcome to Boss Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ticketScreen;
        private System.Windows.Forms.Button btn_counter;
        private System.Windows.Forms.Button btn_TVDisplay;
    }
}

