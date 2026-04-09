namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private List<Control> navList;
        public Form1()
        {
            InitializeComponent();

            rdoHamBurger.AutoCheck = false;
            rdoBulgogiBurger.AutoCheck = false;
            rdoChickenBurger.AutoCheck = false;

            navList = new List<Control> {
                rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger};

            chkPotato.CheckedChanged += Option_CheckedChanged;
            chkCola.CheckedChanged += Option_CheckedChanged;
            chkCheese.CheckedChanged += Option_CheckedChanged;
            chkSauce.CheckedChanged += Option_CheckedChanged;
        }

        int totalCost = 0;

        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.CornflowerBlue;
            lblTotalCost.Text = "총 금액 : 0원";
            totalCost = 0;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "주문을 입력하세요.";
                return;
            }
;
            lblTotalCost.ForeColor = Color.CornflowerBlue;

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Control activeControl = this.ActiveControl;

            if (keyData == Keys.Up || keyData == Keys.Down)
            {
                if (navList.Contains(activeControl))
                {
                    int currentIndex = navList.IndexOf(activeControl);
                    int nextIndex = currentIndex;

                    if (keyData == Keys.Down)
                    {
                        nextIndex = (currentIndex + 1) % navList.Count;
                    }
                    else if (keyData == Keys.Up)
                    {
                        nextIndex = (currentIndex - 1 + navList.Count) % navList.Count;
                    }

                    navList[nextIndex].Focus();
                    return true;
                }
            }

            if (keyData == Keys.Space && activeControl is RadioButton rdo)
            {
                rdoHamBurger.Checked = false;
                rdoBulgogiBurger.Checked = false;
                rdoChickenBurger.Checked = false;

                rdo.Checked = true;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateOrderSummary()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked) AddOrder("햄버거", 5000);
            else if (rdoBulgogiBurger.Checked) AddOrder("불고기버거", 4000);
            else if (rdoChickenBurger.Checked) AddOrder("치킨버거", 3000);

            if (chkPotato.Checked) AddOrder("감자튀김", 3500);
            if (chkCola.Checked) AddOrder("콜라", 2500);
            if (chkCheese.Checked) AddOrder("치즈 추가", 1500);
            if (chkSauce.Checked) AddOrder("소스 추가", 500);

            if (totalCost > 0)
            {
                lblTotalCost.ForeColor = Color.CornflowerBlue;
                lblTotalCost.Text = $"총 금액: {totalCost:N0}원";
            }
            else
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "주문을 입력하세요.";
            }
        }

        private void AddOrder(string name, int price)
        {
            totalCost += price;
            lstOrder.Items.Add($"{name} {price:N0}원");
        }

        private void RdoBurger_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            RadioButton clickedRdo = sender as RadioButton;
            if (clickedRdo != null)
            {
                clickedRdo.Checked = true;
            }

            UpdateOrderSummary();
        }
    }
}
