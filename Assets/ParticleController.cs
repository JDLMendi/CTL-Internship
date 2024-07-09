using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    private ParticleSystem.Particle[] particles;
    private Vent[] vents;

    void Start()
    {
        if (particleSystem == null)
        {
            particleSystem = GetComponent<ParticleSystem>();
        }

        particles = new ParticleSystem.Particle[particleSystem.main.maxParticles];
    }

    void Update()
    {
        if (vents == null)
        {
            vents = FindObjectsOfType<Vent>();
        }

        if (vents.Length == 0)
        {
            return;
        }

        int particleCount = particleSystem.GetParticles(particles);

        for (int i = 0; i < particleCount; i++)
        {
            Vector3 particlePosition = particles[i].position;
            Vent nearestVent = FindNearestVentConsideringPower(particlePosition);

            if (nearestVent != null)
            {
                Vector3 directionToVent = (nearestVent.transform.position - particlePosition).normalized;
                float attractionSpeed = 1.5f; // Increase this value to make the effect more noticeable

                // Debugging the direction
                Debug.DrawLine(particlePosition, nearestVent.transform.position, Color.red, 0.1f);
                Debug.Log("Direction to Vent: " + directionToVent);

                particles[i].velocity = directionToVent * attractionSpeed;
            }
        }

        particleSystem.SetParticles(particles, particleCount);
    }

    Vent FindNearestVentConsideringPower(Vector3 particlePosition)
    {
        Vent bestVent = null;
        float bestScore = float.MinValue;

        foreach (Vent vent in vents)
        {
            float distance = Vector3.Distance(particlePosition, vent.transform.position);
            float score = vent.power / (distance + 0.1f); // Adding a small constant to avoid division by zero

            if (score > bestScore)
            {
                bestScore = score;
                bestVent = vent;
            }
        }

        return bestVent;
    }
}
