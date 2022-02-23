using APIGestionCegep.Logics.Controleurs;
using APIGestionCegep.Logics.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIGestionCegep.Controllers
{
    public class EnseignantController : Controller
    {
        /// <summary>
        /// Méthode qui permet d'obtenir la liste des enseignants
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <returns></returns>
        [Route("Enseignant/ObtenirListeEnseignant")]
        [HttpGet]
        public List<EnseignantDTO> ObtenirListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            List<EnseignantDTO> liste;
            if(nomCegep!=null && nomDepartement != null)
            {
              liste=  CegepControleur.Instance.ObtenirListeEnseignant(nomCegep,nomDepartement);
            }
            else
            {
                liste = new List<EnseignantDTO>();
            }
            return liste;
            
        }
        /// <summary>
        /// Méthode qui permet d'obtenir un enseignants
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        [Route("Enseignant/ObtenirEnseignant")]
        [HttpGet]
        public EnseignantDTO ObtenirEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int no)
        {
            EnseignantDTO enseignantDTO;
            if (nomCegep!=null && nomDepartement != null)
            {
                enseignantDTO = CegepControleur.Instance.ObtenirEnseignant(nomCegep, nomDepartement, no);
            }
            else
            {
                enseignantDTO = null;
            }
            return enseignantDTO;
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un enseignants
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="enseignantDTO"></param>
        [Route("Enseignant/AjouterEnseignant")]
        [HttpPost]
        public void AjouterEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement,[FromBody] EnseignantDTO enseignantDTO)
        {
            if (nomDepartement!=null && nomCegep != null)
            {
                CegepControleur.Instance.AjouterEnseignant(nomCegep, nomDepartement, enseignantDTO);
            }
        }
        /// <summary>
        /// Méthode qui permet de modifier un enseignant
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="enseignantDTO"></param>
        [Route("Enseignant/ModifierEnseignant")]
        [HttpPost]
        public void ModifierEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromBody] EnseignantDTO enseignantDTO)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.ModifierEnseignant(nomCegep, nomDepartement, enseignantDTO);
            }
        }
        /// <summary>
        /// Méthode qui permet de supprimer un enseignant
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        /// <param name="no"></param>
        [Route("Enseignant/SupprimerEnseignant")]
        [HttpPost]
        public void SupprimerEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement, [FromQuery] int no)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.SupprimerEnseignant(nomCegep, nomDepartement, no);
            }
        }
        /// <summary>
        /// Méthode qui permet de vider la liste des enseignants
        /// </summary>
        /// <param name="nomCegep"></param>
        /// <param name="nomDepartement"></param>
        [Route("Enseignant/ViderListeEnseignant")]
        [HttpPost]
        public void ViderListeEnseignant([FromQuery] string nomCegep, [FromQuery] string nomDepartement)
        {
            if (nomDepartement != null && nomCegep != null)
            {
                CegepControleur.Instance.ViderListeEnseignant(nomCegep, nomDepartement);
            }
        }
    }
}
