using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image image;
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            changeColor();
        }
    }
    
    public void changeColor()
    {
        image.GetComponent<Image>().color = GetRandomColor();
    }

    Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
