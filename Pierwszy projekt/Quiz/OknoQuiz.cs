using Baza_danych.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class OknoQuiz : Form
    {
        private IRepository Repository;
        

        public OknoQuiz()
        {
            InitializeComponent();

            //Repository = new ListRepository();
            Repository = new DbRepository();
            ucListaPytan.Repository = Repository;
            ucListaPytan.RefreshData();
        }

    }
}
