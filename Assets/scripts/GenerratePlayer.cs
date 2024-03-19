using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GenerratePlayer : MonoBehaviour
{
    public static int Sex;

    [SerializeField] private CinemachineVirtualCamera camera;
    [SerializeField] private GameObject Man;

    [SerializeField] private GameObject Woman;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Man, this.transform.position,Quaternion.identity);
        //Man.transform.SetParent(this.transform);
        camera.Follow = Man.transform;
    }

   
}