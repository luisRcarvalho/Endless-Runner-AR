using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int pontos = 0;

    public Text Highscore;
    void Start()
    {
        pontos = 0;
        Highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    void Update()
    {
        GetComponent<Text>().text = pontos.ToString();

        if(pontos > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", pontos);
            Highscore.text = pontos.ToString();
        }
    }
}
