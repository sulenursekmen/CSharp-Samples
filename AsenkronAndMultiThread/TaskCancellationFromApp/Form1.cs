using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskCancellationFromApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {   
            Task<HttpResponseMessage> myTask;
            try
            {

                myTask = new HttpClient().GetAsync("https://localhost:7248/api/home", cts.Token);

                await myTask;

                var content = await myTask.Result.Content.ReadAsStringAsync();

                richTextBox1.Text = content;
            }
            catch (TaskCanceledException ex)
            {
                //TaskCanceledException
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
