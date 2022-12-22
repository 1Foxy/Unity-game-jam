using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AxeController : MonoBehaviour
{
    public GameObject Axe;
    public GameObject RArm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

        if (Input.GetMouseButtonDown(0))
        {
            Axe.transform.Rotate(90,0,0);
            RArm.transform.Rotate(10, 0 ,0);
        }
        if(Input.GetMouseButtonUp(0))
        {
            Axe.transform.Rotate(-90, 0, 0);
            RArm.transform.Rotate(-10, 0, 0);
        }
    }
}
