using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
  public AudioSource source;
  public AudioClip footStep;

  void FootSound()
  {
    source.clip=footStep;
    source.Play();
  }
}
