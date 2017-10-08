using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Program ma za zadanie posortowac wyrazy wpisane w liste alfabetycznie rosnąco lub malejąco
namespace sort
{
    

    public partial class Form1 : Form
    {
        
        List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != "")
            {

                
            }
            else
            {
                MessageBox.Show("Brakuje wyrazu");

            }
           
        }
        //button1_Click wpisuje wartosc z textboxa do listboxa
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(this.richTextBox1.Text);
            

        }
        // zapisuje wartosci z listBoxa1 do listy
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (string lines in listBox1.Items)
            {
                lista.Add(lines);
            }
    }
        // czyszczenie listboxa1 & 2
        private void button2_Click(object sender, EventArgs e)
        {
            lista.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            
        }
        private void add_to_listBox2()
        {
            //int c = listBox1.Items.Count - 1;
            //for (int i = 0; i <= c; i++)
            //{
            //    listBox2.Items.Add(listBox1.Items[i]);
                
            //}
            foreach (string word in lista)
            {
                listBox2.Items.Add(word);
            }
        }
        
        private void sorting_a_to_z()
        {
            try
            {
                lista.Sort();
                add_to_listBox2();
                
               

            }
            catch (Exception ex1)
            {
                MessageBox.Show("Błąd: " + ex1.Message);
            }
          
        }
        private void sorting_z_to_a()
        {
            try
            {
                lista.Sort();
                lista.Reverse();
                add_to_listBox2();
              
            }
            catch(Exception ex2)
            {
                MessageBox.Show("Błąd: "+ex2.Message);
            }
        }

        

        private void checkBox1_Click(object sender, EventArgs e)
        {
                sorting_a_to_z();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
          
              sorting_z_to_a();
            
        }
        // usuwa zaznaczony element listy
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lista.RemoveAt(lista.Count - 1);
                listBox1.Items.Remove(listBox1.SelectedItem);

            }
            catch (Exception e3)
            {
                MessageBox.Show(" "  + e3.Message);
            }
            
        }

       
       void sort_growing()
        {
            try
            {
                lista.Sort((x, y) => x.Length.CompareTo(y.Length));
                foreach (string word in lista)
                    listBox2.Items.Add(word+"( "+word.Length+")");
            }
            catch (Exception e)
            { 
                MessageBox.Show( " " + e);
            }
           
        }
        void sort_downing()
        {
            try
            {
                lista.Sort((x, y) => x.Length.CompareTo(y.Length));
                lista.Reverse();
                foreach (string word in lista)
                    listBox2.Items.Add(word + "( " + word.Length + ")");
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
        }
        //sortowanie dlugosc znakow growing
        private void checkBox3_Click(object sender, EventArgs e)
        {
            
        }
        //sortowanie dlugosc znakow downing
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sorting_a_to_z();
            }
            else if (checkBox2.Checked)
            {
                sorting_z_to_a();
            }
            else if(checkBox3.Checked)
            {
                sort_growing();
            }
            else if(checkBox4.Checked)
            {
                sort_downing();
            }
            else
            {
                MessageBox.Show("Wybierz opcje sortowania");
            }
        }

       
    }
    }