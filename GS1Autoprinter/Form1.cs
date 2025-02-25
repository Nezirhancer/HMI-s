using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using VncSharp;

namespace GS1Autoprinter
{
    public partial class Form1 : Form
    {
        int VNC_control, Cycle_control;
        string Labels;
        string NewLabelDesign;
        int sayac = 0;
        int sayacx = 0;
        int m1 = 0;
        int m2 = 0;
        int otoStart;
        string yy, mm, dd, ww;
        ModbusClient modbus = new ModbusClient();
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += YourForm_FormClosing;
        }

        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the close button (X) was clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // The close button (X) was clicked with the mouse
                Login Login_ = new Login();

                // Show the second form
                Login_.Show();
                this.Hide();

                // Optionally, you can perform additional actions or prevent the form from closing
                // e.Cancel = true; // Uncomment this line to prevent the form from closing
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(inputRegister);
            Application.Idle += new EventHandler(VNC);
            textBox1.Text = "10.90.21.172";
            textBox2.Text = "10.90.21.172";
            
        }
        public void VNC(object sender, EventArgs e)
        {
            int control = 0;
            if (remoteDesktop1.IsConnected && control == 0)
            {
                remoteDesktop1.SetScalingMode(true);
                control = 1;
            }
            else if (remoteDesktop1.IsConnected == false)
                control = 0;

        }
        private void button1_Click(object sender, EventArgs e)//modbus connect
        {
            modbus.IPAddress = Convert.ToString(textBox1.Text);
            modbus.Port = Convert.ToInt32("502");
            if (this.textBox1.Text != "")
            {
                try
                {
                    modbus.Connect();
                }
                catch
                {
                    MessageBox.Show("Not Connection");
                }
            }
            else
            {
                MessageBox.Show("Ip Adresi Giriniz.");
            }
            if (modbus.Connected)
                label1.Text = "Connected";
        }

        private void button2_Click(object sender, EventArgs e)//modbus disconnect
        {
            if (modbus.Connected == true)
            {
                modbus.Disconnect();
                label1.Text = "No connection";
                label6.Text = "No connection";
                label7.Text = "No connection";
                label8.Text = "No connection";
                label10.Text = "No connection";

            }
        }

        private void button5_Click(object sender, EventArgs e)//Start
        {
            otoStart = 1;
            
        }
        private void button6_Click(object sender, EventArgs e)//Stop
        {
            otoStart = 3;
            
        }
        private void button7_Click(object sender, EventArgs e)//Reset
        {
            otoStart = 2;
            sayac = 0;
            label21.Text = sayac.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)//VNC Connect
        {
            if (remoteDesktop1.IsConnected == false)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("IP Adres giriniz.");
                }
                else
                {
                    try
                    {
                        VNC_control = 0;
                        remoteDesktop1.Connect(textBox2.Text);
                        remoteDesktop1.MouseClick += RemoteDesktop1_MouseClick;
                    }
                    catch
                    {
                        VNC_control = 1;
                        if (VNC_control == 1)
                        {
                            MessageBox.Show("Connection failed.");
                            VNC_control = 2;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Zaten bir ağa bağlısın.");
            }
        }
        private void RemoteDesktop1_MouseClick(object sender, MouseEventArgs e)
        {
            // Fare tıklamasını engelle
         
        }

        private void button4_Click(object sender, EventArgs e)//VNC Disconnect
        {
            remoteDesktop1.Disconnect();
        }

        private void button8_Click(object sender, EventArgs e)//Online Command
        {
            modbus.WriteSingleRegister(0, 1);
        }

        private void button9_Click(object sender, EventArgs e)//Offline Command
        {
            modbus.WriteSingleRegister(0, 0);
        }

      

        private void button10_Click(object sender, EventArgs e)//Reset Command
        {
            modbus.WriteSingleRegister(19, 1);
        }

       

        public void date()
        {
            DateTime now = DateTime.Now;
            CultureInfo ci = CultureInfo.CurrentCulture;
            int weekNumber = ci.Calendar.GetWeekOfYear(now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            yy = now.ToString("yy");
            mm = now.ToString("MM");
            dd = now.ToString("dd");
            ww = weekNumber.ToString();

        } 
        private void button8_Click_1(object sender, EventArgs e)//LP4777
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1080,1200^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1110,1450^A@I,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1085,235^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)40517949221119^FS" +
                "^FO1230,200^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO1115,165^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT1850,120^BXI,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/40517949221119?13=" + yy + mm + dd + "^FS^XZ";
            //richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        } 
        private void button9_Click_1(object sender, EventArgs e)//LP4778
        {
            date();
            string ip_adress = "10.90.21.172";

            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1860,750^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)50517944221119^FS" +
                "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT610,40^BXR,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/50517944221119?13=" + yy + mm + dd + "^FS^XZ";
            //richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        } 
        private void button11_Click(object sender, EventArgs e)//LP4780
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1080,1200^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1110,1450^A@I,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1085,235^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)80517947221119^FS" +
                "^FO1230,200^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO1115,165^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT1850,120^BXI,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/80517947221119?13=" + yy + mm + dd + "^FS^XZ";
            //richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        } 
        private void button10_Click_1(object sender, EventArgs e)//LP4781
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1860,750^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)00517946221119^FS" +
                "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT610,40^BXR,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/00517946221119?13=" + yy + mm + dd + "^FS^XZ";
            //richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        } 
        public void inputRegister(object sender, EventArgs e)
        {
            try
            {
                Cycle_control = 1;
                if (!modbus.Connected)
                    return;
                int[] InputRegister = modbus.ReadInputRegisters(0, 25);
                modbus.ReadHoldingRegisters(4, 1);
                switch (InputRegister[0])
                {
                    case 1:
                        label6.Text = "Offline";
                        break;
                    case 2:
                        label6.Text = "Online";
                        break;
                    case 9:
                        label6.Text = "Alarm";
                        break;
                    case 16:
                        label6.Text = "Test";
                        break;
                }
                switch (InputRegister[4])
                {
                    case 0:
                        label7.Text = "Idle";
                        break;
                    case 1:
                        label7.Text = "Printing";
                        break;
                    case 4:
                        label7.Text = "Ok, Wait next one";
                        break;
                }
                switch (InputRegister[7])
                {
                    case 0:
                        label8.Text = "No Seq";
                        break;
                    case 1:
                        label8.Text = "Success";
                        break;
                    case 13385:
                        label8.Text = "Test";
                        break;
                    case 16384:
                        label8.Text = "Data Valid";
                        break;
                    case 32768:
                        label8.Text = "Printed";
                        break;
                }
               
                switch (InputRegister[24])
                {
                    case 0:
                        label10.Text = "No Job !";
                        break;
                    case 1:
                        label10.Text = "Job Available !";
                        break;
                    case 3:
                        label10.Text = "Ready to Print :)";
                        break;
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    int adet = Convert.ToInt32(textBox3.Text);
                    if (adet == sayac)
                    {

                        otoStart = 2;
                        label20.Text = sayac.ToString();// last value
                    }
                }

                if (InputRegister[7] >= 16384 && m1 == 0)//Etiket Basma Başarılı
                {
                    m1 = 1;//Print Completed  
                }
                label23.Text = m1.ToString();//Ok
                label25.Text = m2.ToString();//Print Command
                try
                {
                    if (otoStart == 1 && Convert.ToInt32(textBox3.Text) > 1 /*Adet 1 den büyükse*/
                            && InputRegister[0] == 2 /*Online İse*/
                            && InputRegister[24] == 3/*Etiket Varsa*/
                            && sayac != Convert.ToInt32(textBox3.Text) /*Sayac 0'a eşit değil ise*/)
                    {
                        modbus.WriteSingleRegister(4, 0);//Print Command
                        m2 = 1;//Printer Command Given
                    }
                    if (m1 == 1 && m2 == 1)
                    {

                        m1 = 0;
                        m2 = 0;
                        sayac = sayac + 1;
                        label21.Text = sayac.ToString(); //total value
                    }

                }
                catch
                {
                    MessageBox.Show("Şart Sağlanmadı \n\r -Adet \n\r -No Alarm \n\r -Online \n\r -Job Available.");
                    otoStart = 0;
                }


            }
            catch
            {
                MessageBox.Show("Connection failed.");
                label1.Text = "No connection"; 
                label6.Text = "No connection";
                label7.Text = "No connection";
                label8.Text = "No connection";
                label10.Text = "No connection";
                modbus.Disconnect();
            }
            label27.Text = otoStart.ToString();
        }
    }
}
