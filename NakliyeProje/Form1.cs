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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NakliyeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void liste()
        {
            da = new SqlDataAdapter("select * from tblnakliye", bgl.baglanti());
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        Baglanti bgl = new Baglanti();
        DataTable dt;
        SqlDataAdapter da;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nakliyeProjeDataSet1.TblNakliye' table. You can move, or remove it, as needed.
            this.tblNakliyeTableAdapter1.Fill(this.nakliyeProjeDataSet1.TblNakliye);
            liste();
            dateTimePicker1.Value= DateTime.Now;
            dateTimePicker2.Value= DateTime.Now;
            dateTimePicker3.Value= DateTime.Now;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tblnakliye (alınan,masraf,kdvtutar,kar,nereden,nereye,tarih,acıklama) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@a1", Convert.ToDecimal(TxtAlinan.Text));
                cmd.Parameters.AddWithValue("@a2", Convert.ToDecimal(TxtMasraf.Text));
                cmd.Parameters.AddWithValue("@a3", Convert.ToDecimal(TxtKdv.Text));
                cmd.Parameters.AddWithValue("@a4", Convert.ToDecimal(TxtKar.Text));
                cmd.Parameters.AddWithValue("@a5", TxtNereden.Text);
                cmd.Parameters.AddWithValue("@a6", TxtNereye.Text);
                cmd.Parameters.Add("@a7", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@a8", SqlDbType.VarChar, 75).Value = TxtAciklama.Text;
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt İşlemi Tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girilen Değerleri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        double kdvtutar, kar, alinan, masraf;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsil = new SqlCommand("delete from TblNakliye where ıd=@p1", bgl.baglanti());
            cmdsil.Parameters.AddWithValue("@p1", TxtId.Text);
            cmdsil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            liste();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdguncelle = new SqlCommand("update TblNakliye set alınan=@p1,masraf=@p2,kdvtutar=@p3,kar=@p4,nereden=@p5,nereye=@p6,tarih=@p7,acıklama=@p8 where ıd=@p9", bgl.baglanti());
                cmdguncelle.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtAlinan.Text));
                cmdguncelle.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtMasraf.Text));
                cmdguncelle.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtKdv.Text));
                cmdguncelle.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtKar.Text));
                cmdguncelle.Parameters.AddWithValue("@p5", TxtNereden.Text);
                cmdguncelle.Parameters.AddWithValue("@p6", TxtNereye.Text);
                cmdguncelle.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
                cmdguncelle.Parameters.AddWithValue("@p8", TxtAciklama.Text);
                cmdguncelle.Parameters.AddWithValue("@p9", TxtId.Text);
                cmdguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Tamamlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girilen Değerleri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("tarih > '{0}' AND tarih <= '{1}'", dateTimePicker2.Value, dateTimePicker3.Value);
            dataGridView1.DataSource = dv;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //GENEL TOPLAM
            int satir = dataGridView1.Rows.Count - 1;
            double geneltoplam = 0;
            for (int i = 0; i < satir; i++)
            {
                geneltoplam = geneltoplam + double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            LblGenelToplam.Text = " Genel Toplam = " + string.Format("{0:C2}", geneltoplam);
            {
                //TOPLAM MASRAF
                int satir2 = dataGridView1.Rows.Count - 1;
                double toplammasraf = 0;
                for (int i = 0; i < satir2; i++)
                {
                    toplammasraf = toplammasraf + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                lblmasraf.Text = " Toplam Masraf = " + string.Format("{0:C2}", toplammasraf);
                {
                    //TOPLAM KDV
                    int satir3 = dataGridView1.Rows.Count - 1;
                    double toplamkdv = 0;
                    for (int i = 0; i < satir3; i++)
                    {
                        toplamkdv = toplamkdv + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                    LblToplamKdv.Text = " Toplam Kdv = " + string.Format("{0:C2}", toplamkdv);
                }
                //TOPLAM KAR
                int satir4 = dataGridView1.Rows.Count - 1;
                double toplamkar = 0;
                for (int i = 0; i < satir4; i++)
                {
                    toplamkar = toplamkar + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                LblToplamKar.Text = " Toplam Kâr = " + string.Format("{0:C2}", toplamkar);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                TxtAlinan.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtMasraf.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtKdv.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                TxtKar.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                TxtNereden.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtNereye.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
                TxtAciklama.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Alan Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = " ";
            TxtAlinan.Text = " ";
            TxtMasraf.Text = " ";
            TxtKdv.Text = " ";
            TxtKar.Text = " ";
            TxtNereden.Text = " ";
            TxtNereye.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            TxtAciklama.Text = " ";
        }
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                alinan = Convert.ToDouble(TxtAlinan.Text);
                masraf = Convert.ToDouble(TxtMasraf.Text);
                kdvtutar = alinan * 1.18 - alinan;
                kar = alinan - masraf - kdvtutar;
                TxtKdv.Text = kdvtutar.ToString("0.00");
                TxtKar.Text = kar.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girilen Değerleri Kontrol Ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
