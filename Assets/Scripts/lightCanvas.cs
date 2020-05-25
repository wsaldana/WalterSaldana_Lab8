using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lightCanvas : MonoBehaviour{

    private string[] tags;
    public Canvas canvas;
    public Text text;

    void Start() {
        tags = new string[]{ "TV", "Mueble", "Mesa", "Sofa", "Refrigerador", "Estufa", "Comedor", "Silla"};
    }


    void Update(){
        Ray ray = gameObject.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            string hitcollider = hit.collider.gameObject.tag;
            if ((hitcollider == tags[0]) ||
                (hitcollider == tags[1]) ||
                (hitcollider == tags[2]) ||
                (hitcollider == tags[3]) ||
                (hitcollider == tags[4]) ||
                (hitcollider == tags[5]) ||
                (hitcollider == tags[6]) ||
                (hitcollider == tags[7]) ) {

                Debug.Log(hitcollider);
                if (canvas) canvas.enabled = true;
                text.text = hitcollider;
            } else {
                if (canvas) canvas.enabled = false;
            }
        }
        
    }
}
