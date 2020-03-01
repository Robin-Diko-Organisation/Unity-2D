using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnimator : MonoBehaviour
{
    [SerializeField] private bool isImageNotSprite = true;
    [SerializeField] private Sprite[] frameArray = null;
    [SerializeField] private float framerate = 0.1f;
    private int currentFrame = 0;
    private float timer = 0;
    Image image;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        if (isImageNotSprite)
        {
            image = gameObject.GetComponent<Image>();
        }
        else
        {
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame +1) % frameArray.Length;
            image.sprite = frameArray[currentFrame];
        }
    }
}
