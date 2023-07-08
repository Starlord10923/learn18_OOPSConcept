using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = new Vector3(0,10,-20);
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
