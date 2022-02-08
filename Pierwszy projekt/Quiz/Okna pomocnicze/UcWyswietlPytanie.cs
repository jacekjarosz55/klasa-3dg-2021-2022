using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Baza_danych.Dto;

namespace Quiz.Okna_pomocnicze
{
    public partial class UcWyswietlPytanie : UserControl
    {
        public PytanieOdpowiedzQuiz WyswietlPytanie
        {
            set
            {
                panelTrescPytania.Controls.Clear();
                flowLayoutPanelOdpowiedzi.Controls.Clear();

                if (value != null)
                {
                    panelTrescPytania.Controls.Add(value.PytanieQuiz.TextBoxPytanie);
                    foreach(OdpowiedzQuiz odpowiedzQuiz in value.OdpowiedziLista)
                    {
                        flowLayoutPanelOdpowiedzi.Controls.Add(odpowiedzQuiz.CheckBoxOdpowiedz);
                    }

                }
            }
        }

        public UcWyswietlPytanie()
        {
            InitializeComponent();
        }
    }

    public class PytanieOdpowiedzQuiz
    {
        public PytanieQuiz PytanieQuiz { get; set; }
        public List<OdpowiedzQuiz> OdpowiedziLista { get; set; }
    }


    public class PytanieQuiz
    {
        public PytanieReadDto ReadPytanieDto { get; set; }
        public TextBox TextBoxPytanie { get; set; }
    }

    public class OdpowiedzQuiz
    {
        public OdpowiedzReadDto OdpowiedzReadDto { get; set; }
        public CheckBox CheckBoxOdpowiedz { get; set; }
    }
}
