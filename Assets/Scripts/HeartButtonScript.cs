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
            // if(heart.transform.localPosition.x == 0){
            //     heart.SetActive(false);
            //     heart.transform.localPosition = new Vector3(1.9915f, 1.1026f, 2.1344f);
            //     heart.transform.localScale = new Vector3(0.1206228f, 0.1206228f, 0.1206228f);
            // }
            // else{
            //     clear(heart);
            //     heart.transform.localPosition = new Vector3(0, 0, 0);
            //     heart.transform.localScale = new Vector3(0.24f, 0.24f, 0.24f);
            // }
        }
        else{
            heart.transform.localPosition = new Vector3(1.9915f, 1.1026f, 2.1344f);
            heart.transform.localScale = new Vector3(0.1206228f, 0.1206228f, 0.1206228f);
            heart.SetActive(true);
        }
    }

    public void OnMuscleButtonPressed(VirtualButtonBehaviour vb)
    {
        if(muscle.activeSelf){
            // if(muscle.transform.localPosition.x == 0){
            //     muscle.SetActive(false);
            //     muscle.transform.localPosition = new Vector3(1.81f, 3.09f, 0.04f);
            //     muscle.transform.localScale = new Vector3(0.51586f, 0.51586f, 0.51586f);
            // }
            // else{
            //     clear(muscle);
            //     muscle.transform.localPosition = new Vector3(0, 0, 0);
            //     muscle.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            // }
        }
        else{
            muscle.transform.localPosition = new Vector3(1.81f, 3.09f, 0.04f);
            muscle.transform.localScale = new Vector3(0.51586f, 0.51586f, 0.51586f);
            muscle.SetActive(true);
        }
    }

    public void OnSkullButtonPressed(VirtualButtonBehaviour vb)
    {
        if(skull.activeSelf){
            // if(skull.transform.localPosition.x == 0){
            //     skull.SetActive(false);
            //     skull.transform.localPosition = new Vector3(2.0759f, 0.23f, -1.84f);
            //     skull.transform.localScale = new Vector3(0.002014888f, 0.002014888f, 0.002014888f);
            // }
            // else{
            //     clear(skull);
            //     skull.transform.localPosition = new Vector3(0, 0, 0);
            //     skull.transform.localScale = new Vector3(0.004f, 0.004f, 0.004f);
            // }
        }
        else{
            skull.transform.localPosition = new Vector3(2.0759f, 0.23f, -1.84f);
            skull.transform.localScale = new Vector3(0.002014888f, 0.002014888f, 0.002014888f);
            skull.SetActive(true);
        }
    }

    public void OnLiverButtonPressed(VirtualButtonBehaviour vb)
    {
        if(liver.activeSelf){
            // if(liver.transform.localPosition.x == 0){
            //     liver.SetActive(false);
            //     liver.transform.localPosition = new Vector3(-0.12f, 0.97945f, 2.2086f);
            //     liver.transform.localScale = new Vector3(0.1388108f, 0.1388108f, 0.1388108f);
            // }
            // else{
            //     clear(liver);
            //     liver.transform.localPosition = new Vector3(0, 0, 0);
            //     liver.transform.localScale = new Vector3(0.26f, 0.26f, 0.26f);
            // }
        }
        else{
            liver.transform.localPosition = new Vector3(-0.12f, 0.97945f, 2.2086f);
            liver.transform.localScale = new Vector3(0.1388108f, 0.1388108f, 0.1388108f);
            liver.SetActive(true);
        }
    }

    public void OnLungsButtonPressed(VirtualButtonBehaviour vb)
    {
        if(lungs.activeSelf){
            // if(lungs.transform.localPosition.x == 0){
            //     lungs.SetActive(false);
            //     lungs.transform.localPosition = new Vector3(-0.18083f, 0.24f, -0.062879f);
            //     lungs.transform.localScale = new Vector3(0.24766f, 0.24766f, 0.24766f);
            // }
            // else{
            //     clear(lungs);
            //     lungs.transform.localPosition = new Vector3(0, 0, 0);
            //     lungs.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            // }
        }
        else{
            lungs.transform.localPosition = new Vector3(-0.18083f, 0.24f, -0.062879f);
            lungs.transform.localScale = new Vector3(0.24766f, 0.24766f, 0.24766f);
            lungs.SetActive(true);
        }
    }

    public void OnKidneyButtonPressed(VirtualButtonBehaviour vb)
    {
        if(kidney.activeSelf){
            // if(kidney.transform.localPosition.x == 0){
            //     kidney.SetActive(false);
            //     kidney.transform.localPosition = new Vector3(0.028064f, 0.82f, -2.4187f);
            //     kidney.transform.localScale = new Vector3(18.55055f, 18.55055f, 18.55055f);
            // }
            // else{
            //     clear(kidney);
            //     kidney.transform.localPosition = new Vector3(0, 0, 0);
            //     kidney.transform.localScale = new Vector3(37f, 37f, 37f);
            // }
        }
        else{
            kidney.transform.localPosition = new Vector3(0.028064f, 0.82f, -2.4187f);
            kidney.transform.localScale = new Vector3(18.55055f, 18.55055f, 18.55055f);
            kidney.SetActive(true);
        }
    }

    public void OnBrainButtonPressed(VirtualButtonBehaviour vb)
    {
        if(brain.activeSelf){
            // if(brain.transform.localPosition.x == 0){
            //     brain.SetActive(false);
            //     brain.transform.localPosition = new Vector3(-1.754f, 0.45f, 1.926318f);
            //     brain.transform.localScale = new Vector3(0.238095f, 0.238095f, 0.238095f);
            // }
            // else{
            //     clear(brain);
            //     brain.transform.localPosition = new Vector3(0, 0, 0);
            //     brain.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f);
            // }
        }
        else{
            brain.transform.localPosition = new Vector3(-1.754f, 0.45f, 1.926318f);
            brain.transform.localScale = new Vector3(0.238095f, 0.238095f, 0.238095f);
            brain.SetActive(true);
        }
    }

    public void OnUrinaryButtonPressed(VirtualButtonBehaviour vb)
    {
        if(urinary.activeSelf){
            // if(urinary.transform.localPosition.x == 0){
            //     urinary.SetActive(false);
            //     urinary.transform.localPosition = new Vector3(-1.82f, 0.69f, -0.01f);
            //     urinary.transform.localScale = new Vector3(0.1127399f, 0.1127399f, 0.1127399f);
            // }
            // else{
            //     clear(urinary);
            //     urinary.transform.localPosition = new Vector3(0, 0, 0);
            //     urinary.transform.localScale = new Vector3(0.22f, 0.22f, 0.22f);
            // }
        }
        else{
            urinary.transform.localPosition = new Vector3(-1.82f, 0.69f, -0.01f);
            urinary.transform.localScale = new Vector3(0.1127399f, 0.1127399f, 0.1127399f);
            urinary.SetActive(true);
        }
    }

    public void OnReproductButtonPressed(VirtualButtonBehaviour vb)
    {
        if(reproduct.activeSelf){
            // if(reproduct.transform.localPosition.x == 0){
            //     reproduct.SetActive(false);
            //     reproduct.transform.localPosition = new Vector3(-1.19f, 0.6808212f, -3.73f);
            //     reproduct.transform.localScale = new Vector3(0.44586f, 0.44586f, 0.44586f);
            // }
            // else{
            //     clear(reproduct);
            //     reproduct.transform.localPosition = new Vector3(0, 0, 0);
            //     reproduct.transform.localScale = new Vector3(0.88f, 0.88f, 0.88f);
            // }
        }
        else{
            reproduct.transform.localPosition = new Vector3(-1.19f, 0.6808212f, -3.73f);
            reproduct.transform.localScale = new Vector3(0.44586f, 0.44586f, 0.44586f);
            reproduct.SetActive(true);
        }
    }

    public void clear(GameObject gameObject){
        GameObject[] gameObjectList = {heart, muscle, skull, liver, lungs, kidney, brain, urinary, reproduct};
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