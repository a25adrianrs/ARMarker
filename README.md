# AR MARKER

Para el ejercicio use el prefab de **Lemon** que ya estaba dentro del proyecto.

- Añadi los dos botones **Up** y **Down** tal y como se pide en el ejercicio que hace que el prefab Suba y Baje en la aplicación.
- En cuanto a la mejora :
    - Cree un nuevo script que se llama **Animation** y se lo asigne al prefab ***"Lemon"*** que hace que cuando se ejecuta el juego el prefab **aparezca como si creciese desde un tamaño minusculo hasta su tamaño normal predefinido con una velocidad de crecimientro predefinida** a diferencia de cuando se instancia normalmente que parece que se **aparezca instantaneamente**.

```csharp
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

            // Si la escala se acerca lo suficiente a su tamaño original, detiene la animación
            if (transform.localScale.x > 0.95f)
            {
                // Aseguramos que la escala final sea exactamente la original
                transform.localScale = Vector3.one;
                appearing = false;
            }
        }
    }
}```
