using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public List<GameObject> vehicles;
    public new GameObject camera;
    public int selectedVehicleIndex;
    void Start()
    {
        selectedVehicleIndex = GameManager.Instance.vehicleChoice;
        for (int i = 0; i < vehicles.Count;i++)
        {
            vehicles[i].SetActive(i == selectedVehicleIndex);
        }
        camera.GetComponent<CameraManager>().player = vehicles[selectedVehicleIndex];
    }
}
