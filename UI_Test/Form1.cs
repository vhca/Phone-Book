using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using CommonDTO.Models_DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UI_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRESTData();
        }

        private void GetRESTData()
        {
            try
            {
                string apiUrl = "http://localhost:4001/api/v1.0/Contact";
                var webRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                if ((webResponse.StatusCode == HttpStatusCode.OK) && (webResponse.ContentLength > 0))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    JToken jObject = JObject.Parse(s);
                    var contactDtos = JsonConvert.DeserializeObject<List<ContactDTO>>(jObject["value"].ToString());
                    dataGridView1.DataSource = contactDtos;
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
    }
}
