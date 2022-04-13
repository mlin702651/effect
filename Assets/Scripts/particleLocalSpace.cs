using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleLocalSpace : MonoBehaviour
{
    ParticleSystem part;
    bool useLocal = true;
    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<ParticleSystem> ();
        useLocal = (part.simulationSpace == ParticleSystemSimulationSpace.Local);
    }

    // Update is called once per frame
    void Update()
    {
       part.simulationSpace = (useLocal ? ParticleSystemSimulationSpace.Local : ParticleSystemSimulationSpace.World);
    }
    void OnGUI()
    {
        useLocal = GUI.Toggle(new Rect(10, 60, 200, 30), useLocal, " Use Local Simulation Space");
    }
}
