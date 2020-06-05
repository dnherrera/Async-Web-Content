using AsyncWebContent.Classes;
using AsyncWebContent.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncWebContent
{
    public partial class Form1 : Form
    {
        private readonly IHttpHandler _httpHandler;
        public Form1()
        {
            _httpHandler = (IHttpHandler)Program.ServiceProvider.GetService(typeof(IHttpHandler));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(url1.Text) && !string.IsNullOrEmpty(url2.Text))
            {
                HttpResponseArgs resOne = _httpHandler.GetContent((url1.Text).ToString());
                response1.Text = $"httpBody = {resOne.httpBody} \n\n responseCode = {resOne.responseCode}";

                HttpResponseArgs resTwo = _httpHandler.GetContent((url2.Text).ToString());
                response2.Text = $"httpBody = {resTwo.httpBody} \n\n responseCode = {resTwo.responseCode}";
            }
            else
            {
                MessageBox.Show("Url Textboxes are required");
            }

           
        }
    }
}
