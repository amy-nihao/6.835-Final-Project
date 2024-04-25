using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapRotater : MonoBehaviour
{

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, camera.transform.eulerAngles.y + 25, transform.eulerAngles.z);
    }
}
