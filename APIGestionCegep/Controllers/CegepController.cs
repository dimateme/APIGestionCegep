using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APIGestionCegep.Controllers
{
    [ApiController]
    
    public class CegepController : Controller
    {


        /// <summary>
        ///  Méthode qui permet d'obtenir la liste de Cégep
        /// </summary>
        /// <returns></returns>
        [Route("Cegep/ObtenirListeCegep")]
        [HttpGet]
        public List<CegepDTO> ObtenirListeCegep()
        {
            List<CegepDTO> liste;
            try
            {
                liste = CegepControleur.Instance.ObtenirListeCegep();
            }
            catch (Exception )
            {
                liste=new List<CegepDTO>();
                
               
            }
            return liste;
        }
        /// <summary>
        /// // Méthode qui permet d'obtenir  un Cégep
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <returns></returns>
        [Route("Cegep/ObtenirCegep")]
        [HttpGet]
        public CegepDTO  ObtenirCegep([FromQuery] string nomCegep)
        {
            /// <summary>
            /// Atteibut répresentant le DTO duCgep
            /// </summary>
            CegepDTO unCegep;

            try
            {
                unCegep = CegepControleur.Instance.ObtenirCegep(nomCegep);
            }
            catch (Exception)
            {

                unCegep = null;
            }
           
            return unCegep;
            
        }
        /// <summary>
        /// // Méthode qui permet d'ajouter un Cégep
        /// </summary>
        /// <param name="nomCgep"></param>
        [Route("Cegep/AjouterCegep")]
        [HttpPost]
        public void AjouterCegep([FromBody] CegepDTO nomCgep)
        {
            if(nomCgep != null)
            {
                CegepControleur.Instance.AjouterCegep(nomCgep);
               
            }
        }


        /// <summary>
        /// // Méthode qui permet de supprimer un Cégep
        /// </summary>
        /// <param name="unCegep"></param>
        [Route("Cegep/SupprimerCegep")]
        [HttpPost]
        public void SupprimerCegep([FromQuery] string unCegep)
        {
            if(unCegep != null)
            {
                CegepControleur.Instance.SupprimerCegep(unCegep);
            }
            
        }
        /// <summary>
        /// // Méthode qui permet de modifier un Cégep
        /// </summary>
        /// <param name="unCegep"></param>
        [Route("Cegep/ModifierCegep")]
        [HttpPost]
        public void ModifierCegep([FromBody] CegepDTO unCegep)
        {

            if (unCegep != null)
            {
                CegepControleur.Instance.ModifierCegep(unCegep);
            }
        }
        /// <summary>
        /// // Méthode qui permet de vider la liste de Cégep
        /// </summary>
        [Route("Cegep/ViderListeCegep")]
        [HttpPost]
        public void ViderListeCegep()
        {
            CegepControleur.Instance.ViderListeCegep();
        }
    }
}
