using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStartWindow : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButttonOnClick()
    {
        SceneManager.LoadScene("Main Screen");
    }
}
