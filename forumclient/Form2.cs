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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void аккаунтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аккаунтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database61DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database61DataSet.Тема' table. You can move, or remove it, as needed.
            this.темаTableAdapter.Fill(this.database61DataSet.Тема);
            // TODO: This line of code loads data into the 'database61DataSet.Сообщение' table. You can move, or remove it, as needed.
            this.сообщениеTableAdapter.Fill(this.database61DataSet.Сообщение);
            // TODO: This line of code loads data into the 'database61DataSet.Раздел' table. You can move, or remove it, as needed.
            this.разделTableAdapter.Fill(this.database61DataSet.Раздел);
            // TODO: This line of code loads data into the 'database61DataSet.Аккаунт' table. You can move, or remove it, as needed.
            this.аккаунтTableAdapter.Fill(this.database61DataSet.Аккаунт);

        }
    }
}
