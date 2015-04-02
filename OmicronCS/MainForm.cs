using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

using OmicronCS_Constants;
using OmicronCS_Enums;
using OmicronCS_Structures;

using OmicronCS_LoginMgmt;
 
namespace OmicronCS
{
    public partial class MainForm : MetroForm
    {

        public MainForm()
        {
            InitializeComponent();
            SetDefaultUiView();
        }

        private void SetDefaultUiView()
        {
            ui_ComboBoxViewData.SelectedIndex = (int) EComboBoxSelectedView.RecentlyAdded;
        }
    }
}