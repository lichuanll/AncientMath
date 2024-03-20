using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GenerratePlayer : MonoBehaviour
{
    public static int Sex;

    [SerializeField] private CinemachineVirtualCamera m_camera;
    [SerializeField] private GameObject Man;

    [SerializeField] private GameObject Woman;

    private GameObject Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = Instantiate(Man, this.transform.position,Quaternion.identity);
        //Man.transform.SetParent(this.transform);
        m_camera.Follow = Instance.transform;
        
    }

   
}
