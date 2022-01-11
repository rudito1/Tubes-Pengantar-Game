using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform target;
    public float followSpeed;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / followSpeed);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x , 1 , transform.position.z);

    }
}
