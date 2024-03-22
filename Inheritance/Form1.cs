using static System.Windows.Forms.LinkLabel;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        List<Drinks> drinksList = new List<Drinks>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate());
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate());
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int juiceCount = 0;
            int soadCount = 0;
            int alcoholCount = 0;

            // пройдемся по всему списку
            foreach (var drink in this.drinksList)
            {
                if (drink is Juice)
                {
                    juiceCount += 1;
                }
                else if (drink is Soda)
                {
                    soadCount += 1;
                }
                else if (drink is Alcohol)
                {
                    alcoholCount += 1;
                }
            }

            txtInfo.Text = "Сок\tГзрвк\tАлко";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juiceCount, soadCount, alcoholCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var drink = this.drinksList[0];
            this.drinksList.RemoveAt(0);

            txtOut.Text = drink.GetInfo();

            ShowInfo();
        }
    }
}
