using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottomjudgecontroller : MonoBehaviour
{
    public void Gameoverloadscene()
    {
        SceneManager.LoadScene("GameOver");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Gameoverloadscene();
    }
}
