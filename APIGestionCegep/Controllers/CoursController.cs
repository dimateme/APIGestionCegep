using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIGestionCegep.Controllers
{
    public class CoursController : Controller
    {
        /// <summary>
        /// Méthode qui permet d'obtenir la liste des cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <returns></returns>
        [Route("Cours/ObtenirListeCours")]
        [HttpGet]
        public List<CoursDTO> ObtenirListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            List<CoursDTO> liste;
            if (nomCegep != null && nomDepartement != null)
            {
                liste = CegepControleur.Instance.ObtenirListeCours(nomCegep, nomDepartement);
            }
            else
            {
                liste = new List<CoursDTO>();
            }
            return liste;

        }
        /// <summary>
        /// Méthode qui permet d'obtenir un cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="nomCours"></param>
        /// <returns></returns>
        [Route("Cours/ObtenirCours")]
        [HttpGet]
        public CoursDTO ObtenirCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            CoursDTO coursDTO;
            if (nomCegep != null && nomDepartement != null && nomCours!=null)
            {
                coursDTO = CegepControleur.Instance.ObtenirCours(nomCegep, nomDepartement, nomCours);
            }
            else
            {
                coursDTO = null;
            }
            return coursDTO;
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="coursDTO"></param>
        [Route("Cours/AjouterCours")]
        [HttpPost]
        public void AjouterCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.AjouterCours(nomCegep, nomDepartement, coursDTO);
            }
        }
        /// <summary>
        /// Méthode qui permet de modifier un cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="coursDTO"></param>
        [Route("Cours/ModifierCours")]
        [HttpPost]
        public void ModifierCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] CoursDTO coursDTO)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.ModifierCours(nomCegep, nomDepartement, coursDTO);
            }
        }
        /// <summary>
        /// Méthode qui permet de supprimer un cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="nomCours"></param>
        [Route("Cours/SupprimerCours")]
        [HttpPost]
        public void SupprimerCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] string nomCours)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.SupprimerCours(nomCegep, nomDepartement, nomCours);
            }
        }
        /// <summary>
        /// Méthode qui permet de vider la liste des cours
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        [Route("Cours/ViderListeCours")]
        [HttpPost]
        public void ViderListeCours([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.ViderListeCours(nomCegep, nomDepartement);
            }
        }

    }
}
