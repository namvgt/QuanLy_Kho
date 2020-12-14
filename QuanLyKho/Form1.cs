using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
     public partial class Trang_Chu : Form
     {
          public Trang_Chu()
          {
               InitializeComponent();
               button2.Font = new Font(button2.Font.FontFamily, 11);
          }

          

          private void btn_QLHH_MouseLeave(object sender, EventArgs e)
          {
               btn_QLHH.BackColor = Color.RoyalBlue;
          }

          private void btn_QLHH_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLHH.BackColor = Color.Red;
          }

          private void btn_QLHH_Click(object sender, EventArgs e)
          {
               button2.Font = new Font(button2.Font.FontFamily, 8);
               btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 8);
               btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 8);
               btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 11);
          }

          private void btn_QLNhap_MouseLeave(object sender, EventArgs e)
          {
               btn_QLNhap.BackColor = Color.RoyalBlue;
          }

          private void btn_QLNhap_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLNhap.BackColor = Color.Red;
          }

          private void btn_QLNhap_Click(object sender, EventArgs e)
          {
               button2.Font = new Font(button2.Font.FontFamily, 8);
               btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 8);
               btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 11);
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 8);
               btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 8);
          }

          private void btn_QLXuat_MouseLeave(object sender, EventArgs e)
          {
               btn_QLXuat.BackColor = Color.RoyalBlue;
          }

          private void btn_QLXuat_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLXuat.BackColor = Color.Red;
          }

          private void btn_QLXuat_Click(object sender, EventArgs e)
          {
               button2.Font = new Font(button2.Font.FontFamily, 8);
               btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 11);
               btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 8);
               btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 8);
          }

          private void btn_QLDT_MouseLeave(object sender, EventArgs e)
          {
               btn_QLDT.BackColor = Color.RoyalBlue;
          }

          private void btn_QLDT_MouseMove(object sender, MouseEventArgs e)
          {
               btn_QLDT.BackColor = Color.Red;
          }

          private void btn_QLDT_Click(object sender, EventArgs e)
          {
               button2.Font = new Font(button2.Font.FontFamily, 8);
               btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 8);
               btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 11);
               btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 8);
          }

          private void btn_exit_MouseLeave(object sender, EventArgs e)
          {
               btn_exit.BackColor = Color.RoyalBlue;
          }

          private void btn_exit_MouseMove(object sender, MouseEventArgs e)
          {
               btn_exit.BackColor = Color.Red;
          }

          private void btn_exit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void button2_MouseLeave(object sender, EventArgs e)
          {
               button2.BackColor = Color.RoyalBlue;
          }

          private void button2_MouseMove(object sender, MouseEventArgs e)
          {
               button2.BackColor = Color.Red;
          }

          private void button2_Click(object sender, EventArgs e)
          {
               button2.Font = new Font(button2.Font.FontFamily, 11);
               btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 8);
               btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 8);
               btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 8);
               btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 8);
          }
     }
}
