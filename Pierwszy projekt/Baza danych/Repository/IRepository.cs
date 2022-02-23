using Baza_danych.Dto;
using System.Collections.Generic;

namespace Baza_danych.Repository
{
    public interface IRepository
    {
        void DeleteOdpowiedzi(int idPytanie);
        void DeletePytanie(int idPytanie);
        List<PytanieReadDto> ReadListaPytan();
        List<OdpowiedzReadDto> ReadOdpowiedzi(int idPytania);
        List<int> ReadPytaniaIdList();
        PytanieReadDto ReadPytanie(int id);
    }
}