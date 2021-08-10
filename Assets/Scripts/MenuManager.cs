using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene("Mapas");
    }
    public void BotonQuit()
    {
        Debug.Log("Estamos saliendo de la aplicación");
        Application.Quit();
    }
    public void BotonHistory()
    {
        SceneManager.LoadScene("Historias");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
