using System;
using UnityEngine;
using System.Collections;

public class DataBase : MonoBehaviour
{

    public String[] db;


    void Awake()
    {
        db[0] = "Project TOS.XI-042\nRapport n\u00b01:\n\nDate d\'entrée: 21/13/2023:\n\n" +
                "La sélection des sujets est finalement terminée. \n" +
                "Les candidats ont été choisis pour leurs aptitudes physiques et intellectuelles dans le but d\'explorer ‘l\'autre cote\' nom de code dimension NX-37-R. \n" +
                "Leur rôle est capital : ils seront les premiers à entrer en contact avec d\'éventuels êtres vivants. \n" +
                "Les informations et échantillons qu\'ils ramèneront seront essentielles à la compréhension de ce nouvel univers. \n" +
                "Actuellement, nos explorateurs suivent un entrainement spécialisé dans le but de les préparer au -plongeon-. \n" +
                "Transfert prévu pour la semaine prochaine.";
        db[1] = "Project TOS.XI-042\nRapport n\u00b024:\n\nDate d\'entrée: 28/10/2023:\n\n" +
                "Le projet TOS.XI-042 s\'est soldé par un échec cuisant. /n" +
                "Nous avons sous-estimé les ressources nécessaires au voyage entre les dimensions : /n" +
                "aucun des voyageurs n\'a atteint l\'autre côté. /n" +
                "Plusieurs d\'entre eux sont sujets à des hallucinations depuis hier : /n" +
                "il se pourrait qu\'ils soient, d\'une certaine manière, connectés à l\'autre dimension. /n" +
                "Le cas du sujet XM014 est néanmoins inquiétant. /n" +
                "Il est le seul à ne pas s\'être réveillé du transfert, /n" +
                "et l\'espace autour de sa cellule semble instable. /n" +
                "Il se pourrait qu\'une partie de lui soit arrivée dans la Nouvelle Dimension, /n" +
                "mais rien ne peut nous l\'assurer. /n" +
                "L\'observation de son cas constituera notre mission principale au cours des prochains jours.";
        db[2] = "EVACUATION D\'URGENCE \n" +
                "L\'état d\'évacuation d\'urgence est annoncé. \n" +
                "Veuillez vous diriger immédiatement vers la sortie la plus proche.";
        db[3] = "Project TOS.XI-042\n" +
                "Rapport n\u00b076:\n\nDate d\'entrée: 29/10/2023:\n\n" +
                "L\'espace commence à se désagréger autour de la cellule du sujet XM014.\n" +
                "La zone concernée semble s\'élargir d\'heure en heure : \n" +
                "il est possible qu\'une évacuation des locaux soit nécessaire pour" +
                " assurer la sécurité des sujets ainsi que celle du personnel.\n" +
                "Il semblerait que nos deux dimensions soient peu à peu en train de se superposer.\n" +
                "Afin d\'assurer la stabilité de notre monde, la décision de couper" +
                " définitivement le Connecteur Dimensionnel a été prise par le chef des opérations," +
                " même si cela implique d\'abandonner le sujet XM014 actuellement confiné dans sa cellule.";
        db[4] = "Project TOS.XI-042\n" +
                "Rapport n\u00b0101:\n\nDate d\'entrée: 29/10/2023:\n\n" +
                "Il est impossible de désactiver le Connecteur Dimensionnel.\n " +
                "L\'extension de la zone est désormais hors de contrôle : \n" +
                "L\'armée va procéder à une évacuation de la ville. \n" +
                "Il est impossible de présager... [Le rapport s\'arrête ici].";
        db[5] = "Project UFO.Z-51\n" +
                "Rapport n\u00b0713705:\n\nDate d\'entrée: 31/08/1947:\n\n" +
                "Après plusieurs tentatives pour pouvoir -CLASSIFIED INFORMATION, REQUIRES HIGHER LEVEL OF ACCESS-, nous avons finalement eu un premier résultat: \n" +
                "-CLASSIFIED INFORMATION, REQUIRES HIGHER LEVEL OF ACCESS-.\n" +
                " Lors de l\'évènement -CLASSIFIED INFORMATION, REQUIRES HIGHER LEVEL OF ACCESS-\n " +
                "et plusieurs membres du personnel du -CLASSIFIED INFORMATION, REQUIRES HIGHER LEVEL OF ACCESS-\n" +
                "ont été aveuglés ou -CLASSIFIED INFORMATION, REQUIRES HIGHER LEVEL OF ACCESS-.";
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
