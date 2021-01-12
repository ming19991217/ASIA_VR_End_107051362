using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject WHISKY, RUM;
    public Transform WHISKYPos, RUMPos;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            dialoguePanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            dialoguePanel.SetActive(false);
        }

    }

    public void CreateWHISKY()
    {
        Instantiate(WHISKY, WHISKYPos.position, Quaternion.identity);
    }
    public void CreateRUM()
    {
        Instantiate(RUM, RUMPos.position, Quaternion.identity);
    }

}
