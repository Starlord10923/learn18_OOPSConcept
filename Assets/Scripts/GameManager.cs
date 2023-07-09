using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int vehicleChoice;
    void Awake()
    {
        if(Instance==null){
            Instance = this;
            DontDestroyOnLoad(Instance);
        }else{
            Destroy(gameObject);
        }
    }

}
