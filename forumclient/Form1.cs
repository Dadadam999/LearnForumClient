using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forumclient
{
  
    public partial class Form1 : Form
    {
        String user="";
        public Form1()
        {
            InitializeComponent();
            hello.BringToFront();
            hello.Dock = DockStyle.Fill;
            sizewellcome();
            Autorization.Visible = false;
            Registration.Visible = false;
            changepassword.Visible = false;
            categoriesselect.Visible = false;
            CreateTheme.Visible = false;
        }


        bool isDragging = false;
        int currentX, currentY;
        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                currentX = e.X;
                currentY = e.Y;
                categoryin.BringToFront();
            }
        }
        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging)
            {
                categoryin.Top = categoryin.Top + (e.Y - currentY);
                categoryin.Left = categoryin.Left + (e.X - currentX);
            }
        }
        private void panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
 
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        void sizewellcome()
        {

            hellowelcome.Left = this.Width / 2 - hellowelcome.Width/2;
            hellowelcome.Top = this.Height / 2 - hellowelcome.Height/2 -100;

            helloaut.Left = hellowelcome.Left - 20;
            helloaut.Top = hellowelcome.Top + 50;

            helloreg.Left = hellowelcome.Left - 20;
            helloreg.Top = helloaut.Top + 50;


        }

        bool isDragging2 = false;
        int currentX2, currentY2;
        private void panel2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            isDragging2 = true;
            currentX2 = e.X;
            currentY2 = e.Y;
            themetwit.BringToFront();
        }
        private void panel2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging2)
            {
                themetwit.Top = themetwit.Top + (e.Y - currentY2);
                themetwit.Left = themetwit.Left + (e.X - currentX2);
            }
        }
        private void panel2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging2 = false;
            }
        }

        bool isDragging3 = false;
        int currentX3, currentY3;
        private void panel3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging3 = true;
                currentX3 = e.X;
                currentY3 = e.Y;
                themehead.BringToFront();
            }
        }
        private void panel3_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging3)
            {
                themehead.Top = themehead.Top + (e.Y - currentY3);
                themehead.Left = themehead.Left + (e.X - currentX3);
            }
        }
        private void panel3_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                isDragging3 = false;
            }
        }

        void sizeaut() { 
            autlin.Left = this.Width/2 - autlin.Width/2;
            autlin.Top = this.Height/2 - autlin.Height/2-100;

        }

        void sizereg() {
            regin.Left = this.Width / 2 - regin.Width / 2;
            regin.Top = this.Height / 2 - regin.Height / 2-100;
        }


        void sizechangepass() {
            changepasswordin.Left = this.Width / 2 - changepasswordin.Width / 2;
            changepasswordin.Top = this.Height / 2 - changepasswordin.Height / 2 - 100;
        }

        void categoryselectresize() {
      
            cat1.Top = catname.Height + 30;
            cat1.Width = this.Width;
            cat1.Left = 0;

            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
          if(hello.Visible == true) sizewellcome();
          if(Autorization.Visible == true) sizeaut();
          if(Registration.Visible == true) sizereg();
          if (categoriesselect.Visible == true) categoryselectresize();
        }

        private void helloaut_Click(object sender, EventArgs e)
        {
            Autorization.Visible = true;
            Autorization.BringToFront();
            Autorization.Dock = DockStyle.Fill;

            sizeaut();

            hello.Visible = false;

            Registration.Visible = false;
            categoriesselect.Visible = false;
            changepassword.Visible = false;
            CreateTheme.Visible = false;

        }

        private void helloreg_Click(object sender, EventArgs e)
        {
            Registration.Visible = true;
            Registration.BringToFront();
            Registration.Dock = DockStyle.Fill;
            sizereg();

            hello.Visible = false;

            Autorization.Visible = false;
            categoriesselect.Visible = false;
            changepassword.Visible = false;
            CreateTheme.Visible = false;
 

        }

        private void backlogin_Click(object sender, EventArgs e)
        {
            hello.Visible = true;
            hello.BringToFront();
            hello.Dock = DockStyle.Fill;
            sizewellcome();
            Autorization.Visible = false;
            Registration.Visible = false;
            changepassword.Visible = false;
            categoriesselect.Visible = false;
            CreateTheme.Visible = false;

        }

        private void backreg_Click(object sender, EventArgs e)
        {
            hello.Visible = true;
            hello.BringToFront();
            hello.Dock = DockStyle.Fill;
            sizewellcome();
            Autorization.Visible = false;
            Registration.Visible = false;
            changepassword.Visible = false;
            categoriesselect.Visible = false;
            CreateTheme.Visible = false;
        }

        private void autfogrotpas_Click(object sender, EventArgs e)
        {
            changepassword.Visible = true;
            changepassword.BringToFront();
            changepassword.Dock = DockStyle.Fill;
            sizechangepass();

            Autorization.Visible = false;

            Registration.Visible = false;
            categoriesselect.Visible = false;
            hello.Visible = false;
            CreateTheme.Visible = false;
        }

        private void backchangepass_Click(object sender, EventArgs e)
        {
            Autorization.Visible = true;
            Autorization.BringToFront();
            Autorization.Dock = DockStyle.Fill;

            sizeaut();

            hello.Visible = false;

            Registration.Visible = false;
            categoriesselect.Visible = false;
            changepassword.Visible = false;
            CreateTheme.Visible = false;
        }
        private void autaut_Click(object sender, EventArgs e)
        {
            String inputlogin = "012345678900", inputpass = "0123456789000", columnlogin, columnpass;
            Boolean succses = false;

            if ((autlogintextBox.Text.Length != 0) && (autpasstextBox.Text.Length != 0)) {
                inputlogin = autlogintextBox.Text;
                inputpass = autpasstextBox.Text;
            }
            else  MessageBox.Show("Error: Incurrect date", "Error");

            for (int i = 0; i < аккаунтDataGridView.RowCount; i++) {
                columnlogin = Convert.ToString(аккаунтDataGridView[0,i].Value);
                columnpass = Convert.ToString(аккаунтDataGridView[1,i].Value);
                if ((inputlogin == columnlogin)&&(inputpass == columnpass)) {
                    succses = true;
                    break;
                   }  
            }
            if (succses) {
                user = autlogintextBox.Text;
                if (user == "admin")
                {
                    Form2 f = new Form2();
                    f.Show();
                }
                categoriesselect.BringToFront();
                categoriesselect.Dock = DockStyle.Fill;
                categoriesselect.Visible = true;
                categoryselectresize();
                hello.Visible = false;
                Autorization.Visible = false;
                Registration.Visible = false;
                changepassword.Visible = false;
                CreateTheme.Visible = false;
                themehead.Visible = false;
                themetwit.Visible = false;
      
            
            } else MessageBox.Show("Error: Incurrect login|password", "Error");
        }

        private void regreg_Click(object sender, EventArgs e)
        {
            String error = "";
            Boolean succsesinput = true;
            if (reglogin.Text.Length == 0) {
                error += "\n Poly login is empty";
                succsesinput = false;
            }

            if (regpas.Text.Length == 0){
                error += "\n Poly password is empty";
                succsesinput = false;
            }

            if (regrepeatpas.Text.Length == 0) {
                error += "\n Poly repeat password is empty";
                succsesinput = false;
            }

            if (regsecword.Text.Length == 0) {
                succsesinput = false;
                error += "\n Poly secret word is empty";
            }

            if (regrepeatpas.Text.Length != regpas.Text.Length)
            {
                error += "\n Incorrect repeatpassword";
                succsesinput = false;
            }

            if (regpas.Text.Length < 5)
            {
                error += "\n Password is short";
                succsesinput = false;
            }

            if (regsecword.Text.Length == 0)
            {
                error += "\n Poly secred word is empty";
                succsesinput = false;
            }

            if (regname.Text.Length == 0)
            {
                error += "\n Poly name is empty";
                succsesinput = false;
            }

            if (regage.Text.Length == 0)
            {
                error += "\n  Poly age is empty";
                succsesinput = false;
            }

            if (regcity.Text.Length == 0)
            {
                error += "\n Poly city is empty";
                succsesinput = false;
            }

            if (regsecword.Text.Length < 4)
            {
                error += "\n Poly secret word is short";
                succsesinput = false;
            }

            for (int i = 0; i < аккаунтDataGridView.RowCount-1; i++)  
                if (reglogin.Text == Convert.ToString(аккаунтDataGridView[0,i].Value)) { 
                    succsesinput = false; error += "\n This login already exists"; 
                    break; 
                }

            if(succsesinput) {   
             Database61DataSetTableAdapters.АккаунтTableAdapter regionTableAdapter = new Database61DataSetTableAdapters.АккаунтTableAdapter();
             System.DateTime time = Convert.ToDateTime(regage.Text);
             regionTableAdapter.Insert(reglogin.Text, regpas.Text, regname.Text, time, regcity.Text, regsecword.Text);
             regionTableAdapter.GetData();
             this.Validate();
             this.аккаунтBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.database61DataSet);

             categoriesselect.BringToFront();
             categoriesselect.Dock = DockStyle.Fill;
             categoriesselect.Visible = true;
             categoryselectresize();
             hello.Visible = false;
             Autorization.Visible = false;
             Registration.Visible = false;
             changepassword.Visible = false;
             CreateTheme.Visible = false;
             themehead.Visible = false;
             themetwit.Visible = false;
             user = reglogin.Text;
             if (user == "admin")
             {
                 Form2 f = new Form2();
                 f.Show();
             }
            } else MessageBox.Show(error, "Error");
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database61DataSet.Тема' table. You can move, or remove it, as needed.
            this.темаTableAdapter.Fill(this.database61DataSet.Тема);
            // TODO: This line of code loads data into the 'database61DataSet.Сообщение' table. You can move, or remove it, as needed.
            this.сообщениеTableAdapter.Fill(this.database61DataSet.Сообщение);
            // TODO: This line of code loads data into the 'database61DataSet.Раздел' table. You can move, or remove it, as needed.
            this.разделTableAdapter.Fill(this.database61DataSet.Раздел);
            // TODO: This line of code loads data into the 'database61DataSet.Тема' table. You can move, or remove it, as needed.
            this.темаTableAdapter.Fill(this.database61DataSet.Тема);
            // TODO: This line of code loads data into the 'database61DataSet.Сообщение' table. You can move, or remove it, as needed.
            this.сообщениеTableAdapter.Fill(this.database61DataSet.Сообщение);
            // TODO: This line of code loads data into the 'database61DataSet.Раздел' table. You can move, or remove it, as needed.
            this.разделTableAdapter.Fill(this.database61DataSet.Раздел);
            // TODO: This line of code loads data into the 'database61DataSet.Аккаунт' table. You can move, or remove it, as needed.
            this.аккаунтTableAdapter.Fill(this.database61DataSet.Аккаунт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            themehead.Visible = true;
            themetwit.Visible = true;
        }

        private void cgangechange_Click(object sender, EventArgs e)
        {


            String  chlogin="          ", chpass="          ",  dbchlogin,  dbchpass ;
            Boolean succses = false;

            if ((textBox1.Text.Length != 0) && (changesecword.Text.Length != 0) && (changenewpass.Text.Length != 0) && (changenewpassword.Text.Length != 0) && (changenewpass.Text == changenewpassword.Text))
            {
                chlogin = textBox1.Text;
                chpass = changesecword.Text;
            }
            else  MessageBox.Show("Error: Incurrect date", "Error");
            int I = 0;
            for (int i = 0; i < аккаунтDataGridView.RowCount; i++) {
                dbchlogin = Convert.ToString(аккаунтDataGridView[0,i].Value);
                dbchpass = Convert.ToString(аккаунтDataGridView[5,i].Value);
                if ((chlogin == dbchlogin)&&(chpass == dbchpass)) {
                    succses = true;
                    I = i;
                    break;
                   }  
            }
            if (succses)
            {
                Database61DataSetTableAdapters.АккаунтTableAdapter regionTableAdapter = new Database61DataSetTableAdapters.АккаунтTableAdapter();
                System.DateTime time = Convert.ToDateTime(regage.Text);
                regionTableAdapter.Insert( Convert.ToString(аккаунтDataGridView[0, I].Value), changenewpassword.Text,  Convert.ToString(аккаунтDataGridView[2, I].Value), Convert.ToDateTime(аккаунтDataGridView[3, I].Value),  Convert.ToString(аккаунтDataGridView[4, I].Value),  Convert.ToString(аккаунтDataGridView[5, I].Value));
                regionTableAdapter.GetData();
                this.Validate();
                this.аккаунтBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database61DataSet);


                Autorization.Visible = true;
                Autorization.BringToFront();
                Autorization.Dock = DockStyle.Fill;

                sizeaut();

                hello.Visible = false;

                Registration.Visible = false;
                categoriesselect.Visible = false;
                changepassword.Visible = false;
                CreateTheme.Visible = false;

            }
            else MessageBox.Show("Error: Incurrect login|password", "Error");
            
        }
        void resizecreatetheme()
        {
            CreateTheme.Left = this.Width / 2 - CreateTheme.Width / 2;
            CreateTheme.Top = this.Height / 2 - CreateTheme.Height / 2 - 100;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CreateTheme.Visible = true;
            CreateTheme.BringToFront();
            resizecreatetheme();
            categoryin.Visible = false;
            themehead.Visible = false;
            themetwit.Visible = false;
            for (int i = 0; i < разделDataGridView.RowCount; i++)
            {
                comboBox1.Items.Add(Convert.ToString(разделDataGridView[0, i].Value));
            }
        }

        void createteittresize()
        {
            createtwitt.Left = this.Width / 2 - createtwitt.Width / 2;
            createtwitt.Top = this.Height / 2 - createtwitt.Height / 2 - 100;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            createtwitt.Visible = true;
            createtwitt.BringToFront();
            createteittresize();

            categoryin.Visible = false;
            themehead.Visible = false;
            themetwit.Visible = false;
        }

        private void createthemeinput_Click(object sender, EventArgs e)
        {
            categoryin.Visible = true;
            CreateTheme.Visible = false;
            Database61DataSetTableAdapters.ТемаTableAdapter theme = new Database61DataSetTableAdapters.ТемаTableAdapter();
            String s1 =createthemennew.Text,
                s2 = createthemetext.Text,
                s3 = comboBox1.Text;
            theme.Insert(s1, s2, user, s3);
            theme.GetData();
            this.Validate();
            this.темаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database61DataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoryin.Visible = true;
            themehead.Visible = true;
            themetwit.Visible = true;
            String lol = имяLabel1.Text;
            Database61DataSetTableAdapters.СообщениеTableAdapter regionTableAdapter = new Database61DataSetTableAdapters.СообщениеTableAdapter();
            regionTableAdapter.Insert(user, createtwitttext.Text, creattwitwhere.Text, System.DateTime.Today,lol);
            regionTableAdapter.GetData();
            this.Validate();
            this.темаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database61DataSet);

        }

        private void backcategories_Click(object sender, EventArgs e)
        {
            hello.BringToFront();
            hello.Visible = true;
            hello.Dock = DockStyle.Fill;
            sizewellcome();
            Autorization.Visible = false;
            Registration.Visible = false;
            changepassword.Visible = false;
            categoriesselect.Visible = false;
            CreateTheme.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            categoriesselect.BringToFront();
            categoriesselect.Dock = DockStyle.Fill;
            categoriesselect.Visible = true;
            categoryselectresize();
            hello.Visible = false;
            Autorization.Visible = false;
            Registration.Visible = false;
            changepassword.Visible = false;
            CreateTheme.Visible = false;
            this.Validate();
            this.темаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database61DataSet);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
        }









        }
    }
