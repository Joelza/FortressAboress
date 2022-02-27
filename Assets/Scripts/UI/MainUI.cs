using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{

    public GameObject NewUnitGameObject;
    public GameObject NewUnitBeaverGameObject;
    public TMP_Text forText;
    public TMP_Text predText;
    public TMP_Text grazeText;
    public TMP_Text dayText;
    public TMP_Text weekText;
    public TMP_Text forperText;
    public TMP_Text unitnumText;
    public UnitUI unitui;
    public GameObject bearPrefab;


    int forfood = 100;
    int predfood = 100;
    int grazefood = 100;
    int maxgraze = 400;
    int maxfor = 400;
    int maxpred = 400;
    int day = 5;
    int forpen = 100; 
    string weekday;
    int unitnum;

    // Start is called before the first frame update
    void Start()
    {
        unitnum = unitui.maxuniti + 1;
        UpdateUI();
    }


    void UpdateUI(){
        forText.text =  forfood + "/" + maxfor;
        predText.text =  predfood + "/" + maxpred;
        grazeText.text =  grazefood + "/" + maxgraze;
        forperText.text = forpen + "%";
        unitnumText.text = unitnum + "";
        switch(day%7){
            case 1: 
                weekday = "Mon";
                break;
            case 2: 
                weekday = "Tue";
                break;
            case 3: 
                weekday = "Wed";
                break;
            case 4: 
                weekday = "Thurs";
                break;
            case 5: 
                weekday = "Fri";
                break;
            case 6: 
                weekday = "Sat";
                break;
            case 0: 
                weekday = "Sun";
                break;
        }
        dayText.text = "Day: " + day;
        weekText.text = weekday;
    }

    public void NextTurn(){

        day++; //increment turn counter

        if(unitnum == 1){
            forfood -= 5;

        }
        else if(unitnum == 2) {
            forfood -= 10;
            predfood -=10;
        }

        UpdateUI();
        if (weekday == "Sun"){
            NewUnitGameObject.SetActive(true);
        }
        

    }

    public void SelectNewUnit(){
        
        unitui.maxuniti++; 
        unitnum++;
        UpdateUI();
        unitui.AddUnit();
        Instantiate(bearPrefab, new Vector3(4.5f, 0.05f, -13f), Quaternion.identity);
        NewUnitGameObject.SetActive(false);

    }

    public void SelectNewBeaverUnit(){
        
        unitui.maxuniti++; 
        unitnum++;
        UpdateUI();
        unitui.AddBeaver();
        NewUnitBeaverGameObject.SetActive(false);

    }

    

    // Update is called once per frame
    /*
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) ){
            UnitUIGameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return) ){
            UnitUIGameObject.SetActive(true);
        }
        
    }*/

}
