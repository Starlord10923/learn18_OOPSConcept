using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public List<GameObject> vehicles;
    public new GameObject camera;
    public int selectedVehicleIndex = 1;
    void Start()
    {
        for (int i = 0; i < vehicles.Count;i++)
        {
            vehicles[i].SetActive(i == selectedVehicleIndex);
        }
        camera.GetComponent<CameraManager>().player = vehicles[selectedVehicleIndex];
    }
}
