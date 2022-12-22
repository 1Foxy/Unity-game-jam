using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingScript : MonoBehaviour
{
    public float mouseSen = 100f;
    public Transform PlayerBody;
    float xRot = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;


    }

    

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        xRot -= MouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
