using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HeartButtonScript : MonoBehaviour
{
    public GameObject heart, muscle, skull, liver, lungs, kidney, brain, urinary, reproduct, heartButton, muscleButton, skullButton, liverButton, lungsButton, kidneyButton, brainButton, urinaryButton, reproductButton;

    void Start()
    {
        heartButton = GameObject.Find("HeartButton");
        muscleButton = GameObject.Find("MuscleButton");
        skullButton = GameObject.Find("SkullButton");
        liverButton = GameObject.Find("LiverButton");
        lungsButton = GameObject.Find("LungsButton");
        kidneyButton = GameObject.Find("KidneyButton");
        brainButton = GameObject.Find("BrainButton");
        urinaryButton = GameObject.Find("UrinaryButton");
        reproductButton = GameObject.Find("ReproductButton");   
        heartButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnHeartButtonPressed);
        muscleButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnMuscleButtonPressed);
        skullButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnSkullButtonPressed);
        liverButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnLiverButtonPressed);
        lungsButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnLungsButtonPressed);
        kidneyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnKidneyButtonPressed);
        brainButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnBrainButtonPressed);
        urinaryButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnUrinaryButtonPressed);
        reproductButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnReproductButtonPressed);

        heart.SetActive(false);
        muscle.SetActive(false);
        skull.SetActive(false);
        liver.SetActive(false);
        lungs.SetActive(false);
        kidney.SetActive(false);
        brain.SetActive(false);
        urinary.SetActive(false);
        reproduct.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnHeartButtonPressed(VirtualButtonBehaviour vb)
    {
        if(heart.activeSelf){
            heart.SetActive(false);
        }
        else{
            heart.SetActive(true);
        }
    }

    public void OnMuscleButtonPressed(VirtualButtonBehaviour vb)
    {
        if(muscle.activeSelf){
            muscle.SetActive(false);
        }
        else{
            muscle.SetActive(true);
        }
    }

    public void OnSkullButtonPressed(VirtualButtonBehaviour vb)
    {
        if(skull.activeSelf){
            skull.SetActive(false);
        }
        else{
            skull.SetActive(true);
        }
    }

    public void OnLiverButtonPressed(VirtualButtonBehaviour vb)
    {
        if(liver.activeSelf){
            liver.SetActive(false);
        }
        else{
            liver.SetActive(true);
        }
    }

    public void OnLungsButtonPressed(VirtualButtonBehaviour vb)
    {
        if(lungs.activeSelf){
            lungs.SetActive(false);
        }
        else{
            lungs.SetActive(true);
        }
    }

    public void OnKidneyButtonPressed(VirtualButtonBehaviour vb)
    {
        if(kidney.activeSelf){
            kidney.SetActive(false);
        }
        else{
            kidney.SetActive(true);
        }
    }

    public void OnBrainButtonPressed(VirtualButtonBehaviour vb)
    {
        if(brain.activeSelf){
            brain.SetActive(false);
        }
        else{
            brain.SetActive(true);
        }
    }

    public void OnUrinaryButtonPressed(VirtualButtonBehaviour vb)
    {
        if(urinary.activeSelf){
            urinary.SetActive(false);
        }
        else{
            urinary.SetActive(true);
        }
    }

    public void OnReproductButtonPressed(VirtualButtonBehaviour vb)
    {
        if(reproduct.activeSelf){
            reproduct.SetActive(false);
        }
        else{
            reproduct.SetActive(true);
        }
    }
}