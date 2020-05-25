using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour{

    public GameObject light;
    private Light lgt;

    void Start(){
        lgt = light.GetComponent<Light>();
    }

    void Update(){
        if (light.activeSelf)
            lgt.intensity = Mathf.Abs(Mathf.Sin(Time.time*2));
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            light.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            light.SetActive(false);
        }
    }
}
