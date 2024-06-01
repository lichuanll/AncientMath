using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button button;
    public GameObject startPanel;
    public GameObject SelectRoleUI;
    // Start is called before the first frame update
    public void OnStartButtonPressed()
    {
        startPanel.SetActive(false);
        SelectRoleUI.SetActive(true);
    }

    // Update is called once per frame
}
