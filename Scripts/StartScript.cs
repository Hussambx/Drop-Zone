using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public float RotationPerSecond;
    public Material[] Skyboxes;
    private int time;
    public GameObject startcan;
    public GameObject levelscan;
    public int requestedlevel;
    private int levelsunlocked;
    private int activelevel;
    public GameObject itslocked;
    public GameObject controlscan;
    public GameObject healthnsafe;
    //All these for gui buttons levels

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;
    public GameObject button11;
    public GameObject button12;
    public GameObject button13;
    public GameObject button14;
    public GameObject button15;
    public GameObject button16;
    public GameObject button17;
    public GameObject button18;
    public GameObject button19;
    public GameObject button20;
    // Start is called before the first frame update
    void Start()
    {
        //This area for level setting 
        activelevel = PlayerPrefs.GetInt("activelevel");
        levelsunlocked = PlayerPrefs.GetInt("levelsunlocked");
        Debug.Log(levelsunlocked);
        if (levelsunlocked <=0)
        {
            button1.GetComponent<Image>().color = Color.green;
            levelsunlocked = 1;
            PlayerPrefs.SetInt("levelsunlocked", levelsunlocked);
         

        }
        if (levelsunlocked ==2)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 3)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked ==4)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 5)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked ==6)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 7)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 8)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 9)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 10)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 11)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 12)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 13)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 14)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 15)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 16)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button16.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 17)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button16.GetComponent<Image>().color = Color.green;
            button17.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 18)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button16.GetComponent<Image>().color = Color.green;
            button17.GetComponent<Image>().color = Color.green;
            button18.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 19)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button16.GetComponent<Image>().color = Color.green;
            button17.GetComponent<Image>().color = Color.green;
            button18.GetComponent<Image>().color = Color.green;
            button19.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }
        if (levelsunlocked == 20)
        {
            button1.GetComponent<Image>().color = Color.green;
            button2.GetComponent<Image>().color = Color.green;
            button3.GetComponent<Image>().color = Color.green;
            button4.GetComponent<Image>().color = Color.green;
            button5.GetComponent<Image>().color = Color.green;
            button6.GetComponent<Image>().color = Color.green;
            button7.GetComponent<Image>().color = Color.green;
            button9.GetComponent<Image>().color = Color.green;
            button10.GetComponent<Image>().color = Color.green;
            button11.GetComponent<Image>().color = Color.green;
            button12.GetComponent<Image>().color = Color.green;
            button13.GetComponent<Image>().color = Color.green;
            button14.GetComponent<Image>().color = Color.green;
            button15.GetComponent<Image>().color = Color.green;
            button16.GetComponent<Image>().color = Color.green;
            button17.GetComponent<Image>().color = Color.green;
            button18.GetComponent<Image>().color = Color.green;
            button19.GetComponent<Image>().color = Color.green;
            button20.GetComponent<Image>().color = Color.green;
            button8.GetComponent<Image>().color = Color.green;
        }









        time = 3;
        RotationPerSecond = 1.5f;
    }

     IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.5f);
        itslocked.SetActive(false);

    }

    public void LoadLevel(int level)
    {
        Debug.Log(level);
        if (level <= levelsunlocked)
        {
            levelscan.SetActive(false);
            activelevel = level;
            PlayerPrefs.SetInt("activelevel", activelevel);
            SceneManager.LoadScene("Main Scene");

        }
        if (level > levelsunlocked)
        {
            itslocked.SetActive(true);
             StartCoroutine(Timer());

        }

    }

    public void gohealth()
    {
        startcan.SetActive(false);
        healthnsafe.SetActive(true);
        
    }


   
    public void gotolevels()
    {
        startcan.SetActive(false);
        levelscan.SetActive(true);

    }

    public void gohome()
    {
        controlscan.SetActive(false);
        levelscan.SetActive(false);
        healthnsafe.SetActive(false);
        startcan.SetActive(true);
    }

    public void controls()
    {
        startcan.SetActive(false);
        controlscan.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }
}
