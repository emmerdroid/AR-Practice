using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    [SerializeField] ParticleSystem particleSys;
    [SerializeField] GameObject particleMesh;
    // Start is called before the first frame update
    void Start()
    {
        particleSys = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSys.particleCount];
        int particleSum = particleSys.GetParticles(particles);

        for(int i = 0; i<particleSum; i++)
        {
            Vector3 particlePosition = particles[i].position;
            Quaternion particleRotation = Quaternion.Euler(particles[i].rotation3D);
            Instantiate(particleMesh, particlePosition, particleRotation);
        }
    }
}
