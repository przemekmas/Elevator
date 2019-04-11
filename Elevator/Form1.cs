using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Elevator : Form
    {
        private int x;
        private int y;
        private int width;
        private int floor1x;
        private int floor1width;
        private int number = 1;
                  
        public Elevator()
        {
            InitializeComponent();
            x = 236;
            y = 50;
            width = 89;
            floor1x = 236;
            floor1width = 89;
        }

        private void Floor1_Click(object sender, EventArgs e)
        {
            timer2.Start();//button 2 if is clicked timer2 takes the lift to floor1
            string date = DateTime.Now.ToString("d/MM/yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss");
            string text = "the lift is on the first floor";
            database(date, time, text);
        }

        private void Floor0_Click(object sender, EventArgs e)
        {
            timer1.Start(); // if button0 is clicked timer1 takes the lift to floor0 
            string date = DateTime.Now.ToString("d/MM/yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss");
            string text = "the lift is on the ground floor";
            database(date, time, text); 
        }

        private void Elevator_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//stops from flickering while running the code
            this.Paint +=new PaintEventHandler(Elevator_Paint);
        }

        private void Elevator_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkRed,30,5,400,600);// fills the building rectangle with darkred colour
            e.Graphics.DrawRectangle(Pens.Black, 30, 5, 400, 600);//draws whole building rectangle 

            e.Graphics.FillRectangle(Brushes.DarkCyan, 150, y, 174, 199);//fills  lift rectangle with darkcyan colour
            e.Graphics.DrawRectangle(Pens.Black, 150, y, 174, 199);//draws lift rectangle 

            e.Graphics.DrawRectangle(Pens.Black, 150, 50, 175,200);//draws floor 1 rectangle  
            
            e.Graphics.FillRectangle(Brushes.DarkGray, 150, 50, floor1width, 199);// fills darkgray colour in the left door of floor1
            e.Graphics.DrawRectangle(Pens.Black, 150, 50, floor1width, 199);//draws left door rectangle of floor 1
            
            e.Graphics.FillRectangle(Brushes.DarkGray, floor1x, 50, floor1width, 199);//fills darkgary colour in the right door of floor1 
            e.Graphics.DrawRectangle(Pens.Black, floor1x, 50, floor1width, 199);//draws right door of floor1

            e.Graphics.DrawRectangle(Pens.Black, 150, 370, 175, 200);//draws floor 0 rectangle

            e.Graphics.FillRectangle(Brushes.DarkGray, 150, 370, width, 199);//fills darkgray colour in the left door of floor0
            e.Graphics.DrawRectangle(Pens.Black, 150, 370, width, 199);//drwas left door of floor 0

            e.Graphics.FillRectangle(Brushes.DarkGray, x, 370, width, 199);//fills darkgray colour in right door of floor0
            e.Graphics.DrawRectangle(Pens.Black, x, 370, width, 199);//draws right door of floor 0
            
            e.Graphics.DrawLine(Pens.Black, 100, 300, 350, 300);
            e.Graphics.DrawLine(Pens.Black, 100, 9, 100, 600);
            e.Graphics.DrawLine(Pens.Black, 350, 9, 350, 600);


            e.Graphics.FillRectangle(Brushes.DarkGray, 450, 460, 80, 150);//control panel
            e.Graphics.DrawRectangle(Pens.Black, 450, 460, 80, 150);//Control panel

            SolidBrush brownBrush = new SolidBrush(Color.Black);

            Font myFont = new Font("Calibri", 40, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            
            e.Graphics.DrawString(number.ToString(), myFont, myBrush, 470, 455);
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 370)//  timer 1 here makes lift move  from floor 1 to floor0 till the y co-ordinate position of 370
            {
                y += 2;
                Invalidate();
            }
            else
            {
                timer1.Stop();// lift after reaches the ground floor stops 
                number = 0;
                number.ToString();
                timer3.Start();// after lift in floor0 stops, timer3 makes the door open

            }
            this.Refresh();// refreshes the timers
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y > 50)// makes the lift go from floor0 to floor1 back only if position of y co-ordinate is less than 50
            {
                y -= 2;
                Invalidate();
            }
            else
            {
                timer2.Stop();// makes the lift stop in floor1
                number = 1;
                number.ToString();
                timer5.Start();// makes the door open after timer2 stops
            }
            this.Refresh();// refreshes timers
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (width > 0)//opens door in floor0 if the width of door is less than 0
            {
                width--;//  left door in ground floor moves towards left
                x++;//right door in ground floor moves towards right
            }
            else
            {
                timer3.Stop();// stops the door in floor0 after it gets opened
                Thread.Sleep(2000);// holds the door for 2 seconds
                timer4.Start();// door in floor0 closes after thread is applied
            }
            this.Refresh();//refreshes timers 
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (width < 89)//closes door in floor0 if the floor width is less than 89
            {
                width++;//moves left door in floor0 towards right 
                x--;//moves right door in floor0 towards left
            }
            else
            {
                timer4.Stop();// makes the closing door function stop
            }
            this.Refresh();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (floor1width > 0)// opens door in floor1 if the floorwidth is less than 0
            {
                floor1width--;//makes the left door move towards left in floor1 
                floor1x++;// makes the right door move towards right in floor1
            }
            else
            {
                timer5.Stop();//after the door opens in floor1 timer5 stops
                Thread.Sleep(2000);// door stops for 2 seconds after timer5 stops
                timer6.Start();// closing door function starts after thread function is applied
            }
            this.Refresh();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (floor1width < 89)//closes door if floor width is less than 89 in floor 1
            {
                floor1width++;// makes the left door moves towards right in floor1
                floor1x--;// makes the right door move towards left in floor1
            }
            else
            {
                timer6.Stop();// makes the timer6 stops which closes doors of lift in floor1
            }
            this.Refresh();
        }

        
        public void database(string date, string time, string text)
        {
            string connectionstring = null;
            OleDbConnection connection;//connects to database 
            OleDbDataAdapter adapter;
            DataSet ds = new DataSet();
            // int i = 0;
            connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source=Database.accdb";
            connection = new OleDbConnection(connectionstring);


            try
            {
                connection.Open();
                adapter = new OleDbDataAdapter("INSERT INTO elevatorDatabase([Date],[time],[text]) VALUES('" + date + "', '" + time + "','" + text + "')", connection);
                adapter.Fill(ds);
                MessageBox.Show("User Account Succefully Created", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                adapter.Dispose();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            string connectionstring = null;
            OleDbConnection connection;
            OleDbDataAdapter adapter;
            DataSet ds = new DataSet();
            // int i = 0;
            connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =Database.accdb;"; ;
            connection = new OleDbConnection(connectionstring);

            try
            {
                connection.Open();
                adapter = new OleDbDataAdapter("SELECT * FROM elevatorDatabase", connection);//gets the details from the database
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;//stores this details in the datagrid view
                adapter.Dispose();
                // System.Windows.Forms.MessageBox.Show("User Account Succefully Created", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                adapter.Dispose();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void floor0btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string date = DateTime.Now.ToString("d/MM/yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss");
            string text = "the elevator is on ground floor";
            database(date, time, text);
        }

        private void floor1btn_Click(object sender, EventArgs e)
        {
            timer2.Start();
            string date = DateTime.Now.ToString("d/MM/yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss");
            string text = "the lift is on the first floor";
            database(date, time, text);
        }
    }
    
}

