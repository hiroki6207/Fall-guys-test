using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] private Image background_image;
    // Start is called before the first frame update
    void Start()
    {
        this.background_image.DOFade(endValue: 0f, duration: 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
