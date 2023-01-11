using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] private Text CatText, InputText;
    [SerializeField] private InputField inputField;
    [SerializeField] private string myText;
    
    public void SaveInputText()
    {
        myText = InputText.text;
    }
    public void ShowCatText()
    {
        CatText.text = myText;
    }

}
