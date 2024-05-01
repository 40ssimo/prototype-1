using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetPositionTPS = new Vector3(0, 8f, -8f);
    public bool isCameraTps = true;
    public Camera fpsCamera;
    public Camera tpsCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void LateUpdate()
    {

        if (isCameraTps)
        {
            transform.position = player.transform.position + offsetPositionTPS;
            switchCamera(switchKey);
        }
        else
        {
            switchCamera(switchKey);
        }
    }

    void switchCamera(KeyCode switchKey)
    {
        if (Input.GetKeyDown(switchKey) && (isCameraTps == true))
        {
            fpsCamera.enabled = true;
            isCameraTps = false;
        }
        else if (Input.GetKeyDown(switchKey) && (isCameraTps == false))
        {
            fpsCamera.enabled = false;
            isCameraTps= true;
        }
    }
}
