using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RandomPasswordGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void genPassButton_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            string userInput = textBoxUserInput.Text, randomGenPass = ""; //converting the text entered by the user into string
            Random random = new Random(); //creating random object
            char[] ch = userInput.ToCharArray(); //converting string userInput to a character array 
            for(int i=0;i<userInput.Length;i++) {
                randomGenPass = randomGenPass + ch[random.Next(userInput.Length)].ToString(); // this will point out the index position
            }
            textBoxPassword.Text = randomGenPass;
        }
    }
}