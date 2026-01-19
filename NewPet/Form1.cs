using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace NewPet
{
    public partial class Form1 : Form
    {
        private string petImage;
        public Form1()
        {
            InitializeComponent();
        }

        public IAnimal Animal { get;  set; }

        private void RadioButtononDogCheckedChanged(object sender, EventArgs e)
        {
            this.labalFavToy.Visible = false;
            this.textBoxFavToy.Visible = false;
            this.labelFavPark.Visible = true;
        }
        private void RadioButtononCatCheckedChanged(object sender, EventArgs e)
        {
            this.labalFavToy.Visible = true;
            this.textBoxFavToy.Visible = true;
        }
        
    }
}