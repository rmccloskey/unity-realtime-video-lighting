using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGI : MonoBehaviour
{
  public Renderer[] renderers;
  public Renderer dyn;

  void Update()
  {
    foreach (Renderer ren in renderers)
    {
      ren.UpdateGIMaterials();
    }
    // dyn.materials[0].SetColor("_EmissionColor", new Color(Random.value, Random.value, Random.value) * 500);

  }
}
