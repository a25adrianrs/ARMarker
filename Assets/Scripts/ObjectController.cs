using System;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    //  El meotodo RotateLeft, RotateRight, PopUp, PlayAudio, MoveUp y MoveDown deben encontrar los objetos 
    //con el tag "modelObject" y realizar las siguientes acciones:
    public void RotateLeft()
    {

        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, 15, 0);
        }
    }

    // El moetodo RotateRight es similar a RotateLeft pero con un valor negativo para rotar en sentido contrario

    public void RotateRight()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, -15, 0);
        }
    }

    // El metodo PopUp debe encontrar los objetos con el tag "infoLemon" y activar o desactivar el 
    // componente Canvas para mostrar u ocultar la información adicional sobre el limón.
    public void PopUp()
    {
        // findobjects with tag "infoLemon"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("infoLemon");

        foreach (GameObject obj in objects)
        {

            Canvas canvas = obj.GetComponent<Canvas>();

            if (canvas != null)
            {
                Debug.Log(canvas);
                canvas.enabled = !canvas.enabled;
            }
        }
    }


    // El metodo PlayAudio debe encontrar los objetos con el tag "infoAudio" y 
    // reproducir o pausar el audio asociado a cada objeto.
    public void PlayAudio()
    {
        // findobjects with tag "infoAudio"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("infoAudio");

        foreach (GameObject obj in objects)
        {
            AudioSource audioSource = obj.GetComponentInChildren<AudioSource>();
            if (audioSource != null)
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause();
                }
                else
                {
                    audioSource.Play();
                }
            }
        }
    }

    // El metodo MoveUp debe encontrar los objetos con el tag "modelObject" 
    //y moverlos hacia arriba en el eje Y, mientras que el metodo MoveDown debe moverlos hacia abajo en el mismo eje.
    public void MoveUp()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Translate(0, 0.05f, 0, Space.Self);
        }
    }

    // El metodo MoveUp debe encontrar los objetos con el tag "modelObject" 
    //y moverlos hacia arriba en el eje Y, mientras que el metodo MoveDown debe moverlos hacia abajo en el mismo eje.
    public void MoveDown()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Translate(0, -0.05f, 0, Space.Self);
        }
    }
}
