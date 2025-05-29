using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    private GameObject wintext;
    public static bool youwin;

    void Start()
    {
        wintext.SetActive(false);
        youwin = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (
        //    pictures[0].rotation.z == 0 &&
        //    pictures[1].rotation.z == 0 &&
        //    pictures[2].rotation.z == 0 &&
        //    pictures[3].rotation.z == 0 && 
        //    pictures[4].rotation.z == 0 && 
        //    pictures[5].rotation.z == 0 
        //    )
        //{
        //    youwin = true;
        //    wintext.SetActive(true);

        //}
        CheckPuzzle();
        
    }
    public void CheckPuzzle()
    {
        if (
            pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0
            )
        {
            youwin = true;
            wintext.SetActive(true);

        }
    }
}
