using System;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            Text = "Hello World GUI";
            Button button = new Button() { Text = "Click Me!", Dock = DockStyle.Fill };
            button.Click += (sender, e) => MessageBox.Show("Hello, World!");
            Controls.Add(button);
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new HelloWorldForm());
        }
    }
}