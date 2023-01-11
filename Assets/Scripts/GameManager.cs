using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> buttons = new List<GameObject>();


    public void LoadScene(int sceneNumber)

    {
        SceneManager.LoadScene(sceneNumber);
    }

}