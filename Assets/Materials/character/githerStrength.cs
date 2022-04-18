using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class githerStrength : MonoBehaviour
{
    [SerializeField] Material material;
    float amount=0;
    float randomValue=0;
    [SerializeField]float strengh=0.2f;
    [SerializeField]float githerTime=0.5f;
    // Start is called before the first frame update
    float timer=0;
    float githerTimer=0;
    float interval;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("_GlitchStrength", amount);
        timer+=Time.deltaTime;

        if(timer>interval){
            amount=strengh;
            timer=0;
            interval=Random.Range(1,3);
        }
        else{
            githerTimer+=Time.deltaTime;
        }

        if(githerTimer>githerTime){
            amount=0;
            githerTimer=0;
        }
        
        Debug.Log(randomValue);
    }
}
