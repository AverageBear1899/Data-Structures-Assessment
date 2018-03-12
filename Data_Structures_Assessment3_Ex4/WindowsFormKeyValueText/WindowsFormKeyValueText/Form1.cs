using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKeyValueText {
    public partial class Form1 : Form {
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        //CHANGE THIS PATH OBV---------------------
        private string path = "C:\\Users\\Simon\\Desktop\\WindowsFormKeyValueText\\files\\myfile.txt";
        //-----------------------------------------

        public Form1() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                dict.Add(this.txtKey.Text, this.txtValue.Text);
                updateBox();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                using (StreamWriter file = new StreamWriter(path))
                    foreach (var entry in dict)
                        file.WriteLine("{0} : {1}", entry.Key, entry.Value);
                MessageBox.Show("File Saved");
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e) {
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    while (!sr.EndOfStream) {
                        string splitMe = sr.ReadLine();
                        string[] dataSplits = splitMe.Split(':');

                        dict.Add(dataSplits[0].Trim(), dataSplits[1].Trim());
                    }
                }
                updateBox();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            }


        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                dict.Remove(this.txtKey.Text);
                updateBox();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        public void updateBox() {
            string displayText = String.Empty;
            foreach (var pair in dict) {
                displayText = displayText + pair.Key + " : " + pair.Value + System.Environment.NewLine;
            }
            txtDisplay.Text = displayText;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



