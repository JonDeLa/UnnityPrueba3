using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f; //FLoat = Decimal
    public float cameraSpeed = 2f;
    public float clampCamera = 60f;

    private float rotX = 0f;
    

    // Update is called once per frame
    void Update()
    {
        float HORIZONTAL = Input.GetAxis("Horizontal");
        float VERTICAL = Input.GetAxis("Vertical");

        Vector3 move = transform.right * HORIZONTAL + transform.forward * VERTICAL;
        transform.position = move * moveSpeed * Time.deltaTime;

        rotX -= Input.GetAxis("Mouse Y") * cameraSpeed * Time.deltaTime;
        rotX = Mathf.Clamp(rotX, -clampCamera, clampCamera);
        Camera.main.transform.localRotation = Quaternion.Euler(rotX,0f,0f);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * cameraSpeed);
                
    }
}
