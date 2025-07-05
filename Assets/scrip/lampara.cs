using UnityEngine;

public class lampara : MonoBehaviour
{
    public Light luz;
    public ParticleSystem particulas;
    public Transform camara;

    private bool activa = false;

    void Start()
    {
        if (luz != null) luz.enabled = false;
        if (particulas != null) particulas.Stop();

        if (camara == null)
            camara = Camera.main.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            activa = !activa;

            if (luz != null)
                luz.enabled = activa;

            if (particulas != null)
            {
                if (activa)
                    particulas.Play();
                else
                    particulas.Stop();
            }
        }

        if (activa && luz != null && camara != null)
        {
            luz.transform.position = camara.position;
            luz.transform.rotation = camara.rotation;
        }
    }
}
