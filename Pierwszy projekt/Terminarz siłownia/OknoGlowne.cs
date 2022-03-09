using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Terminarz_siłownia.Baza_danych;
using Terminarz_siłownia.Baza_danych.Context;
using Terminarz_siłownia.Baza_danych.Model;

namespace Terminarz_siłownia
{
    public partial class OknoGlowne : Form
    {

        DataBaseContext dataBaseContext;


        public OknoGlowne()
        {
            InitializeComponent();

            dataBaseContext = new DataBaseContext();

            List<Osoba> listaOsob = dataBaseContext.Osoby.ToList();
            comboBoxOsoby.DataSource = listaOsob;
            comboBoxOsoby.DisplayMember = "Imie_Nazwisko";

            List<Kategoria> listaKategorii = dataBaseContext.Kategorie.ToList();
            comboBoxKategoria.DataSource = listaKategorii;
            comboBoxKategoria.DisplayMember = "NazwaKategorii";



            /* select 
              c.IloscPowtorzen,
              c.DataCzwiczenia, 
              CZY_ZREALIZOWANE  
              from Cwiczenia (C)*/



        }

        private void buttonDodajCwiczenie_Click(object sender, EventArgs e)
        {
            Cwiczenie cw = new Cwiczenie()
            {
                IloscPowtorzen = (int)numericUpDownIloscPowtorzen.Value,
                DataCwiczenia = dateTimePickerDataCwiczenia.Value,
                KategoriaId = ((comboBoxKategoria.SelectedItem as Kategoria)?.Id).Value,
                OsobaId = ((comboBoxOsoby.SelectedItem as Osoba)?.Id).Value
            };
            dataBaseContext.Cwiczenia.Add(cw);
            dataBaseContext.SaveChanges();
        }
    }
}
