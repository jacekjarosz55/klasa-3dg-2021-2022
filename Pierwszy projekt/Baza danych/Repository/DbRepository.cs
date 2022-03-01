using Baza_danych.Context;
using Baza_danych.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baza_danych.Repository
{
    public class DbRepository : IRepository
    {
        SqlContext sqlContext;

        public DbRepository()
        {
            sqlContext = new SqlContext();
        }

        #region CRUD

        #region C - Create


        #endregion

        #region R - Read

        public List<int> ReadPytaniaIdList()
        {
            //select id from Pytania
            var result = sqlContext.Pytania.Select(p => p.Id).ToList();
            return result;
        }

        public List<PytanieReadDto> ReadListaPytan()
        {
            List<PytanieReadDto> readPytanieDtos = quizAutomapper.Mapper.Map<List<PytanieReadDto>>(pytaniaLista);
            return readPytanieDtos;
        }

        public PytanieReadDto ReadPytanie(int id)
        {
            Pytanie pytanie = pytaniaLista.FirstOrDefault(p => /*return*/ p.Id == id);
            if (pytanie == null)
                throw new Exception("Nie znaleziono pytania o podanym ID");

            PytanieReadDto readPytanieDto = quizAutomapper.Mapper.Map<PytanieReadDto>(pytanie);
            return readPytanieDto;
        }

        public List<OdpowiedzReadDto> ReadOdpowiedzi(int idPytania)
        {
            List<Odpowiedz> odpowiedzi = odpowiedziLista.Where(o => o.IdPytania == idPytania).ToList();

            List<OdpowiedzReadDto> result = quizAutomapper.Mapper.Map<List<OdpowiedzReadDto>>(odpowiedzi);

            return result;
        }



        #endregion

        #region U - Update



        #endregion

        #region D - Delete

        public void DeleteOdpowiedzi(int idPytanie)
        {
            odpowiedziLista.RemoveAll(odp => odp.IdPytania == idPytanie);
        }

        public void DeletePytanie(int idPytanie)
        {
            pytaniaLista.RemoveAll(pyt => pyt.Id == idPytanie);
        }

        #endregion


        #endregion
    }
}
