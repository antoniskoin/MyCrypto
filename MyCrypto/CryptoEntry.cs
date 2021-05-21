using System.Windows.Forms;

namespace MyCrypto
{
    public partial class CryptoEntry : UserControl
    {

        public string CryptoName
        {
            get
            {
                return LabelCrypto.Text;
            }
            set
            {
                LabelCrypto.Text = value;
            }
        }

        public string CryptoPrice
        {
            set
            {
                LabelPrice.Text = value;
            }
        }

        public string CryptoAcronym
        {
            set
            {
                LabelAcronym.Text = value;
            }
        }

        public string CryptoMarketCap
        {
            set
            {
                LabelMarketCap.Text = value;
            }
        }

        public string CryptoImage
        {
            set
            {
                ImgCrypto.ImageLocation = value;
            }
        }

        public string CryptoGraph
        {
            set
            {
                ImgGraph.ImageLocation = value;
            }
        }

        public CryptoEntry()
        {
            InitializeComponent();
        }
    }
}
