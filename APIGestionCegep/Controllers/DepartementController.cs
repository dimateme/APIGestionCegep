using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APIGestionCegep.Controllers
{
    public class DepartementController : Controller
    {
        /// <summary>
        /// Méthode qui permet d'obtenir la liste des département
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <returns></returns>
        [Route("Departement/ObtenirListeDepartement")]
        [HttpGet]
        public List<DepartementDTO> ObtenirListeDepartement([FromQuery] string nomCegep)
        {
            List<DepartementDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeDepartement(nomCegep);
            }
            catch (Exception)
            {
                liste = new List<DepartementDTO>();


            }
            return liste;
        }
        /// <summary>
        /// Methode qui permet d'obtenir un département
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <returns></returns>
        [Route("Departement/ObtenirDepartement")]
        [HttpGet]
        public DepartementDTO ObtenirDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            /// <summary>
            /// Atteibut répresentant le DTO duCgep
            /// </summary>
           DepartementDTO unDepartementDTO;

            try
            {
                unDepartementDTO= CegepControleur.Instance.ObtenirDepartement(nomCegep,nomDepartement);
            }
            catch (Exception)
            {

                unDepartementDTO = null;
            }

            return unDepartementDTO;

        }
        /// <summary>
        /// Méthode qui d'ajouter d'un departement
        /// </summary>
        /// <param name="nomCgep"></param>
        /// <param name="nomDepartementDTO"></param>
        [Route("Departement/AjouterDepartement")]
        [HttpPost]
        public void AjouterCegep([FromQuery] string nomCgep, [FromBody] DepartementDTO nomDepartementDTO)
        {
            if (nomDepartementDTO != null && nomCgep!=null)
            {
                CegepControleur.Instance.AjouterDepartement(nomCgep,nomDepartementDTO);

            }
        }
        /// <summary>
        /// Méthode qui permet de Modifier département
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="unDepartementDTO"></param>
        [Route("Departement/ModifierDepartement")]
        [HttpPost]
        public void ModifierDepartement([FromQuery] string nomCegep, [FromBody] DepartementDTO unDepartementDTO)
        {

            if (unDepartementDTO != null && nomCegep!=null)
            {
                CegepControleur.Instance.ModifierDepartement(nomCegep,unDepartementDTO);
            }
        }
        /// <summary>
        /// Methode qui permet de supprimer un departement
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        [Route("Departement/SupprimerDepartement")]
        [HttpPost]
        public void SupprimerDepartement([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            if (nomCegep != null && nomDepartement!=null)
            {
                CegepControleur.Instance.SupprimerDepartement(nomCegep,nomDepartement);
            }

        }
        /// <summary>
        /// Methode qui permet de vider la liste des departements
        /// </summary>
        /// <param name="nomCegep"></param>
        [Route("Departement/ViderListeDepartement")]
        [HttpPost]
        public void ViderListeDepartement([FromQuery] string nomCegep)
        {
            CegepControleur.Instance.ViderListeDepartement(nomCegep);
        }
        
    }
}
