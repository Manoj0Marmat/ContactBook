using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBookLibrary;

namespace ContactBook
{
    public partial class MainForm : Form
    {
        private List<Contact> contacts = new List<Contact>();

        BindingSource bindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
            SetupData();


            bindingSource.DataSource = contacts;
            allContactBox.DataSource = bindingSource;

            Contact selectedCon = (Contact)allContactBox.SelectedItem;

            MessageBox.Show(selectedCon.Name);

        }

        public void SetupData()
        {
            contacts.Add( new Contact("manoj marmat", 7083955439L, "manoj@gmail.com"));
            contacts.Add( new Contact("tushar marmat", 9765674253L, "tushar@gmail.com"));
            contacts.Add( new Contact("rutik marmat", 9156783717L, "rutik@gmail.com"));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void updateContactButton_Click(object sender, EventArgs e)
        {
        }
    }
}
