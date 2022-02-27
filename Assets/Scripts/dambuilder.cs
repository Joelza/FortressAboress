using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dambuilder : MonoBehaviour
{   


    public GameObject dam;
    public GameObject river;
    public GameObject beaverPrefab;
    public Button button;
    public MainUI mainUI;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        
        dam.SetActive(true);
        river.SetActive(false);
        mainUI.NewUnitBeaverGameObject.SetActive(true);
        Instantiate(beaverPrefab, new Vector3(0.108f, 0.191f, -10.927f), Quaternion.identity);

    }
}
