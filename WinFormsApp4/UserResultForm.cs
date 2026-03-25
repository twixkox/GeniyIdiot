using GeniyIdiotConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinForm
{
    public partial class UserResultForm : Form
    {
        public UserResultForm()
        {
            InitializeComponent();
        }

        private void UserResultForm_Load(object sender, EventArgs e)
        {
            var result = UserStorage.GetAll();
            if (result.Count == 0)
            {
                MessageBox.Show($"Статистика пуста, проведите тест");
            }
            else
            {
                foreach (var item in result)
                {
                    listBox.Items.Add($"Имя - {item.Name} | Кол-во верных ответов - {item.RightAnswersCount} | Диагноз - {item.Diagnose}");
                }
            }
        }

       
    }
}
