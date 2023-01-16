using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject EndPanel;

    public void StartChangePanel()
    {
        StartPanel.SetActive(false);
        EndPanel.SetActive(true);
    }
}
