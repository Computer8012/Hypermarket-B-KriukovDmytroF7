using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HypermarketCourseWork_A_
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        private List<Buyer> buyers = new List<Buyer>();

        private int buyerCounter = 1;

        private ComboBox cmbProductType;
        private TextBox txtFirm;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtMaxDiscount;

        private CheckBox chkContract;
        private TextBox txtSimCards;
        private TextBox txtOS;
        private TextBox txtPrograms;

        private TextBox txtDiagonal;
        private TextBox txtWeight;
        private TextBox txtCores;
        private TextBox txtMemory;

        private ComboBox cmbBuyerType;
        private TextBox txtBuyerName;
        private TextBox txtMoney;
        private TextBox txtTotalBought;

        private ListBox listProducts;
        private ListBox listBuyers;

        public Form1()
        {
            InitializeComponent();
            CreateForm();
        }

        // Створення елементів форми
        private void CreateForm()
        {
            Controls.Clear();

            Text = "Гіпермаркет";
            Width = 1050;
            Height = 720;
            StartPosition = FormStartPosition.CenterScreen;

            Label lblProductTitle = new Label();
            lblProductTitle.Text = "Додавання товару";
            lblProductTitle.Left = 20;
            lblProductTitle.Top = 20;
            lblProductTitle.Width = 220;
            Controls.Add(lblProductTitle);

            cmbProductType = new ComboBox();
            cmbProductType.Left = 20;
            cmbProductType.Top = 50;
            cmbProductType.Width = 220;
            cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductType.Items.Add("Мобільний телефон");
            cmbProductType.Items.Add("Смартфон");
            cmbProductType.Items.Add("Ноутбук");
            cmbProductType.SelectedIndex = 0;
            cmbProductType.SelectedIndexChanged += CmbProductType_SelectedIndexChanged;
            Controls.Add(cmbProductType);

            txtFirm = AddTextBox("Фірма", 20, 90);
            txtName = AddTextBox("Назва", 20, 130);
            txtPrice = AddTextBox("Ціна", 20, 170);
            txtMaxDiscount = AddTextBox("Макс. знижка %", 20, 210);

            chkContract = new CheckBox();
            chkContract.Text = "З контрактом";
            chkContract.Left = 20;
            chkContract.Top = 250;
            chkContract.Width = 220;
            Controls.Add(chkContract);

            txtSimCards = AddTextBox("Кількість SIM", 20, 290);
            txtOS = AddTextBox("ОС", 20, 330);
            txtPrograms = AddTextBox("Програми через кому", 20, 370);

            txtDiagonal = AddTextBox("Діагональ", 20, 410);
            txtWeight = AddTextBox("Вага", 20, 450);
            txtCores = AddTextBox("Кількість ядер", 20, 490);
            txtMemory = AddTextBox("Пам'ять ГБ", 20, 530);

            Button btnAddProduct = new Button();
            btnAddProduct.Text = "Додати товар";
            btnAddProduct.Left = 20;
            btnAddProduct.Top = 580;
            btnAddProduct.Width = 220;
            btnAddProduct.Click += BtnAddProduct_Click;
            Controls.Add(btnAddProduct);

            Label lblBuyerTitle = new Label();
            lblBuyerTitle.Text = "Додавання покупця";
            lblBuyerTitle.Left = 280;
            lblBuyerTitle.Top = 20;
            lblBuyerTitle.Width = 220;
            Controls.Add(lblBuyerTitle);

            cmbBuyerType = new ComboBox();
            cmbBuyerType.Left = 280;
            cmbBuyerType.Top = 50;
            cmbBuyerType.Width = 220;
            cmbBuyerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuyerType.Items.Add("Звичайний покупець");
            cmbBuyerType.Items.Add("Постійний покупець");
            cmbBuyerType.SelectedIndex = 0;
            cmbBuyerType.SelectedIndexChanged += CmbBuyerType_SelectedIndexChanged;
            Controls.Add(cmbBuyerType);

            txtBuyerName = AddTextBox("ПІБ", 280, 90);
            txtMoney = AddTextBox("Гроші", 280, 130);
            txtTotalBought = AddTextBox("Сума покупок", 280, 170);

            Button btnAddBuyer = new Button();
            btnAddBuyer.Text = "Додати покупця";
            btnAddBuyer.Left = 280;
            btnAddBuyer.Top = 220;
            btnAddBuyer.Width = 220;
            btnAddBuyer.Click += BtnAddBuyer_Click;
            Controls.Add(btnAddBuyer);

            Label lblProducts = new Label();
            lblProducts.Text = "Список товарів";
            lblProducts.Left = 540;
            lblProducts.Top = 20;
            lblProducts.Width = 220;
            Controls.Add(lblProducts);

            listProducts = new ListBox();
            listProducts.Left = 540;
            listProducts.Top = 50;
            listProducts.Width = 460;
            listProducts.Height = 230;
            Controls.Add(listProducts);

            Label lblBuyers = new Label();
            lblBuyers.Text = "Список покупців";
            lblBuyers.Left = 540;
            lblBuyers.Top = 300;
            lblBuyers.Width = 220;
            Controls.Add(lblBuyers);

            listBuyers = new ListBox();
            listBuyers.Left = 540;
            listBuyers.Top = 330;
            listBuyers.Width = 460;
            listBuyers.Height = 230;
            Controls.Add(listBuyers);

            Button btnBuy = new Button();
            btnBuy.Text = "Купити вибраний товар";
            btnBuy.Left = 540;
            btnBuy.Top = 590;
            btnBuy.Width = 460;
            btnBuy.Height = 40;
            btnBuy.Click += BtnBuy_Click;
            Controls.Add(btnBuy);

            CmbProductType_SelectedIndexChanged(null, EventArgs.Empty);
            CmbBuyerType_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // Створення текстового поля
        private TextBox AddTextBox(string placeholder, int left, int top)
        {
            TextBox textBox = new TextBox();
            textBox.Left = left;
            textBox.Top = top;
            textBox.Width = 220;
            textBox.PlaceholderText = placeholder;
            Controls.Add(textBox);

            return textBox;
        }

        // Показ потрібних полів залежно від типу товару
        private void CmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbProductType.Text;

            chkContract.Visible = type == "Мобільний телефон" || type == "Смартфон";
            txtSimCards.Visible = type == "Мобільний телефон" || type == "Смартфон";

            txtOS.Visible = type == "Смартфон";
            txtPrograms.Visible = type == "Смартфон";

            txtDiagonal.Visible = type == "Ноутбук";
            txtWeight.Visible = type == "Ноутбук";
            txtCores.Visible = type == "Ноутбук";
            txtMemory.Visible = type == "Ноутбук";
        }

        // Показ полів для постійного покупця
        private void CmbBuyerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isRegular = cmbBuyerType.Text == "Постійний покупець";

            txtBuyerName.Visible = isRegular;
            txtTotalBought.Visible = isRegular;
        }

        // Додавання товару
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product;

                if (cmbProductType.Text == "Мобільний телефон")
                {
                    product = new MobilePhone(
                        txtFirm.Text,
                        txtName.Text,
                        decimal.Parse(txtPrice.Text),
                        double.Parse(txtMaxDiscount.Text),
                        chkContract.Checked,
                        int.Parse(txtSimCards.Text)
                    );
                }
                else if (cmbProductType.Text == "Смартфон")
                {
                    List<string> programs = new List<string>();

                    string[] parts = txtPrograms.Text.Split(',');

                    foreach (string part in parts)
                    {
                        if (!string.IsNullOrWhiteSpace(part))
                            programs.Add(part.Trim());
                    }

                    product = new Smartphone(
                        txtFirm.Text,
                        txtName.Text,
                        decimal.Parse(txtPrice.Text),
                        double.Parse(txtMaxDiscount.Text),
                        chkContract.Checked,
                        int.Parse(txtSimCards.Text),
                        txtOS.Text,
                        programs
                    );
                }
                else
                {
                    product = new Laptop(
                        txtFirm.Text,
                        txtName.Text,
                        decimal.Parse(txtPrice.Text),
                        double.Parse(txtMaxDiscount.Text),
                        double.Parse(txtDiagonal.Text),
                        double.Parse(txtWeight.Text),
                        int.Parse(txtCores.Text),
                        int.Parse(txtMemory.Text)
                    );
                }

                products.Add(product);
                listProducts.Items.Add(product);

                MessageBox.Show("Товар додано.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте числові поля.", "Помилка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        // Додавання покупця
        private void BtnAddBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                Buyer buyer;

                if (cmbBuyerType.Text == "Звичайний покупець")
                {
                    buyer = new Buyer(decimal.Parse(txtMoney.Text));
                    buyer.Number = buyerCounter;
                    buyerCounter++;
                }
                else
                {
                    buyer = new RegularBuyer(
                        txtBuyerName.Text,
                        decimal.Parse(txtMoney.Text),
                        decimal.Parse(txtTotalBought.Text)
                    );
                }

                buyers.Add(buyer);
                listBuyers.Items.Add(buyer);

                MessageBox.Show("Покупця додано.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте числові поля.", "Помилка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        // Купівля вибраного товару вибраним покупцем
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (listProducts.SelectedIndex == -1)
                    throw new Exception("Оберіть товар.");

                if (listBuyers.SelectedIndex == -1)
                    throw new Exception("Оберіть покупця.");

                Product product = products[listProducts.SelectedIndex];
                Buyer buyer = buyers[listBuyers.SelectedIndex];

                decimal paid = buyer.BuyProduct(product);

                int buyerIndex = listBuyers.SelectedIndex;
                listBuyers.Items[buyerIndex] = buyer;

                MessageBox.Show(
                    $"Покупка успішна.\nСплачено: {paid} грн\nЗалишок грошей: {buyer.Money} грн",
                    "Успіх"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }
    }
}