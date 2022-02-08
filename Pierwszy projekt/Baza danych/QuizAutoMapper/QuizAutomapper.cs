using AutoMapper;
using Baza_danych.Dto;
using Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.QuizAutoMapper
{
    public class QuizAutomapper
    {
        public IMapper Mapper { get; set; }

        private MapperConfiguration configMapper;

        public QuizAutomapper()
        {
            configMapper = new MapperConfiguration(ConfigAutomapper);
            Mapper = configMapper.CreateMapper();
        }

        private void ConfigAutomapper(IMapperConfigurationExpression obj)
        {
            obj.CreateMap<Pytanie, PytanieReadDto>();
            obj.CreateMap<Odpowiedz, OdpowiedzReadDto>();

        }
    }
}
