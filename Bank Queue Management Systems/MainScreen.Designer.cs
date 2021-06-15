
namespace Bank_Queue_Management_Systems
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTicket = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCounter = new FontAwesome.Sharp.IconButton();
            this.btnTVDisplay = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(91, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Bank ";
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.White;
            this.btnTicket.FlatAppearance.BorderSize = 3;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnTicket.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket.IconSize = 40;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTicket.Location = new System.Drawing.Point(65, 165);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(280, 45);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Ticket Screen";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Queue Management Systems";
            // 
            // btnCounter
            // 
            this.btnCounter.BackColor = System.Drawing.Color.White;
            this.btnCounter.FlatAppearance.BorderSize = 3;
            this.btnCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounter.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnCounter.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCounter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnCounter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCounter.IconSize = 40;
            this.btnCounter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCounter.Location = new System.Drawing.Point(65, 230);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(280, 45);
            this.btnCounter.TabIndex = 3;
            this.btnCounter.Text = "Counter Screen";
            this.btnCounter.UseVisualStyleBackColor = false;
            // 
            // btnTVDisplay
            // 
            this.btnTVDisplay.BackColor = System.Drawing.Color.White;
            this.btnTVDisplay.FlatAppearance.BorderSize = 3;
            this.btnTVDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTVDisplay.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnTVDisplay.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.btnTVDisplay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnTVDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTVDisplay.IconSize = 40;
            this.btnTVDisplay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTVDisplay.Location = new System.Drawing.Point(65, 295);
            this.btnTVDisplay.Name = "btnTVDisplay";
            this.btnTVDisplay.Size = new System.Drawing.Size(280, 45);
            this.btnTVDisplay.TabIndex = 4;
            this.btnTVDisplay.Text = "TV Display Screen";
            this.btnTVDisplay.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 85);
            this.panel1.TabIndex = 5;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(409, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTVDisplay);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTicket;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCounter;
        private FontAwesome.Sharp.IconButton btnTVDisplay;
        private System.Windows.Forms.Panel panel1;
    }
}

