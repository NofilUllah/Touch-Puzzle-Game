using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  puzzlecontroller: MonoBehaviour
{
    public AudioClip click;
    private AudioSource click1;
    private void Start()
    {
        click1 = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        if (!gameControl.youwin)
        {
            transform.Rotate(0f, 0f, 90f);
            click1.PlayOneShot(click, 1.0F);
        }
       
    }
}
