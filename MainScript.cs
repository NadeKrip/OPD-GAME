using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public bool timerActive = false;

    public float timerStart = 10;
    public Text timerText;
    public float timerStartVerst = 15;
    public Text timerTextVerst;
    public float timerStartProgramm = 30;
    public Text timerTextProgramm;

    public int designsCount = 0;
    public Text designsCountText;
    public int verstCount = 0;
    public Text verstCountText;
    public int programmCount = 0;
    public Text programmCountText;
    public int money = 2600;
    public Text moneyText;
    public Random rand = new Random();

    public GameObject Designer;
    public GameObject VerstMan;
    public GameObject Programmer;
    public bool DesignerIsActive = false;
    public bool VerstIsActive = false;
    public bool ProgramerIsActive = false;
    public GameObject DesignerTimer;
    public GameObject VerstManTimer;
    public GameObject ProgrammerTimer;


    void Start()
    {
        Designer.SetActive(false);
        VerstMan.SetActive(false);
        Programmer.SetActive(false);
        DesignerTimer.SetActive(false);
        VerstManTimer.SetActive(false);
        ProgrammerTimer.SetActive(false);
        money = 2600;
        moneyText.text = '$' + money.ToString();
        timerActive = true;
    }

    public void ActivateDesigner()
    {
        DesignerIsActive = true;
        Designer.SetActive(DesignerIsActive);
        DesignerTimer.SetActive(DesignerIsActive);
        money -= 500;
        moneyText.text = '$' + money.ToString();
    }

    public void ActivateVerstMan()
    {
        VerstIsActive = true;
        VerstMan.SetActive(VerstIsActive);
        VerstManTimer.SetActive(VerstIsActive);
        money -= 600;
        moneyText.text = '$' + money.ToString();
    }

    public void ActivateProgramer()
    {
        ProgramerIsActive = true;
        Programmer.SetActive(ProgramerIsActive);
        ProgrammerTimer.SetActive(ProgramerIsActive);
        money -= 1500;
        moneyText.text = '$' + money.ToString();
    }

    void Update()
    {
        designsCountText.text = designsCount.ToString();
        verstCountText.text = verstCount.ToString();
        programmCountText.text = programmCount.ToString();

        if (timerActive && (timerStart>=0) && DesignerIsActive)
        {
            timerStart -= Time.deltaTime;
            timerText.text= Mathf.Round(timerStart).ToString();
        }
        if(timerStart <= 0)
        {
            timerStart = 8;
            designsCount++;
        }

        if(designsCount > 0)
        {
            if (timerActive && (timerStartVerst >= 0) && VerstIsActive)
            {
                timerStartVerst -= Time.deltaTime;
                timerTextVerst.text = Mathf.Round(timerStartVerst).ToString();
            }
            if (timerStartVerst <= 0)
            {
                designsCount -= 1;
                timerStartVerst = 4;
                verstCount++;
            }
        }

        if (verstCount > 0)
        {
            if (timerActive && (timerStartProgramm >= 0) && ProgramerIsActive)
            {
                timerStartProgramm -= Time.deltaTime;
                timerTextProgramm.text = Mathf.Round(timerStartProgramm).ToString();
            }
            if (timerStartProgramm <= 0 && (verstCount > 0))
            {
                verstCount -= 1;
                timerStartProgramm = 15;
                programmCount++;
            }
            if(programmCount > 0)
            {
                money += 150;
                moneyText.text = '$' + money.ToString();
                programmCount -= 1;
            }
        }
            

    }
    public void ButtonClick()
    {
        timerActive = !timerActive;
    }
}
