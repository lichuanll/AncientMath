using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GeneratePlayer : MonoBehaviour
{
    public static int Sex;

    [SerializeField] private CinemachineVirtualCamera m_camera;
    [SerializeField] private GameObject Man;

    [SerializeField] private GameObject Woman;

    private GameObject Instance;

    public void GenerateRole(int sex)
    {
        if (sex == 0)
        {
            Instance = Instantiate(Man, this.transform.position, Quaternion.identity);
        }
        else if(sex == 1)
        {
            Instance = Instantiate(Woman, this.transform.position, Quaternion.identity);
        }
        //Man.transform.SetParent(this.transform);
        m_camera.Follow = Instance.transform;
    }
    // Start is called before the first frame update
}
