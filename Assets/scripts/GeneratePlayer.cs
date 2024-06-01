using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class GeneratePlayer : MonoBehaviour
{
    public static int Sex;
    [SerializeField] private CinemachineVirtualCamera m_camera;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject Man;
    [SerializeField] private GameObject Woman;

    [SerializeField] private Button ManButton;
    [SerializeField] private Button WoManButton;
    [SerializeField] private Button EnSureManButton;
    [SerializeField] private Button EnSureWoManButton;

    private GameObject Instance;

    private void Start()
    {
        ManButton.onClick.AddListener(() =>
        {
            Sex = 1;
            GenerateRole();
        });
        WoManButton.onClick.AddListener(() =>
        {
            Sex = 0;
            GenerateRole();
        });
        EnSureManButton.onClick.AddListener(() =>
        {
            Sex = 1;
            GenerateRole();
        });
        EnSureWoManButton.onClick.AddListener(() =>
        {
            Sex = 0;
            GenerateRole();
        });
    }
    public void GenerateRole()
    {
        if (Sex == 1)
        {
            Instance = Instantiate(Man, parentTransform.position, Quaternion.identity);
        }
        else if (Sex == 0)
        {
            Instance = Instantiate(Woman, parentTransform.position, Quaternion.identity);
        }
        Instance.transform.SetParent(parentTransform);
       
    }
    // Start is called before the first frame update
}
