using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKho
{
    public partial class Trang_Chu : Form
    {
        string chuoikn = @"Data Source=NOKIA-E490\SQLExpress;Initial Catalog=QuanLy_KHO;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
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
        public void Hienthi()
        {
            sql = "select MA_HH,TEN_HH,SOLUONG,TEN_NCC,TENLOAI_HH,SOLUONGLOI,NCC.MA_NCC,LHH.MA_LOAI_HH from HANGHOA HH, LOAIHANGHOA LHH, NHACUNGCAP NCC " +
                " WHERE HH.MA_LOAI_HH = LHH.MA_LOAI_HH AND HH.MA_NCC = NCC.MA_NCC";
            ketnoi = new SqlConnection(chuoikn);
            ketnoi.Open();
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            lst_dsHH.Items.Clear();
            i = 0;
            while (docdulieu.Read())
            {
                lst_dsHH.Items.Add(docdulieu[0].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[1].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[2].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[3].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[4].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[5].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[6].ToString());
                lst_dsHH.Items[i].SubItems.Add(docdulieu[7].ToString());
                i++;
            }
            ketnoi.Close();
        }
        private void btn_QLHH_Click(object sender, EventArgs e)
        {
            pn_hanghoa.Visible = true;
            pn_hanghoa.Dock = DockStyle.Fill;
            pn_trang_chu.Visible = false;
            button2.Font = new Font(button2.Font.FontFamily, 8);
            btn_QLXuat.Font = new Font(btn_QLXuat.Font.FontFamily, 8);
            btn_QLNhap.Font = new Font(btn_QLNhap.Font.FontFamily, 8);
            btn_QLDT.Font = new Font(btn_QLDT.Font.FontFamily, 8);
            btn_QLHH.Font = new Font(btn_QLHH.Font.FontFamily, 11);
            Hienthi();
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
            pn_trang_chu.Visible = true;
            pn_trang_chu.Dock = DockStyle.Fill;
            pn_hanghoa.Visible = false;
        }

        private void Trang_Chu_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoikn);
            pn_trang_chu.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lst_dsHH_Click(object sender, EventArgs e)
        {
            txt_maHH.Text = txt_sua_maHH.Text = lst_dsHH.SelectedItems[0].SubItems[0].Text;
            txt_maloaiHH.Text = cb_Sua_maloai.Text = lst_dsHH.SelectedItems[0].SubItems[7].Text;
            txt_maNCC.Text = cb_sua_mancc.Text = lst_dsHH.SelectedItems[0].SubItems[6].Text;
            txt_slLoi.Text = txt_sua_soluongloi.Text = lst_dsHH.SelectedItems[0].SubItems[5].Text;
            txt_soluong.Text = txt_sua_soluongHH.Text = lst_dsHH.SelectedItems[0].SubItems[2].Text;
            txt_tenHH.Text = txt_sua_tenHH.Text = lst_dsHH.SelectedItems[0].SubItems[1].Text;
            txt_tenNCC.Text = lst_dsHH.SelectedItems[0].SubItems[3].Text;
            txt_tenloaiHH.Text = lst_dsHH.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_xoa_hh_Click(object sender, EventArgs e)
        {

            try
            {
                ketnoi = new SqlConnection(chuoikn);
                ketnoi.Open();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DialogResult a = MessageBox.Show("Bạn muốn xóa hàng hóa này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    //sql = "delete from NHANVIEN where(MANV = '" + cbManv.Text + "')";
                    sql = "delete from HANGHOA WHERE MA_HH='" + txt_sua_maHH.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    DialogResult b = MessageBox.Show("Xóa thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (b == DialogResult.OK)
                    {
                        ketnoi.Close();
                    }
                }
                if (a == DialogResult.No)
                {
                    ketnoi.Close();
                }
            }
        }

        private void btn_sua_hh_Click(object sender, EventArgs e)
        {
            gr_sua.Visible = true;

        }

        private void btn_exit_sua_Click(object sender, EventArgs e)
        {
            gr_sua.Visible = false;
        }

        private void btn_capnhat_sua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {

                sql = "update HANGHOA set TEN_HH=N'" + txt_sua_tenHH.Text + "' where MA_HH ='" + txt_sua_maHH.Text + "'" +
                      "update HANGHOA set SOLUONG ='" + int.Parse(txt_sua_soluongHH.Text) + "' where MA_HH ='" + txt_sua_maHH.Text + "'" +
                      "update HANGHOA set MA_NCC =N'" + cb_sua_mancc.Text + "' where MA_HH ='" + txt_sua_maHH.Text + "'" +
                      "update HANGHOA set MA_LOAI_HH ='" + cb_Sua_maloai.Text + "' where MA_HH ='" + txt_sua_maHH.Text + "'" +
                      "update HANGHOA set SOLUONGLOI ='" + int.Parse(txt_sua_soluongloi.Text) + "' where MA_HH ='" + txt_sua_maHH.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

            }
            finally
            {
                DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK) gr_sua.Visible = false;
            }
            ketnoi.Close();
        }

        private void btn_timhh_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoikn);
            ketnoi.Open();
            sql = "select MA_HH,TEN_HH,SOLUONG,TEN_NCC,TENLOAI_HH,SOLUONGLOI,NCC.MA_NCC,LHH.MA_LOAI_HH from HANGHOA HH, LOAIHANGHOA LHH, NHACUNGCAP NCC " +
                " WHERE HH.MA_LOAI_HH = LHH.MA_LOAI_HH AND HH.MA_NCC = NCC.MA_NCC AND HH.TEN_HH LIKE N'%" + txt_tim_tenhh.Text + "%'";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            lst_dsHH.Items.Clear();
            if (docdulieu.Read())
            {
                i = 0;
                while (docdulieu.Read())
                {
                    lst_dsHH.Items.Add(docdulieu[0].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[5].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[6].ToString());
                    lst_dsHH.Items[i].SubItems.Add(docdulieu[7].ToString());
                    i++;
                }
                ketnoi.Close();
            }
            else
            {
                DialogResult d = MessageBox.Show("Không có hàng hóa!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txt_tim_tenhh_Click(object sender, EventArgs e)
        {
            txt_tim_tenhh.Text = "";
        }
    }
}
