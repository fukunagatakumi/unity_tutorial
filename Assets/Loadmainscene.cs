using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadmainscene : MonoBehaviour
{
    public void Loadclickstartscene()
    {
        SceneManager.LoadScene("Game2");
    }
}
