using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UntiyAdsScript : MonoBehaviour, IUnityAdsListener
{
    // Start is called before the first frame update

    string myPlacementId = "rewardedVideo";
    bool testMode = false;
    public int watched;
    public GameObject theui;
    public GameObject mainplayer;
    public GameObject secondchanceui; //UI for second chance crap
    public GameObject otherui;
    private int secondchanceint;
    void Start() //Make sure this number stuff right && testmode shit

    {
        secondchanceint = PlayerPrefs.GetInt("amountlives");
        watched = 0;
        Advertisement.AddListener(this);
        Advertisement.Initialize("3740960", testMode);
    }

    public void ShowAd()
    {
        if (otherui != null)
        {
            otherui.SetActive(false);
        }
        if (Advertisement.IsReady(myPlacementId)) ;
        {
            Advertisement.Show(myPlacementId);
        }
    }


    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {

            Debug.Log("Finished");
            //Insert mainplayer and get componet and create a bool value in the other script so then it sets active and boom only sus if this gets called when ad is finished but not when user closes it if thats case might need extra gui
        
            if (secondchanceui != null && theui.activeSelf==false)
            {
                secondchanceint = 1;
                PlayerPrefs.SetInt("amountlives", secondchanceint);
                secondchanceui.SetActive(true);
            }


            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped && theui!=null &&theui.activeSelf==false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        //This for the bs script to work leave empty
    }
    public void OnUnityAdsDidError(string message)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }


    // Update is called once per frame
    void Update()
    {

    }
}
