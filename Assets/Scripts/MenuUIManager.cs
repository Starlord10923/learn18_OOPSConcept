using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif
public class MenuUIManager : MonoBehaviour
{
    public void StartGame(int i){
        GameManager.Instance.vehicleChoice = i;
        SceneManager.LoadScene(1);
    }
    public void EndGame(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
