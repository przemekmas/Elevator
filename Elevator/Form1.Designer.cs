namespace WindowsFormsApplication1
{
    partial class Elevator
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
            this.Floor1 = new System.Windows.Forms.Button();
            this.Floor0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logbutton = new System.Windows.Forms.Button();
            this.floor1btn = new System.Windows.Forms.Button();
            this.floor0btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor1
            // 
            this.Floor1.Location = new System.Drawing.Point(107, 132);
            this.Floor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Floor1.Name = "Floor1";
            this.Floor1.Size = new System.Drawing.Size(39, 33);
            this.Floor1.TabIndex = 0;
            this.Floor1.Text = "1";
            this.Floor1.UseVisualStyleBackColor = true;
            this.Floor1.Click += new System.EventHandler(this.Floor1_Click);
            // 
            // Floor0
            // 
            this.Floor0.Location = new System.Drawing.Point(107, 465);
            this.Floor0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Floor0.Name = "Floor0";
            this.Floor0.Size = new System.Drawing.Size(39, 33);
            this.Floor0.TabIndex = 1;
            this.Floor0.Text = "0";
            this.Floor0.UseVisualStyleBackColor = true;
            this.Floor0.Click += new System.EventHandler(this.Floor0_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 264);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // logbutton
            // 
            this.logbutton.Location = new System.Drawing.Point(510, 260);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(423, 22);
            this.logbutton.TabIndex = 4;
            this.logbutton.Text = "View Log";
            this.logbutton.UseVisualStyleBackColor = true;
            this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
            // 
            // floor1btn
            // 
            this.floor1btn.Location = new System.Drawing.Point(468, 525);
            this.floor1btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.floor1btn.Name = "floor1btn";
            this.floor1btn.Size = new System.Drawing.Size(50, 22);
            this.floor1btn.TabIndex = 5;
            this.floor1btn.Text = "floor 1";
            this.floor1btn.UseVisualStyleBackColor = true;
            this.floor1btn.Click += new System.EventHandler(this.floor1btn_Click);
            // 
            // floor0btn
            // 
            this.floor0btn.Location = new System.Drawing.Point(468, 565);
            this.floor0btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.floor0btn.Name = "floor0btn";
            this.floor0btn.Size = new System.Drawing.Size(50, 22);
            this.floor0btn.TabIndex = 6;
            this.floor0btn.Text = "floor 0";
            this.floor0btn.UseVisualStyleBackColor = true;
            this.floor0btn.Click += new System.EventHandler(this.floor0btn_Click);
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 618);
            this.Controls.Add(this.floor0btn);
            this.Controls.Add(this.floor1btn);
            this.Controls.Add(this.logbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Floor0);
            this.Controls.Add(this.Floor1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Elevator";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Elevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Floor1;
        private System.Windows.Forms.Button Floor0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.Button floor1btn;
        private System.Windows.Forms.Button floor0btn;
    }
}

