using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerOpen : MonoBehaviour
{
    [SerializeField]Material m_Material;
    int EdgeOnID=Shader.PropertyToID("EdgeOn");
    [SerializeField]float timer=0;
    [SerializeField]float openTime=0.5f;
    [SerializeField]float stayTime=1.5f;
    float countSmooth;
    // Start is called before the first frame update
    void Start()
    {
        m_Material.SetFloat(EdgeOnID,0);
        Debug.Log("start");
        timer=0;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        float colseTime=openTime+stayTime;
        if(timer>colseTime){
            m_Material.SetFloat(EdgeOnID,0);
        }
        else if(timer>openTime){
            m_Material.SetFloat(EdgeOnID,1);
        }
       
    }
    // void OnTriggerEnter(Collider other) {
    //     m_Material.SetFloat(EdgeOnID,1);
    //     Debug.Log("hit");
        
    // }
}
