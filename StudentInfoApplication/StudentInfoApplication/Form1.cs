using StudentNameSpace;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo s = new StudentInfo(textID.Text, textFname.Text, textLname.Text);

            LbID.Items.Add(s.StudentId);
            LbFN.Items.Add(s.FirstName);
            LbLN.Items.Add(s.LastName);

            textID.Clear();
            textLname.Clear();
            textFname.Clear();

            
        }
    }
}
