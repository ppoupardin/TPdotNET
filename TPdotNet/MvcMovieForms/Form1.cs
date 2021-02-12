using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using MvcMovie.Models;
using System.ComponentModel;

namespace MvcMovieForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetRESTData("https://localhost:44333/api/APIMovies");
        }

        private void GetRESTData(string uri)
        {
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(uri);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                if ((webResponse.StatusCode == HttpStatusCode.OK) && (webResponse.ContentLength > 0))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<MovieDTO>>(s);
                    var bindingList = new BindingList<MovieDTO>(items);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
