using UnityEngine;

public class Animation : MonoBehaviour
{
    // Variable para controlar la velocidad de aparición del gameObject
    public float appearSpeed = 2f;

    // Variable para controlar si el gameObject está apareciendo o no
    private bool appearing = true;

    void Start()
    {
        // Inicialmente, el gameObject está invisible
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        // animar aparición
        if (appearing)
        {
            //  Interpolar la escala del objeto hacia su tamaño original (Vector3.one)
            // Vector3.One representa la escala original del objeto (1, 1, 1)
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, Time.deltaTime * appearSpeed);

            // Si la escala se acerca lo suficiente a su tamaño original, detener la animación
            if (transform.localScale.x > 0.95f)
            {
                // Aeguramos que la escala final sea exactamente la original
                transform.localScale = Vector3.one;
                appearing = false;
            }
        }
    }
}
