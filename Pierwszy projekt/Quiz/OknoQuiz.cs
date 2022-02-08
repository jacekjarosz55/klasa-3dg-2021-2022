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
        private ListRepository Repository;
        private DbRepository RepositoryDB;

        public OknoQuiz()
        {
            InitializeComponent();

            Repository = new ListRepository();
            RepositoryDB = new DbRepository();
            ucListaPytan.Repository = Repository;
            ucListaPytan.RefreshData();
        }

    }
}
