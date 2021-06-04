using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace SMI.@default {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e) {
            object oMissing = System.Reflection.Missing.Value;

            DateTime dateTimeNow = DateTime.Now;
            string date_str = dateTimeNow.ToString("dd/MM/yyyy");

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
                                 
            object oTemplate = "D:/Users/stephensonsso/source/repos/SMI.default/ET-numero.docx";
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);
                        
            object oBookMark = "numero_smi";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = n_smi.Text;

            oBookMark = "data_atual";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = date_str;

            oBookMark = "data_criacao";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = data_criacao.Text;

            oBookMark = "titulo";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = tituloSmi.Text;

            oBookMark = "detalhamento";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = campoDetalhamento.Text;

            oBookMark = "premissa";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = campoPremissa.Text;

            oBookMark = "restricoes";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = campoRestricoes.Text;

            oBookMark = "usuarios_areas";
            oDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = campoKeyUsr.Text;


            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e) {

        }
                
        private void label2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }
    }
}
