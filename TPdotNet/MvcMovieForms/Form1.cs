using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using MvcMovie.Models;
using System.ComponentModel;
using System.Text;

namespace MvcMovieForms
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetRESTData("https://localhost:44333/api/APIMovies");
            formAdd1.clicButton += FormAdd1_clicButton;
            
        }

        private void FormAdd1_clicButton(string button)
        {
            if(button == "Annuler")
            {
                dataGridView1.Visible = true;
                button1.Visible = true;
                formAdd1.Visible = false;
            }
            if(button == "Ajouter")
            {
                HttpWebRequest webRequest;
                string Title = "Test";
                DateTime ReleaseDate = DateTime.Now;
                decimal Price = 10;
                string Genre = "test";
                string Rating = "R";

                string requestParams = "info={ 'Title': " + Title+ ", 'Price': "+ Price + ", 'Genre': "+ Genre + ", 'Rating': "+ Rating + "}"; //format information you need to pass into that string ('info={ "EmployeeID": [ "1234567", "7654321" ], "Salary": true, "BonusPercentage": 10}');

                webRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44333/api/APIMovies");

                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";

                byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                webRequest.ContentLength = byteArray.Length;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(byteArray, 0, byteArray.Length);
                }

                // Get the response.
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                        string Json = rdr.ReadToEnd(); // response from server

                    }
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            button1.Visible = false;
            formAdd1.Visible = true;
        }
    }
}
