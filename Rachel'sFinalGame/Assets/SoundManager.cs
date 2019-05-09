
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource mySource;


    [Header("Jump Sounds")]
    public AudioClip jumpClip;

    [Header("Gun Sounds")]
    public AudioClip GunClip;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayJumpSound()
    {
        mySource.PlayOneShot(jumpClip);
    }


        public void PlayGunSound()
      
     
       
         {
         mySource.PlayOneShot(GunClip);
        }


}
