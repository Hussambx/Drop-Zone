using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamics : MonoBehaviour
{
    private int activelevel;
    public Material[] material;
    Renderer rend1;
    Renderer rend2;
    Renderer rend3;
    Renderer rend4;
    Renderer rend5;
    Renderer rend6;
    Renderer rend7;
    Renderer rend8;
    Renderer rend9;
    Renderer rend10;
    private float timebflip;
    private GameObject g1;
    private GameObject g2;
    private GameObject g3;
    private GameObject g4;
    private GameObject g5;
    private GameObject g6;
    private GameObject g7;
    private GameObject g8;
    private GameObject g9;
    private GameObject g10;
    private float othertimeflip;
    //This area for gameobjects requiring color switchs grouped by letter followed by number if there corsponding

        //For Level 11
    public GameObject a1;
    public GameObject a2;
    public GameObject b1;
    public GameObject b2;
    public GameObject c1;
    public GameObject c2;

    //For Level 12
    public GameObject d1;
    public GameObject d2;
    public GameObject e10;
    public GameObject e11;
    public GameObject f1;
    public GameObject f2;
    public GameObject h1;
    public GameObject h2;

    //For Level 13
    public GameObject i1;
    public GameObject i2;
    public GameObject j1;
    public GameObject j2;
    public GameObject k1;
    public GameObject k2;
    public GameObject k3;
    public GameObject k4;
    //For Level 14
    public GameObject l1;
    public GameObject l2;
    public GameObject mm1;
    public GameObject mm2;
    public GameObject n1;
    public GameObject n2;
    public GameObject o1;
    public GameObject o2;
    public GameObject q1;
    public GameObject q2;
    //For Level 15
    public GameObject r1;
    public GameObject r2;
    public GameObject s1;
    public GameObject s2;
    public GameObject t1;
    public GameObject t2;
    public GameObject u1;
    public GameObject u2;
    public GameObject p1;
    public GameObject p2;






    //This area for disappearing objects
    public GameObject ga1;
    public GameObject ga2;
    public GameObject ga3;
    public GameObject ga4;
    public GameObject ga5;
    public GameObject ga6;
    //For level 12
    public GameObject ga7;
    public GameObject ga8;
    public GameObject ga9;
    public GameObject ga10;
    public GameObject ga11;
    public GameObject ga12;
    public GameObject ga13;
    public GameObject ga14;
    //For level 13
    public GameObject ga15;
    public GameObject ga16;
    public GameObject ga17;
    public GameObject ga18;
    public GameObject ga19;
    public GameObject ga20;
    public GameObject ga21;
    public GameObject ga22;
    //For Level 14
    public GameObject ga23;
    public GameObject ga24;
    public GameObject ga25;
    public GameObject ga26;
    public GameObject ga27;
    public GameObject ga28;
    public GameObject ga29;
    public GameObject ga30;
    public GameObject ga31;
    public GameObject ga32;
    //For Level 15
    public GameObject ga33;
    public GameObject ga34;
    public GameObject ga35;
    public GameObject ga36;
    public GameObject ga37;
    public GameObject ga38;
    public GameObject ga39;
    public GameObject ga40;
    public GameObject ga41;
    public GameObject ga42;



    // This area for setting colors
    private int m1 = 0;
    private int e1 = 1;
    private int m2;
    private int e2;
    private int m3;
    private int e3;
    private int e4;
    private int m4;
    private int m5;
    private int e5;

    // Start is called before the first frame update
    void Start()
    {
        activelevel = PlayerPrefs.GetInt("activelevel");
        timebflip = 1.4f;
        othertimeflip = 1.4f;
        if (activelevel == 11)
        {
          
            m1 = 0;
            e1 = 1;
            rend1 = a1.GetComponent<Renderer>();
            rend1.enabled = true;
            rend2 = a2.GetComponent<Renderer>();
            rend2.enabled = true;
            //Place holders fill in #'s
            m2 = 3; e2 = 1;
            rend3 = b1.GetComponent<Renderer>();
            rend3.enabled = true;
            rend4 = b2.GetComponent<Renderer>();
            rend4.enabled = true;
            m3 = 5; e3 = 4;
            rend5 = c1.GetComponent<Renderer>();
            rend5.enabled = true;
            rend6 = c2.GetComponent<Renderer>();
            rend6.enabled = true;
            g1 = ga1; g2 = ga2;
            g3 = ga3; g4 = ga4;
            g5 = ga5; g6 = ga6;
            StartCoroutine(flip());
            StartCoroutine(gone());
        }
        if (activelevel ==12)
        {
            //Do m1 and e1 thing here for every gap
            m1 = 3; e1 = 4;
            rend1 = d1.GetComponent<Renderer>();
            rend1.enabled = true;
            rend2 = d2.GetComponent<Renderer>();
            rend2.enabled = true;
            m2 = 2; e2 = 1;
            rend3 =e10.GetComponent<Renderer>();
            rend3.enabled = true;
            rend4 =e11.GetComponent<Renderer>();
            rend4.enabled = true;
            m3 = 5; e3 = 4;
            rend5 = f1.GetComponent<Renderer>();
            rend5.enabled = true;
            rend6 = f2.GetComponent<Renderer>();
            rend6.enabled = true;
            m4 = 0; e4 = 3;
            rend7 = h1.GetComponent<Renderer>();
            rend7.enabled = true;
            rend8 = h2.GetComponent<Renderer>();
            rend8.enabled = true;

            g1 = ga7; g2 = ga8; g3 = ga9; g4 = ga10; g5 = ga11; g6 = ga12; g7 = ga13; g8 = ga14;
            StartCoroutine(flip());
            StartCoroutine(gone());
        }
        if (activelevel == 13)
        {
            m1 = 0; e1 = 1; 
            rend1 = i1.GetComponent<Renderer>();
            rend1.enabled = true;
            rend2 = i2.GetComponent<Renderer>();
            rend2.enabled = true;
            m2 = 2; e2 = 3;
            rend3 = j1.GetComponent<Renderer>();
            rend3.enabled = true;
            rend4= j2.GetComponent<Renderer>();
            rend4.enabled = true;
            m3 = 4; e3 = 3;
            rend5 = k1.GetComponent<Renderer>();
            rend5.enabled = true;
            rend6 = k2.GetComponent<Renderer>();
            rend6.enabled = true;
            m4 = 4; e3 = 3;
            rend7 = k3.GetComponent<Renderer>();
            rend7.enabled = true;
            rend8 = k4.GetComponent<Renderer>();
            rend8.enabled = true;

            g1 = ga15; g2 = ga16; g3 = ga17; g4 = ga18; g5 = ga19; g6 = ga20; g7 = ga21; g8 = ga22; 

            StartCoroutine(flip());
            StartCoroutine(gone());

        }

        if (activelevel ==14)
        {
            timebflip = 1.3f;
            othertimeflip = 1.3f;
            m1 = 0; e1 = 1;
            m2 = 3; e2 = 2;
            m3 = 4; e3 = 3;
            m4 = 5; e4 = 3;
            m5 = 2; e4 = 4;



            rend1 = l1.GetComponent<Renderer>();
            rend2 = l2.GetComponent<Renderer>();
            rend3 =mm1.GetComponent<Renderer>();
            rend4 =mm2.GetComponent<Renderer>();
            rend5 = n1.GetComponent<Renderer>();
            rend6 = n2.GetComponent<Renderer>();
            rend7 = o1.GetComponent<Renderer>();
            rend8 = o2.GetComponent<Renderer>();
            rend9 = q1.GetComponent<Renderer>();
            rend10 = q2.GetComponent<Renderer>();
            rend1.enabled = true; rend2.enabled = true; rend3.enabled = true; rend4.enabled = true; rend5.enabled = true; rend6.enabled = true; rend7.enabled = true; rend8.enabled = true; rend9.enabled = true; rend10.enabled = true;
            g1 = ga23; g2 = ga24; g3 = ga25; g4 = ga26; g5 = ga27; g6 = ga28; g7 = ga29; g8 = ga30; g9 = ga31; g10 = ga32;


            StartCoroutine(flip());
            StartCoroutine(gone());
        }
        if (activelevel == 15)
        {
            timebflip = 1.3f;
            othertimeflip = 1.3f;
            othertimeflip = 1.3f;
            m1 = 3; e1 = 0;
            m2 = 5; e1 = 1;
            m3 = 4; e1 = 5;
            m4 = 2; e4 = 3;
            m5 = 0; e5 = 2;

            rend1 = r1.GetComponent<Renderer>();
            rend2 = r2.GetComponent<Renderer>();
            rend3 = s1.GetComponent<Renderer>();
            rend4 = s2.GetComponent<Renderer>();
            rend5 = t1.GetComponent<Renderer>();
            rend6 = t2.GetComponent<Renderer>();
            rend7 = u1.GetComponent<Renderer>();
            rend8 = u2.GetComponent<Renderer>();
            rend9 = p1.GetComponent<Renderer>();
            rend10 = p2.GetComponent<Renderer>();



            rend1.enabled = true; rend2.enabled = true; rend3.enabled = true; rend4.enabled = true; rend5.enabled = true; rend6.enabled = true; rend7.enabled = true; rend8.enabled = true; rend9.enabled = true; rend10.enabled = true;
            g1 = ga33; g2 = ga34; g3 = ga35; g4 = ga36; g5 = ga37; g6 = ga38; g7 = ga39; g8 = ga40; g9 = ga41; g10 = ga42;
            StartCoroutine(flip());
            StartCoroutine(gone());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This one for color flipping 
    public IEnumerator flip()
    {
        yield return new WaitForSeconds(timebflip);
        if (rend1 != null) { rend1.transform.gameObject.tag = "TopRight"; rend1.sharedMaterial = material[m1]; }
       if (rend2 !=null) { rend2.transform.gameObject.tag = "Obstacle"; rend2.sharedMaterial = material[e1];}

        if (rend3 != null) { rend3.transform.gameObject.tag = "Obstacle"; rend3.sharedMaterial = material[e2]; }
        if (rend4 != null) { rend4.transform.gameObject.tag = "TopRight"; rend4.sharedMaterial = material[m2]; }

        if (rend5 != null) { rend5.transform.gameObject.tag = "Obstacle"; rend5.sharedMaterial = material[e3]; }
        if (rend6 != null) { rend6.transform.gameObject.tag = "TopRight"; rend6.sharedMaterial = material[m3]; }
       
        if (rend7 != null && rend8 != null) { rend7.transform.gameObject.tag = "Obstacle"; rend7.sharedMaterial = material[e4]; rend8.transform.gameObject.tag = "TopRight"; rend8.sharedMaterial = material[m4]; }
        if (rend9 != null && rend10!= null) { rend9.transform.gameObject.tag = "Obstacle"; rend9.sharedMaterial = material[e5]; rend10.transform.gameObject.tag = "TopRight"; rend10.sharedMaterial = material[m5]; }
        yield return new WaitForSeconds(timebflip);
        if (rend1 != null) { rend1.transform.gameObject.tag = "Obstacle"; rend1.sharedMaterial = material[e1]; }
        if (rend2 != null) { rend2.transform.gameObject.tag = "TopRight"; rend2.sharedMaterial = material[m1]; }

        if (rend4 != null) { rend4.transform.gameObject.tag = "Obstacle"; rend4.sharedMaterial = material[e2]; }
        if (rend3 != null) { rend3.transform.gameObject.tag = "TopRight"; rend3.sharedMaterial = material[m2]; }

        if (rend6 != null) { rend6.transform.gameObject.tag = "Obstacle"; rend6.sharedMaterial = material[e3]; }
        if (rend5 != null) { rend5.transform.gameObject.tag = "TopRight"; rend5.sharedMaterial = material[m3]; }

        if (rend7 != null && rend8 != null) { rend8.transform.gameObject.tag = "Obstacle"; rend8.sharedMaterial = material[e4]; rend7.transform.gameObject.tag = "TopRight"; rend7.sharedMaterial = material[m4]; }
        if (rend9 != null && rend10 != null) { rend10.transform.gameObject.tag = "Obstacle"; rend10.sharedMaterial = material[e5]; rend9.transform.gameObject.tag = "TopRight"; rend9.sharedMaterial = material[m5]; }

        StartCoroutine(flip());

    }
    //This one for setting not active 
    public IEnumerator gone()
    {
        yield return new WaitForSeconds(othertimeflip);
        if (g1 && g2 != null) { g1.SetActive(false); g2.SetActive(true); }
        if (g3 && g4 != null) { g3.SetActive(false); g4.SetActive(true); }
        if (g5 && g6 != null) { g5.SetActive(false); g6.SetActive(true); }
        if (g7 && g8 != null) { g7.SetActive(false); g8.SetActive(true); }
        if (g9 && g10!= null) { g9.SetActive(false); g10.SetActive(true); }
        

        yield return new WaitForSeconds(othertimeflip);
        if (g1 && g2 != null) { g1.SetActive(true); g2.SetActive(false); }
        if (g3 && g4 != null) { g4.SetActive(false); g3.SetActive(true); }
        if (g5 && g6 != null) { g6.SetActive(false); g5.SetActive(true); }
        if (g7 && g8 != null) { g8.SetActive(false); g7.SetActive(true); }
        if (g9 && g10 != null) { g10.SetActive(false); g9.SetActive(true); }
        StartCoroutine(gone());
    }
}
