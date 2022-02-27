using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodDisplay : MonoBehaviour
{
    private int food = 5;
    public Text foodText;
  

    // Update is called once per frame
    void Update()
    {
        foodText.text = "Food :" + food;

        if(Input.GetKeyDown(KeyCode.Space) ){
            food--;
        }
    }
}
