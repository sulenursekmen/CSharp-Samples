using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskFormApp.Properties;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public int counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //string data=ReadFile();

            //string data=await ReadFileAsync();

            string data = String.Empty;
            Task<String> read = ReadFileAsync2();
            //Task<String> read = ReadFileAsync();

            richTextBox2.Text=await new HttpClient().GetStringAsync("https://www.google.com");

            data = await read; 


            richTextBox1.Text = data;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            textBoxCounter.Text = counter++.ToString();
        }


        private string ReadFile()
        {
            string data=string.Empty;

            using (StreamReader streamReader = new StreamReader("TaskFormApp.txt"))
            {
                Thread.Sleep(5000);
                data=streamReader.ReadToEnd();
            }
           return data;

        }

        // In synchronous methods, like void, you do not have to return anything, so you can use the Task alone

        //void Task
        //string Task<string>

        private async Task<string> ReadFileAsync()
        {
            string data = string.Empty;
            using (StreamReader streamReader = new StreamReader("TaskFormApp.txt"))
            {
                Task<string> myTask= streamReader.ReadToEndAsync();

                // Here, you can perform other tasks without being dependent on the data/ HTTP requests, POST requests, etc.

                // The I/O driver reads the file in a single thread without any extra threads, and the data comes in.

                await Task.Delay(5000);
                data=await myTask;

                return data;


            }
        }

        //without async-await

        private Task<string> ReadFileAsync2()
        {
            StreamReader streamReader = new StreamReader("TaskFormApp.txt");
            //no extra transactions
            return streamReader.ReadToEndAsync();
               
           
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

//The using statement is used in C# and other .NET languages to ensure that resources, such as files, database connections, network connections, etc., are automatically released when they are no longer needed. This is essential for preventing memory leaks and ensuring that resources are used efficiently.

//This feature is particularly useful for classes that implement the IDisposable interface, which indicates that the class has resources that need to be cleaned up. When a using block is used with an IDisposable object, the Dispose() method of that object is called automatically when the block is exited, ensuring that the resources are properly released. 