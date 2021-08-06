using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HumanBodyScript : MonoBehaviour
{
    public GameObject heartBody, muscleBody, liverBody, lungsBody, kidneyBody, brainBody, urinaryBody, reproductBody, heartBodyButton, muscleBodyButton, liverBodyButton, lungsBodyButton, kidneyBodyButton, brainBodyButton, urinaryBodyButton, reproductBodyButton;
    void Start()
    {
        heartBodyButton = GameObject.Find("HeartBodyButton");
        muscleBodyButton = GameObject.Find("MuscleBodyButton");
        liverBodyButton = GameObject.Find("LiverBodyButton");
        lungsBodyButton = GameObject.Find("LungsBodyButton");
        kidneyBodyButton = GameObject.Find("KidneyBodyButton");
        brainBodyButton = GameObject.Find("BrainBodyButton");
        urinaryBodyButton = GameObject.Find("UrinaryBodyButton");
        reproductBodyButton = GameObject.Find("ReproductBodyButton");
        heartBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnHeartBodyButtonPressed);
        muscleBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnMuscleBodyButtonPressed);
        liverBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnLiverBodyButtonPressed);
        lungsBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnLungsBodyButtonPressed);
        kidneyBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnKidneyBodyButtonPressed);
        brainBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnBrainBodyButtonPressed);
        urinaryBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnUrinaryBodyButtonPressed);
        reproductBodyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnReproductBodyButtonPressed);

        heartBody.SetActive(false);
        muscleBody.SetActive(false);
        liverBody.SetActive(false);
        lungsBody.SetActive(false);
        kidneyBody.SetActive(true);
        brainBody.SetActive(false);
        urinaryBody.SetActive(false);
        reproductBody.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnHeartBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(heartBody);
        heartBody.SetActive(true);
    }

    public void OnMuscleBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(muscleBody);
        muscleBody.SetActive(true);
    }

    public void OnLiverBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(liverBody);
        liverBody.SetActive(true);
    }

    public void OnLungsBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(lungsBody);
        lungsBody.SetActive(true);
    }

    public void OnKidneyBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(kidneyBody);
        kidneyBody.SetActive(true);
    }

    public void OnBrainBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(brainBody);
        brainBody.SetActive(true);
    }

    public void OnUrinaryBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(urinaryBody);
        urinaryBody.SetActive(true);
    }

    public void OnReproductBodyButtonPressed(VirtualButtonBehaviour vb)
    {
        clear(reproductBody);
        reproductBody.SetActive(true);
    }

    public void clear(GameObject gameObject){
        GameObject[] gameObjectList = {heartBody, muscleBody, liverBody, lungsBody, kidneyBody, brainBody, urinaryBody, reproductBody};
        foreach (GameObject item in gameObjectList)
        {   
            if(GameObject.ReferenceEquals(item, gameObject)){
                Debug.Log(item);
            }
            else{
                item.SetActive(false);
            }
        }
    }
}