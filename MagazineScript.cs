using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineScript : MonoBehaviour
{
    public GameObject MagazineMenu;
    // Start is called before the first frame update
    void Start()
    {
        MagazineMenu.SetActive(false);
    }

    // Update is called once per frame
    public void OpenMagazineButton()
    {
        MagazineMenu.SetActive(true);
    }

    public void CancelMagazineButton()
    {
        MagazineMenu.SetActive(false);
    }
}
