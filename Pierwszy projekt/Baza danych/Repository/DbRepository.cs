using Baza_danych.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.Repository
{
    public class DbRepository : IRepository
    {


        public void DeleteOdpowiedzi(int idPytanie)
        {
            throw new NotImplementedException();
        }

        public void DeletePytanie(int idPytanie)
        {
            throw new NotImplementedException();
        }

        public List<PytanieReadDto> ReadListaPytan()
        {
            throw new NotImplementedException();
        }

        public List<OdpowiedzReadDto> ReadOdpowiedzi(int idPytania)
        {
            throw new NotImplementedException();
        }

        public List<int> ReadPytaniaIdList()
        {
            throw new NotImplementedException();
        }

        public PytanieReadDto ReadPytanie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
