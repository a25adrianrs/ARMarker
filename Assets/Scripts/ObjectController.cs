using System;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public void RotateLeft()
    {

        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, 15, 0);
        }
    }

    public void RotateRight()
    {
        // findobjects with tag "modelObject"
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Rotate(0, -15, 0);
        }
    }

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

    public void MoveUp()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Translate(0, 0.05f, 0, Space.Self);
        }
    }

    public void MoveDown()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("modelObject");

        foreach (GameObject obj in objects)
        {
            obj.transform.Translate(0, -0.05f, 0, Space.Self);
        }
    }
}
