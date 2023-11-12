using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleGFX : MonoBehaviour
{
    [SerializeField] GameObject defaultGFX;
    [SerializeField] GameObject[] gfx_options;

    // Start is called before the first frame update
    void Start()
    {
        if(gfx_options.Length!=0)
        {
            defaultGFX.SetActive(false);
            int idx = Random.Range(0, gfx_options.Length);
            gfx_options[idx].SetActive(true);
        }
    }

}
