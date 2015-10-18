using System;
using UnityEngine;
using System.Collections;

public class DataBase : MonoBehaviour
{

    public String[] db;


    void Awake()
    {
        db[0] = "Project TOS.XI-042\nRapport n\u00b01:\n\nDate d\'entree: 21/13/2023:\n\n" +
                "La selection des sujets est finalement terminee. \n" +
                "Les candidats ont ete choisis sur leurs aptitudes physiques et intellectuelles dans le but d’explorer “l’autre cote” nom de code dimmension NX-37-R. \n" +
                "Leur role est capital : ils seront les premiers e entrer en contact avec d’eventuels etres vivants. \n" +
                "Les informations et echantillons qu’ils rameneront seront essentielles e la comprehension de ce nouvel univers. \n" +
                "Actuellement, nos explorateurs suivent un entraînement specialise dans le but de les preparer au -plongeon-. \n" +
                "Transfert prevu pour la semaine prochaine.";
        db[1] = "Project TOS.XI-042\nRapport n\u00b024:\n\nDate d\'entree: 28/10/2023:\n\n" +
                "Le projet TOS.XI-042 s’est solde par un echec cuisant. /n" +
                "Nous avons sous-estime les ressources necessaires au voyage entre les dimensions : /n" +
                "aucun des voyageurs n’a atteint l’autre cote. /n" +
                "Plusieurs d’entre eux sont sujets e des hallucinations depuis hier : /n" +
                "il se pourrait qu’ils soient, d’une certaine maniere, connectes e l’autre dimension. /n" +
                "Le cas du sujet XM014 est neanmoins inquietant. /n" +
                "Il est le seul e ne pas s’etre reveille du transfert, /n" +
                "et l’espace autour de sa cellule semble instable. /n" +
                "Il se pourrait qu’une partie de lui soit arrivee dans la Nouvelle Dimension, /n" +
                "mais rien ne peut nous l’assurer. /n" +
                "L’observation de son cas constituera notre mission principale au cours des prochains jours.";
        db[2] = "EVACUATION D’URGENCE \n" +
                "L’etat d’evacuation d’urgence est annonce. \n" +
                "Veuillez vous diriger immediatement vers la sortie la plus proche.";
        db[3] = "Project TOS.XI-042\n" +
                "Rapport n\u00b076:\n\nDate d\'entree: 29/10/2023:\n\n" +
                "L’espace commence e se desagreger autour de la cellule du sujet XM014.\n" +
                "La zone concernee semble s’elargir d’heure en heure : \n" +
                "il est possible qu’une evacuation des locaux soit necessaire pour" +
                " assurer la securite des sujets ainsi que celle du personnel.\n" +
                "Il semblerait que nos deux dimensions soient peu e peu en train de se superposer.\n" +
                "Afin d’assurer la stabilite de notre monde, la decision de couper" +
                " definitivement le Connecteur Dimensionnel a ete prise par le chef des operations," +
                " meme si cela implique d’abandonner le sujet XM014 actuellement confine dans sa cellule.";
        db[4] = "Project TOS.XI-042\n" +
                "Rapport n\u00b0101:\n\nDate d\'entree: 29/10/2023:\n\n" +
                "Il est impossible de desactiver le Connecteur Dimensionnel.\n " +
                "L’extension de la zone est desormais hors de controle : \n" +
                "L’armee va proceder e une evacuation de la ville. \n" +
                "Il est impossible de presager... [Le rapport s’arrete ici].";
    }

    public string GetScript(int id)
    {
        return db[id];
    }

    public String[] DbArray
    {
        get { return db; }
        set { db = value; }
    }

}
