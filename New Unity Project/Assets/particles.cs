
using UnityEngine;

public class particles : MonoBehaviour
{
    public ParticleSystem aParticles;
    public float value = 3f; 
    
    public void UpdateValue(float amount)

        {

            value += amount;

        }

        private void OnTriggerEnter(Collider other)

        {

            if (other.CompareTag("Player2"))

            {

            }



            aParticles.Emit(540);

        }


    }
