using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    public Material[] material;
    Renderer rendm;
    public bool GameActive;
    private Vector3 Cords = new Vector3(0, 0, 0);
    public float speed = 5;
    public float speedtrack;
    private float xx;
    private float xz;
    private float xy;
    private Vector3 hitdv;
    private Vector3 screenBounds;
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    public float vy;
    public float vx;
    private Vector3 stuter;
    public Text scoretext;
    private int n;
    private GameObject g;
    private GameObject x;
    public bool tr;     //This for the color changing thing to tell what it is
    public bool tl;
    public bool br;
    public bool bl;
    public int score;
    public GameObject me;
    public int randomnum; //this # for changer call
    public Material[] Skyboxes;
    public GameObject watchad;
    private int alreadywatched;
    public Text countdow;
    private int countdownnum = 5;
    public GameObject endcan;
    private int activelevel;
    private int levelsunlocked;
    private int whenuwatchedad;
    public GameObject wincanvas;
    public GameObject canforsecondlive;
    public GameObject gameobjforads;
    public GameObject startlevelcan;
    public Text whatlevel;
    public Text uwondislevel;
    public GameObject displaylevelcan;
    private int secondchanceint;
    private bool wasjusthit;
    public GameObject controlscan;
    public GameObject supermaincan;
    private int a; //This just extra detail for when colors change

    //This area arranges where you start based on levels
    void Awake()
    {
        secondchanceint = PlayerPrefs.GetInt("amountlives");
        activelevel = PlayerPrefs.GetInt("activelevel");
        levelsunlocked = PlayerPrefs.GetInt("levelsunlocked");
        whenuwatchedad = PlayerPrefs.GetInt("watchedadtrack");

        if (activelevel == 1)
        {
            RenderSettings.skybox = Skyboxes[0];
            transform.position = new Vector3(0, 50080, 0);
            speedtrack = 25;
            supermaincan.SetActive(false);
            controlscan.SetActive(true);
            //   PlayerPrefs.SetInt("highscore", ourscore);
        }

        if (activelevel == 2)
        {
            RenderSettings.skybox = Skyboxes[0];
            speedtrack = 30;
            transform.position = new Vector3(0, 49560, 0);
        }

        if (activelevel == 3)
        {
            RenderSettings.skybox = Skyboxes[0];
            speedtrack = 30;
            transform.position = new Vector3(0, 48972, 0);
        }

        if (activelevel == 4)
        {
            RenderSettings.skybox = Skyboxes[0];
            speedtrack = 30;
            transform.position = new Vector3(0, 48336, 0);
        }
        if (activelevel == 5)
        {
            RenderSettings.skybox = Skyboxes[0];
            speedtrack = 30;
            transform.position = new Vector3(0, 47654, 0);
        }
        if (activelevel == 6)
        {
            RenderSettings.skybox = Skyboxes[1];
            speedtrack = 30;
            transform.position = new Vector3(0, 46826, 0);
        }
        if (activelevel == 7)
        {
            RenderSettings.skybox = Skyboxes[1];
            speedtrack = 30;
            transform.position = new Vector3(0, 46056, 0);
        }
        if (activelevel == 8)
        {
            RenderSettings.skybox = Skyboxes[1];
            speedtrack = 30;
            transform.position = new Vector3(0, 45306, 0);
        }
        if (activelevel == 9)
        {
            RenderSettings.skybox = Skyboxes[1];
            speedtrack = 30;
            transform.position = new Vector3(0, 44500, 0);
        }
        if (activelevel == 10)
        {
            RenderSettings.skybox = Skyboxes[1];
            speedtrack = 30;
            transform.position = new Vector3(0, 43602, 0);
        }
        if (activelevel == 11)
        {
            RenderSettings.skybox = Skyboxes[2];
            speedtrack = 24;
            transform.position = new Vector3(0, 42676, 0);
        }
        if (activelevel == 12)
        { 
        RenderSettings.skybox = Skyboxes[2];
            speedtrack = 24;
        transform.position = new Vector3(0, 42206, 0);
    }
        if (activelevel == 13)
        {
            RenderSettings.skybox = Skyboxes[2];
            speedtrack = 24;
            transform.position = new Vector3(0, 41636, 0);
        }
        if (activelevel == 14)
        {
            RenderSettings.skybox = Skyboxes[2];
            speedtrack = 24;
            transform.position = new Vector3(0, 40916, 0);
        }
        if (activelevel == 15)
        {
            RenderSettings.skybox = Skyboxes[2];
            speedtrack = 24;
            transform.position = new Vector3(0, 40102, 0);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        whatlevel.text = activelevel.ToString();
        uwondislevel.text = activelevel.ToString();
        alreadywatched = 0;
        rendm = me.GetComponent<Renderer>();
        rendm.enabled = true;
        Physics.gravity = new Vector3(0, -400, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    public void firsttime()
    {
        controlscan.SetActive(false);
        supermaincan.SetActive(true);

    }
    

    public void Up()
    {
        down = false;
        if (up == true)
        {

            up = false;
            xz = transform.position.z;
        }
        else
        {
    
            up = true;
        }




    }

    public void startthelevel()
    {
  
        speed = speedtrack;
        GameActive = true;
        startlevelcan.SetActive(false);
    }

    public void secondlive()
    {
  
        if (x != null)
        {
   
            wasjusthit = true;
            Destroy(x);
            speed = speedtrack;
            canforsecondlive.SetActive(false);
            me.GetComponent<Rigidbody>().isKinematic = true;
            GameActive = false;
            StartCoroutine(secondcount());
        }
        else
        {
            wasjusthit = true;
            speed = speedtrack;
            canforsecondlive.SetActive(false);
            me.GetComponent<Rigidbody>().isKinematic = true;
            GameActive = false;
            StartCoroutine(secondcount());


        }
       
    }
    //

    IEnumerator secondcount()
    {
        yield return new WaitForSeconds(0.05f);
        me.GetComponent<Rigidbody>().isKinematic = false;
        GameActive = true;
        yield return new WaitForSeconds(1);
        wasjusthit = false;

    }

    public IEnumerator Changer()
    {
        a = Random.Range(0, 2);
        rendm.sharedMaterial = material[0];
        yield return new WaitForSeconds(0.1f);
        rendm.sharedMaterial = material[1];
        yield return new WaitForSeconds(0.1f);
        rendm.sharedMaterial = material[3];
        yield return new WaitForSeconds(0.1f);
        rendm.sharedMaterial = material[4];
        yield return new WaitForSeconds(0.1f);
        if (randomnum ==1)
        {
            rendm.sharedMaterial = material[0];
        }
        if (randomnum ==2)
        {
            rendm.sharedMaterial = material[1];
        }
        if(randomnum ==3)
        {
            rendm.sharedMaterial = material[2];
        }
        if(randomnum==4)
        {
            rendm.sharedMaterial = material[3];
        }
        if(randomnum==5)
        {
            rendm.sharedMaterial = material[4];
        }
        if (randomnum == 6)
        {
            rendm.sharedMaterial = material[5];
        }
    }
    public IEnumerator Fall()
    {
        yield return new WaitForSeconds(1);
        if (g != null)
        {
            Destroy(g);
            me.GetComponent<Rigidbody>().isKinematic = true;
            me.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    //This the coutndown for the ad screen
    public IEnumerator CountDown()
    {
        countdownnum = 5;
        countdow.text = countdownnum.ToString(); 
        yield return new WaitForSeconds(1);
        countdownnum = 4;
        countdow.text = countdownnum.ToString();
        yield return new WaitForSeconds(1);
        countdownnum = 3;
        countdow.text = countdownnum.ToString();
        yield return new WaitForSeconds(1);
        countdownnum = 2;
        countdow.text = countdownnum.ToString();
        yield return new WaitForSeconds(1);
        countdownnum = 1;
        countdow.text = countdownnum.ToString();
        yield return new WaitForSeconds(1);
        countdownnum = 0;
        countdow.text = countdownnum.ToString();
        if (watchad.activeSelf == true)
        {
          
            watchad.SetActive(false);
            endcan.SetActive(true);
        }
       
       
       
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        activelevel = activelevel + 1;
         PlayerPrefs.SetInt("activelevel", activelevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    //Fix this once you start working on other scene 
    public void gohome()
    {

        SceneManager.LoadScene("MainMenu");
    }
    public void Down()
    {
        up = false;
        if (down == true)
        {
            down = false;
            xz = transform.position.z;
        }
        else
        {
            down = true;

        }
    }
    public void Right()
    {
        left = false;
        if (right == true)
        {
            right = false;
            xx = transform.position.x;
        }
        else
        {
            right = true;
        }


    }

    public void Left()
    {
        right = false;
        if (left == true)
        {
            left = false;
            xx = transform.position.x;
        }
        else
        {
            left = true;
        }
    }

   
    void FixedUpdate()
    {

        //Checks to make sure in boundaries
        if (xz > 2.8001f)
        {
            xz = 2.8f;
        }
        if (xz < -2.8f)
        {
            xz = -2.8f;
        }
        if (xx > 1.3f)
        {
            xx = 1.3f;
        }
        if (xx < -1.3f)
        {
            xx = -1.3f;
        }
        if (up == true && xz < 2.8f)
        {
            xz = transform.position.z;
            xz = vy + xz;
            xy = transform.position.y;
            xy = xy - 5;

        }

        if (down == true && xz > -2.8f)
        {
            xz = transform.position.z;
            xz = xz - vy;
            xy = transform.position.y;
            xy = xy - 5;
        }
        if (right == true && xx < 1.3f)
        {
            xx = transform.position.x;
            xx = vx + xx;
            xy = transform.position.y;
            xy = xy - 5;
        }
        if (left == true && xx > -1.3f)
        {
            xx = transform.position.x;
            xx = xx - vx;
            xy = transform.position.y;
            xy = xy - 5;

        }
        float xt = transform.position.x;
        float zt = transform.position.z;
        float xb = xy + 0.2f;
        if (transform.position.y < xb)
        {

            xy = 0;
            Cords = new Vector3(xx, xy, xz);
        }
        Cords = new Vector3(xx, xy, xz);
        transform.position = Vector3.MoveTowards(transform.position, Cords, Time.deltaTime * speed);


    }

    public void GameOver()
    {
       
        speedtrack = speed;
        speed = 0;
        if (alreadywatched == 0 && GameActive == true)
        {
            if (secondchanceint ==1)
            {
                GameActive = false;
                secondchanceint = 0;
                canforsecondlive.SetActive(true);
                PlayerPrefs.SetInt("amountlives", secondchanceint);

                alreadywatched = 1;
            }
            else
            {
                GameActive = false;
                alreadywatched = 1;
                watchad.SetActive(true);
                StartCoroutine(CountDown());
            }
        
        }
        if (alreadywatched ==1 && GameActive ==true)
        {
            GameActive = false;
            watchad.SetActive(false);
            endcan.SetActive(true);

        }


    }
    void OnCollisionEnter(Collision collisionInfo)
    {
       
        if (collisionInfo.collider.tag == "TopLeft" && GameActive == true && wasjusthit == false)
        {
            if(tl==true)
            {
                g = collisionInfo.gameObject;
                collisionInfo.gameObject.GetComponent<MeshCollider>().enabled = false;
                collisionInfo.gameObject.GetComponent<Rigidbody>().isKinematic = false;
               
                StartCoroutine(Fall());
             
            }
            else
            {
                x = collisionInfo.gameObject;
                GameOver();
            }



        }
        if (collisionInfo.collider.tag == "DownRight" && GameActive == true && wasjusthit ==false)
        {
            if (br==true)
            {
                g = collisionInfo.gameObject;
                collisionInfo.gameObject.GetComponent<MeshCollider>().enabled = false;
                collisionInfo.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                score = score + 1;
                StartCoroutine(Fall());
            }
            else
            {
                x = collisionInfo.gameObject;
                GameOver();
              
            }

         



        }
        if (collisionInfo.collider.tag == "Obstacle" && GameActive == true && wasjusthit== false)
        {
                if (tl == false)
                {
                x = collisionInfo.gameObject;
                    GameOver();
                }


        }
        if (collisionInfo.collider.tag == "DownLeft" && GameActive == true && wasjusthit == false)
        {
            if (bl==true)
            {
                g = collisionInfo.gameObject;
                collisionInfo.gameObject.GetComponent<MeshCollider>().enabled = false;
                collisionInfo.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                score = score + 1;
                StartCoroutine(Fall());
            }
            else
            {
                x = collisionInfo.gameObject;
                GameOver();
                
            }
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        //This way ball doesn't get blocked because of it
        if (other.gameObject.tag == "TopRight" && GameActive == true)
        {
            if (tr == true)
            {

                g = other.gameObject;
                g.GetComponent<MeshCollider>().enabled = false;
                g.GetComponent<Rigidbody>().isKinematic = false;
                score = score + 1;

            
                StartCoroutine(Fall());

            }
            else
            {
                GameOver();
            }
        }
        if (other.gameObject.tag == "Obstacle" || other.gameObject.tag == "TopLeft" || other.gameObject.tag == "DownLeft" || other.gameObject.tag=="DownRight" && GameActive == true && wasjusthit ==false)
        {
         
            if (tl ==false)
            {
                x = other.gameObject;
                GameOver();
            }


        }

            if (other.gameObject.tag =="changer1" && GameActive ==true)
        {
            randomnum = 1;
            tr = true;
            StartCoroutine(Changer());
        }
        if (other.gameObject.tag == "changer2" && GameActive == true)
        {
            randomnum = 2;
            StartCoroutine(Changer());
            tr = true;
        }
        if (other.gameObject.tag == "changer3" && GameActive == true)
        {
            randomnum = 3;
            StartCoroutine(Changer());
            tr = true;
        }
        if (other.gameObject.tag == "changer4" && GameActive == true)
        {
            randomnum = 4;
            StartCoroutine(Changer());
            tr = true;
        }
        if (other.gameObject.tag == "changer5" && GameActive == true)
        {
            randomnum = 5;
            StartCoroutine(Changer());
            tr = true;
        }
        if (other.gameObject.tag == "changer6" && GameActive == true)
        {
            randomnum = 6;
            StartCoroutine(Changer());
            tr = true;
        }


        if (other.gameObject.tag=="youwon" && GameActive == true)
        {
            speed = 0;
            wincanvas.SetActive(true);
            GameActive = false;
            whenuwatchedad = whenuwatchedad + 1;
            PlayerPrefs.SetInt("watchedadtrack", whenuwatchedad);
            displaylevelcan.SetActive(false);
            if (levelsunlocked == activelevel)
            {
                levelsunlocked = levelsunlocked + 1;
                PlayerPrefs.SetInt("levelsunlocked", levelsunlocked);
            }       
            if (whenuwatchedad>=2)
            {
                gameobjforads.GetComponent<regvideoads>().ShowInterstitialAd();
              
                whenuwatchedad = 0;
                PlayerPrefs.SetInt("watchedadtrack", whenuwatchedad);
            }
           
        }
    }
}



