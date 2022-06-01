/**********************************************************
**                SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                  2019-2020 BAHAR DÖNEMİ
**             
**             ÖDEV NUMARASI......: Ödev 1
**             ÖĞRENCİ ADI........: Esra AKSU
**             ÖĞRENCİ NUMARASI...: B191200370
**         DERSİN ALINDIĞI GRUP...: A
**********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dvd_koleksiyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // DVD Ekleme formunda kaydedilen bilgilerin aktarılmasını sağlayan buton
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.liste; i++)
            {
                listBox1.Items.Add(Form1.elemanlar[i]);
            }

        }

        // İstenilen bilgiye daha kolay erişilebilmesini sağlayan ara butonu
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }

        }

        // Listbox'a düşen verilerin alfabetik olarak sıralanmasını ssaağlayan buton
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        // Yalnızca seçili olan öğeyi listeden çıkarmayı sağlar
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // Bütün öğeleri listeden çıkarmayı sağlar
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // Yeni kayıt yapılmak istendiğinde DVD Ekleme formuna geri dönülmesini sağlayan buton
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();

        }
    }
}
