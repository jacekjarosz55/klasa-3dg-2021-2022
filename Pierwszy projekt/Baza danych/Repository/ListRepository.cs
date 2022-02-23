using Baza_danych.Dto;
using Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Baza_danych.QuizAutoMapper;

namespace Baza_danych.Repository
{
    public class ListRepository : IRepository
    {
        List<Pytanie> pytaniaLista;
        List<Odpowiedz> odpowiedziLista;

        QuizAutomapper quizAutomapper = new QuizAutomapper();

        public ListRepository()
        {
            pytaniaLista = new List<Pytanie>();
            odpowiedziLista = new List<Odpowiedz>();

            Pytanie pytanie = new Pytanie();
            pytanie.Id = 0;
            pytanie.TrescPytania = "Ile wynosi wynik operacji 2+2?";
            pytaniaLista.Add(pytanie);

            Odpowiedz odpowiedz = new Odpowiedz();
            odpowiedz.Id = 0;
            odpowiedz.TrescOdpowiedzi = "2";
            odpowiedz.CzyPrawidlowa = false;
            odpowiedz.IdPytania = 0;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 1;
            odpowiedz.TrescOdpowiedzi = "4";
            odpowiedz.CzyPrawidlowa = true;
            odpowiedz.IdPytania = 0;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 2;
            odpowiedz.TrescOdpowiedzi = "6";
            odpowiedz.CzyPrawidlowa = false;
            odpowiedz.IdPytania = 0;
            odpowiedziLista.Add(odpowiedz);

            pytanie = new Pytanie();
            pytanie.Id = 1;
            pytanie.TrescPytania = "Identyfiaktory dostępu do składowych klasy to:";
            pytaniaLista.Add(pytanie);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 3;
            odpowiedz.TrescOdpowiedzi = "virtual";
            odpowiedz.CzyPrawidlowa = false;
            odpowiedz.IdPytania = 1;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 4;
            odpowiedz.TrescOdpowiedzi = "public";
            odpowiedz.CzyPrawidlowa = true;
            odpowiedz.IdPytania = 1;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 5;
            odpowiedz.TrescOdpowiedzi = "protected";
            odpowiedz.CzyPrawidlowa = true;
            odpowiedz.IdPytania = 1;
            odpowiedziLista.Add(odpowiedz);

            odpowiedz = new Odpowiedz();
            odpowiedz.Id = 6;
            odpowiedz.TrescOdpowiedzi = "static";
            odpowiedz.CzyPrawidlowa = false;
            odpowiedz.IdPytania = 1;
            odpowiedziLista.Add(odpowiedz);
        }

        #region CRUD

        #region C - Create


        #endregion

        #region R - Read

        public List<int> ReadPytaniaIdList()
        {
            var result = pytaniaLista.Select(p => p.Id).ToList();
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
