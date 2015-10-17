using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogText;
    public DataBase db;

    public void OpenDialogue(int id)
    {
        this.dialogBox.SetActive(true);
        this.dialogText.text = db.GetScript(id);
    }
    public void CloseDialogue()
    {
        dialogBox.SetActive(false);
        dialogText.text = "";
    }

}
