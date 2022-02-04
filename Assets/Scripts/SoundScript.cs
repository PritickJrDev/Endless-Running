using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip stoneBreakEffect, crateBreakEffect, slimeSoundEffect, playerJumpEffect, slimeHit, birdHit, deadEffect;
    static AudioSource audio;

    void Start()
    {
        stoneBreakEffect = Resources.Load<AudioClip>("stoneBreak");
        crateBreakEffect = Resources.Load<AudioClip>("crateBreak");
        slimeSoundEffect = Resources.Load<AudioClip>("slime");
       // footstepsEffect = Resources.Load<AudioClip>("footsteps");
      //  flapEffect = Resources.Load<AudioClip>("flapping");
        playerJumpEffect = Resources.Load<AudioClip>("PlatformJump");
        slimeHit = Resources.Load<AudioClip>("splash");
        birdHit = Resources.Load<AudioClip>("BirdCry");
        deadEffect = Resources.Load<AudioClip>("dead");

        audio = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "stone":
                audio.PlayOneShot(stoneBreakEffect);
                break;
            case "crate":
                audio.PlayOneShot(crateBreakEffect);
                break;
            case "slimeEffect":
                audio.PlayOneShot(slimeSoundEffect);
                break;
            //case "footstep":
            //    audio.PlayOneShot(footstepsEffect);
            //    break;
            //case "flap":
            //    audio.PlayOneShot(flapEffect);
            //    break;
            case "jump":
                audio.PlayOneShot(playerJumpEffect);
                break;
            case "slime":
                audio.PlayOneShot(slimeHit);
                break;
            case "birdSoundEffect":
                audio.PlayOneShot(birdHit);
                break;
            case "deadSound":
                audio.PlayOneShot(deadEffect);
                break;
        }

    }
}
