using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza_danych.Dto;
using Baza_danych.Model;
using Baza_danych.Repository;
using Quiz.Okna_pomocnicze;

namespace Quiz.Zakladki
{
    public partial class UcListaPytan : UserControl
    {
        public IRepository Repository;

        private PytanieOdpowiedzQuiz aktualnePytanie;
        private List<PytanieOdpowiedzQuiz> listaPytanOdpowiedzi = new List<PytanieOdpowiedzQuiz>();

        public UcListaPytan()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            int aktualnaPozycja = comboBoxListaPytan.SelectedIndex;

            comboBoxListaPytan.SelectedIndexChanged -= comboBoxListaPytan_SelectedIndexChanged;
            comboBoxListaPytan.Items.Clear();

            List<int> listaPytanId = Repository.ReadPytaniaIdList();

            foreach (int id in listaPytanId)
            {
                comboBoxListaPytan.Items.Add(id);
            }

            comboBoxListaPytan.SelectedIndexChanged += comboBoxListaPytan_SelectedIndexChanged;
            if (aktualnaPozycja == comboBoxListaPytan.Items.Count)
                aktualnaPozycja--;
            if (comboBoxListaPytan.Items.Count > 0 && aktualnaPozycja < 0)
                aktualnaPozycja = 0;
            comboBoxListaPytan.SelectedIndex = aktualnaPozycja;
        }

        private void comboBoxListaPytan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucWyswietlPytanie.WyswietlPytanie = null;

            if (comboBoxListaPytan.SelectedItem != null)
            {
                int id;
                int.TryParse(comboBoxListaPytan.SelectedItem.ToString(), out id);

                aktualnePytanie = PobierzPytanieOdpowiedz(listaPytanOdpowiedzi, id, true);
                ucWyswietlPytanie.WyswietlPytanie = aktualnePytanie;
            }
        }

        private PytanieOdpowiedzQuiz PobierzPytanieOdpowiedz(List<PytanieOdpowiedzQuiz> lista, int id, bool czyZaznaczycPrawidlowe = false)
        {
            PytanieOdpowiedzQuiz szukanePytanieOdpowiedz = lista.FirstOrDefault(poq => poq.PytanieQuiz.ReadPytanieDto.Id == id);

            if (szukanePytanieOdpowiedz == null)
            {
                szukanePytanieOdpowiedz = new PytanieOdpowiedzQuiz();
                lista.Add(szukanePytanieOdpowiedz);

                szukanePytanieOdpowiedz.PytanieQuiz = new PytanieQuiz();
                szukanePytanieOdpowiedz.PytanieQuiz.ReadPytanieDto = Repository.ReadPytanie(id);
                szukanePytanieOdpowiedz.PytanieQuiz.TextBoxPytanie = new TextBox()
                {
                    Text = szukanePytanieOdpowiedz.PytanieQuiz.ReadPytanieDto.TrescPytania,
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    ReadOnly = true
                };

                List<OdpowiedzReadDto> odpowiedzReadDtos = Repository.ReadOdpowiedzi(id);

                /*
                szukanePytanieOdpowiedz.OdpowiedziLista = new List<OdpowiedzQuiz>();
                foreach (OdpowiedzReadDto odpowiedzReadDto in odpowiedzReadDtos)
                {
                    OdpowiedzQuiz odpowiedzQuiz = new OdpowiedzQuiz();
                    odpowiedzQuiz.OdpowiedzReadDto = odpowiedzReadDto;
                    odpowiedzQuiz.CheckBoxOdpowiedz = new CheckBox()
                                    {
                                        Text = odpowiedzReadDto.TrescOdpowiedzi,
                                        Checked = czyZaznaczycPrawidlowe && odpowiedzReadDto.CzyPrawidlowa,
                                        Enabled = false
                                    };
                    szukanePytanieOdpowiedz.OdpowiedziLista.Add(odpowiedzQuiz);
                }
                */
                szukanePytanieOdpowiedz.OdpowiedziLista = odpowiedzReadDtos.Select(odpowiedzReadDto => new OdpowiedzQuiz()
                {
                    OdpowiedzReadDto = odpowiedzReadDto,
                    CheckBoxOdpowiedz = new CheckBox()
                    {
                        Text = odpowiedzReadDto.TrescOdpowiedzi,
                        Checked = czyZaznaczycPrawidlowe && odpowiedzReadDto.CzyPrawidlowa,
                        Enabled = false
                    }
                }).ToList();

            }
            return szukanePytanieOdpowiedz;
        }

        private void buttonUsunPytanie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy usunąć aktualne pytanie?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int idPytania = aktualnePytanie.PytanieQuiz.ReadPytanieDto.Id;
                Repository.DeleteOdpowiedzi(idPytania);
                Repository.DeletePytanie(idPytania);

                listaPytanOdpowiedzi.Remove(aktualnePytanie);
                RefreshData();
            }

        }
    }
}
