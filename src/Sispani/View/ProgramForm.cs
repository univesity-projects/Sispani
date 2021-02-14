using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sispani.View.AuxProgram;
using Sispani.View.UC;

namespace Sispani.View
{
    public partial class ProgramForm : Form
    {
        private const int UC_HOME = 0;
        private const int UC_PRODUCTS = 1;
        private const int UC_CUSTOMER = 2;
        private const int UC_BILL = 3;
        private const int UC_REPORT = 4;
        private const int UC_HELP = 5;
        private List<UserControl> _userControls;
        private UserControl _currentUserControl;

        public ProgramForm()
        {
            InitializeComponent();
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {
            var login = new LoginForm();
            var response = login.ShowDialog();

			if (response == DialogResult.OK)
			{
                InitialConfigs();

            }
            else if (response == DialogResult.Abort)
            {
                Application.Exit();
            }
        }

        public void InitialConfigs()
        {
            _userControls = new List<UserControl>
            {
                new MainUC(),
                new ProductUC(),
                new CustomerUC(),
                new BillUC(),
                new ReportUC(),
                new HelpUC()
            };
            foreach (var uc in _userControls)
            {
                uc.Dock = DockStyle.Fill;
                uc.Hide();
                Wrapper.Controls.Add(uc);
            }
            SetCurrentUserControl(UC_HOME);
            ((MainUC)_currentUserControl).LoadGraphic();

            // Carregamento dos dados
            lblTradeName.Show();
            lblCompanyName.Show();
            lblCNPJ.Show();
            lblTradeName.Text = "Nome Fantasia";
            lblCompanyName.Text = "Nome Jurídico";
            lblCNPJ.Text = "CNPJ " + "000.000.000/0000-00";
        }

        private void SetCurrentUserControl(int index)
		{
            if (_currentUserControl == _userControls[index]) return;
            foreach (var uc in _userControls)
            {
                uc.Hide();
            }
            _currentUserControl = _userControls[index];
            _currentUserControl.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_HOME);
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            new SaleForm().ShowDialog();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_PRODUCTS);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_CUSTOMER);
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_BILL);
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_REPORT);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            SetCurrentUserControl(UC_HELP);
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }

        private void PictureBoxLogoNome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }
	}
}
