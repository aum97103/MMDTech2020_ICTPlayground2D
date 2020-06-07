using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreSystem.theScore = 0;
        HealthSystem.Health = 10;
        SceneManager.LoadScene(0);
    }
}
