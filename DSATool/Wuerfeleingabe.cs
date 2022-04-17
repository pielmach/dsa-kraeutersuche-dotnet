namespace DSATool
{
    public partial class Wuerfeleingabe : Form
    {
        private int m_wuerfelwurf1 = 10;
        private int m_wuerfelwurf2 = 10;
        private int m_wuerfelwurf3 = 10;

        public Wuerfeleingabe()
        {
            InitializeComponent();
        }

        public int Wuerfelwurf1
        {
            get { return this.m_wuerfelwurf1; }
        }

        public int Wuerfelwurf2
        {
            get { return this.m_wuerfelwurf2; }
        }

        public int Wuerfelwurf3
        {
            get { return this.m_wuerfelwurf3; }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.m_wuerfelwurf1 = (int)this.numericUpDown1.Value;
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.m_wuerfelwurf2 = (int)this.numericUpDown2.Value;
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.m_wuerfelwurf3 = (int)this.numericUpDown3.Value;
        }
    }
}