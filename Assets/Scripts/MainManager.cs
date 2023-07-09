using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public List<GameObject> vehicles;
    private new GameObject camera;
    public int selectedVehicleIndex;
    void Start()
    {
        camera = Camera.main.gameObject;
        selectedVehicleIndex = GameManager.Instance.vehicleChoice;
        for (int i = 0; i < vehicles.Count;i++)
        {
            vehicles[i].SetActive(i == selectedVehicleIndex);
        }
        camera.GetComponent<CameraManager>().player = vehicles[selectedVehicleIndex];
    }
}
