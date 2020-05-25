using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour{

    public GameObject flashlight;
    public AudioClip audio;
    private AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)) {
            if(flashlight.activeSelf)
                flashlight.SetActive(false);
            else
                flashlight.SetActive(true);
            if (audioSource) audioSource.PlayOneShot(audio);
        }
    }
}
