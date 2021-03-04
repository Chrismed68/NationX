using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class VisionScript : MonoBehaviour
{

    private float mouseSense = 120f;
    public Transform UmojaBody;
    float horiRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        horiRotation -= mouseY;
        horiRotation = Mathf.Clamp(horiRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(horiRotation, 0f, 0f);
        UmojaBody.Rotate(Vector3.up * mouseX);

    }
}
