using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
  [SerializeField]  private float BackgroundSpeed;
  [SerializeField] private Renderer BackgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        BackgroundRenderer.material.mainTextureOffset += new Vector2(BackgroundSpeed * Time.deltaTime, 0);
    }
}
