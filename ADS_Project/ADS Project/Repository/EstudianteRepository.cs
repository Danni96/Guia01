﻿using ADS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADS_Project.Repository
{
    public class EstudianteRepository : IEstudianteRepository
    {
        private readonly List<EstudianteViewModel> lstEstudiantes;

        public EstudianteRepository()
        {
            lstEstudiantes = new List<EstudianteViewModel>
            {
                new EstudianteViewModel{ idEstudiante = 1, nombresEstudiante = "Dannis", apellidosEstudiante = "Sanchez",
                codigoEstudiante = "SL14I04001", correoEstudiante = "sl14i04001@usonsonate.edu.sv"
                }
            };
        }
        public int agregarEstudiante(EstudianteViewModel estudianteViewModel)
        {
            try
            {
                if(lstEstudiantes.Count > 0)
                {
                    estudianteViewModel.idEstudiante = lstEstudiantes.Last().idEstudiante + 1;
                }
                else
                {
                    estudianteViewModel.idEstudiante = 1;
                }
                lstEstudiantes.Add(estudianteViewModel);
                return estudianteViewModel.idEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarEstudiante(int idEstudiante, EstudianteViewModel estudianteViewModel)
        {
            try
            {
                lstEstudiantes[lstEstudiantes.FindIndex(x => x.idEstudiante == idEstudiante)] = estudianteViewModel;
                return estudianteViewModel.idEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarEstudiante(int idEstudiante)
        {
            try
            {
                lstEstudiantes.RemoveAt(lstEstudiantes.FindIndex(x => x.idEstudiante == idEstudiante));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public EstudianteViewModel obtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                var item = lstEstudiantes.Find(x => x.idEstudiante == idEstudiante);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteViewModel> obtenerEstudiantes()
        {
            try
            {
                return lstEstudiantes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
