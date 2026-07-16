using UnityEngine;

public class ZonaSegura : MonoBehaviour
{
    public AudioSource alarma;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            alarma.Stop();
            Debug.Log("Evacuación completada");
        }
    
}
}