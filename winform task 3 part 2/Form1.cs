using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_task_3_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hotdogtxtb.Enabled = false;
            guna2TextBox2.Enabled = false;
            hotdogprice.Enabled = false;
            hamburgertxtb.Enabled = false;
            hamburgerprice.Enabled = false;
            frenchfriestxtb.Enabled = false;
            frenchfriesprice.Enabled = false;
            cocacolaprice.Enabled = false;
            cocacolatxtb.Enabled = false;
            List<string> gasolineName = new List<string>
            {
               " A-72", "A-76", "Aİ-93"," Aİ​-95"
            };
            guna2TextBox1.Enabled = false;
            literstxtb.Enabled = false;
            azntxtb.Enabled = false;
            guna2ComboBox1.DataSource = gasolineName;
            List<Gasoline> gasolines = new List<Gasoline>
            {
                new Gasoline
                {
                   Name =" A-72",
                   Price =4
                },

                  new Gasoline
                {
                   Name =" A-76",
                   Price =4
                }
                  ,new Gasoline
                {
                   Name =" Ai-93",
                   Price =4
                },
                    new Gasoline
                {
                   Name =" Ai-95",
                   Price =4
                }
            };
            foreach (var item in gasolines)
            {
                if (guna2ComboBox1.Text == item.Name)
                {
                    guna2TextBox1.Text = item.Price.ToString();
                }

            }
        }
   
        private void litersrdbt_CheckedChanged_1(object sender, EventArgs e)
        {
            literstxtb.Enabled = true;

        } private void aznrdbtn_CheckedChanged(object sender, EventArgs e)
        {
                azntxtb.Enabled = true;

        } 
        private void label4_Click_1(object sender, EventArgs e)
        {
            try
            {
      
                    
             
                if (azntxtb.Text != null&&azntxtb .Enabled ==true)
                {

                    label4.Text = azntxtb.Text;
                } 
                if (literstxtb.Text != null)
                {
                    var price1 = int.Parse(literstxtb.Text);
                    int price2 = price1 * 4;

                    label4.Text = price2.ToString();
                }
            }
            catch (Exception)
            {


            }
         

        } 
   public     static int price=0;
   
        private void pricefoodlbl_Click_1(object sender, EventArgs e)
        {
            
if(hamburgerprice .Enabled)
            {
                price += int.Parse(hamburgertxtb.Text);
            }
if(hotdogprice .Enabled)
            {
                price += int.Parse(hotdogtxtb.Text);
            }
            if (cocacolaprice.Enabled)
            {
                price += int.Parse(cocacolatxtb.Text);
            }
            if (frenchfriesprice.Enabled)
            {
                price += int.Parse(frenchfriestxtb.Text);
            }
          
            pricefoodlbl.Text = price.ToString();

            
            
        }
       
 private void hotdogcbx_CheckedChanged(object sender, EventArgs e)
        {
            hotdogprice.Enabled = true;
           
        }

     


        

     
        private void Hamburgercbx_CheckedChanged(object sender, EventArgs e)
        {
                hamburgerprice.Enabled = true;

        }

        private void frenchfriescbx_CheckedChanged(object sender, EventArgs e)
        {
                frenchfriesprice.Enabled = true;

        }

        private void CocaColacbx_CheckedChanged(object sender, EventArgs e)
        {
                cocacolaprice.Enabled = true;

        }

      

     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(pricefoodlbl.Text) + int.Parse(label4.Text);
            guna2TextBox2.Text = price.ToString();
        }
    }
}
