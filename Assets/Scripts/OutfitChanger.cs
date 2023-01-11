using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite to change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to cycle through")]
    public List<Sprite> options = new List<Sprite>();
    public List<AnimatorOverrideController> anim = new List<AnimatorOverrideController>();


    private int currentOption = 0;


    public void NextOption()
    {
        currentOption++;

        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
        bodyPart.sprite = options[currentOption];

    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption<0)
        {
            currentOption=options.Count-1;
        }
        bodyPart.sprite = options[currentOption];



    }
    public void Randomize()
    {
        currentOption = Random.Range(0, options.Count - 1);

        bodyPart.sprite = options[currentOption];

    }
}
