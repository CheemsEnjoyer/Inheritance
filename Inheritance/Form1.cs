using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        List<Drinks> drinksList = new List<Drinks>();
        private Stack<string> drinkQueue = new Stack<string>();
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

            // Очистка стека перед заполнением новыми элементами
            drinkQueue.Clear();

            for (var i = 0; i < 10; ++i)
            {
                int nextDrink = rnd.Next() % 4;
                switch (nextDrink)
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate());
                        drinkQueue.Push("Сок");
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate());
                        drinkQueue.Push("Газировка");
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate());
                        drinkQueue.Push("Алкоголь");
                        break;
                    case 3:
                        this.drinksList.Add(Tea.Generate());
                        drinkQueue.Push("Чай");
                        break;
                }
            }
            ShowInfo();
            DisplayQueue();
        }


        private void DisplayQueue()
        {
            lstDrinkQueue.Items.Clear(); // Очистка списка перед добавлением новых элементов
            foreach (var drink in drinkQueue)
            {
                lstDrinkQueue.Items.Insert(0, drink);
            }
        }


        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int juiceCount = 0;
            int soadCount = 0;
            int alcoholCount = 0;
            int teaCount = 0;
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
                else if (drink is Tea)
                {
                    teaCount += 1;
                }
            }

            txtInfo.Text = "Сок\tГзрвк\tАлко\tЧай";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}\t{3}", juiceCount, soadCount, alcoholCount, teaCount);
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

            pctrBxDrnk.Image = drink.Image;
            txtOut.Text = drink.GetInfo();
            lstDrinkQueue.Items.RemoveAt(0);
            ShowInfo();
        }
    }
}
