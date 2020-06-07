using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject HealthText;
    public static int Health;
    public int MaxHP;
    public GameObject GameOver;
    void Start()
    {
        Health = MaxHP;
        //GameOver.SetActive(false);
    }
    void Update()
    {
        if(Health <= 0)
        {
            Health = 0;
            SceneManager.LoadScene(2);
        }
        HealthText.GetComponent<Text>().text = "Health: " + Health;
    }
}