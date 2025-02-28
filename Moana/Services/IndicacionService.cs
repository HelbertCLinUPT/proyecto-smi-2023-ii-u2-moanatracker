﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moana.Models;


namespace Moana.Services
{
    public interface IIndicacionService
    {
        Task<Indicacion> GetIndicaciones();


    }

    public class IndicacionService : IIndicacionService
    {
        private readonly Supabase.Client _supabase;

        public IndicacionService(Supabase.Client supabase)
        {
            _supabase = supabase ?? throw new ArgumentNullException(nameof(supabase));

        }

        public async Task<Indicacion> GetIndicacionesbyid(int IdIndicacion )
        {
            try
            {
                var indicaciones = await _supabase
                    .From<Indicacion>()
                    .Select("*")
                    .Where(x => x.IdIndicacion == IdIndicacion)
                    .Get();
                return indicaciones.Models;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener médicos: " + ex.Message);
                return new Indicacion();
            }
        }
    }
}
