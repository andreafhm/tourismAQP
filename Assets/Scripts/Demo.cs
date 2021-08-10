using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using UnityEngine.SceneManagement;

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
       {
           OnClick(param);
       });
    }
}
public class Demo : MonoBehaviour
{
    [Serializable]
    public struct Historia
    {
        public string Name;
        public string Description;
        public Sprite Icon;
    }

    [SerializeField] Historia[] allHistorias;

    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;
        int N = allHistorias.Length;
        for (int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<Image>().sprite = allHistorias[i].Icon;
            g.transform.GetChild(1).GetComponent<Text>().text = allHistorias[i].Name;
            g.transform.GetChild(2).GetComponent<Text>().text = allHistorias[i].Description;

            g.GetComponent<Button>().AddEventListener(i, ItemClicked);


        }

        Destroy(buttonTemplate);
       
    }

    void ItemClicked (int itemIndex)
    {
        Debug.Log("item " + itemIndex + " clicked");
        string sceneName;
        if (itemIndex == 0)
        {
            SceneManager.LoadScene("0");
        }
        if (itemIndex == 1)
        {
            SceneManager.LoadScene("1");
        }
        if (itemIndex == 2)
        {
            SceneManager.LoadScene("2");
        }

    }

}
