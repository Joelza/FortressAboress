using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UnitUI : MonoBehaviour
{
    public GameObject BeaverImage;
    public GameObject BearImage;
    public GameObject ForIcon;
    public GameObject PredIcon;
    public TMP_Text nameText;
    public TMP_Text apText;
    public TMP_Text atkText;
    public TMP_Text defText;
    public TMP_Text forcostText;
    public TMP_Text predcostText;
    public Slider sliderhealth;
    public Gradient gradient;
    public Image fill;
    



    Beaver beaver1 = new Beaver();
    //BlackBear blackbear1 = new BlackBear();

    
    List<Animal> avaliableanimals = new List<Animal>(); //Create list of units avaliable
    public int maxuniti;

    int uniti = 0;  //integer for currently selected unit 
    
    void Start()
    {
        
        avaliableanimals.Add(beaver1);
        //avaliableanimals.Add(blackbear1);

        //number of units avaliable
        maxuniti = avaliableanimals.Count-1;
        UpdateUnitUI();
    }
    //Function to update UI
    void UpdateUnitUI(){
        nameText.text = avaliableanimals[uniti].name;
        apText.text = "Action points: " + avaliableanimals[uniti].ap + "/" + avaliableanimals[uniti].maxap;
        atkText.text = "Attack: " + avaliableanimals[uniti].atk;
        defText.text = "Defence: " + avaliableanimals[uniti].def;
        SetHealth(avaliableanimals[uniti].hp, avaliableanimals[uniti].maxhp);
        if (avaliableanimals[uniti].name == "Beaver") {
            BeaverImage.SetActive(true);
            BearImage.SetActive(false);
            predcostText.text = "";
            forcostText.text = "5";
            ForIcon.SetActive(true);
            PredIcon.SetActive(false);


        }
        else if (avaliableanimals[uniti].name == "Bear"){
            BeaverImage.SetActive(false);
            BearImage.SetActive(true);
            predcostText.text = "5";
            predcostText.text = "10";
            ForIcon.SetActive(true);
            PredIcon.SetActive(true);

        }
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1) ){
           avaliableanimals[uniti].hp = avaliableanimals[uniti].hp -5;
           avaliableanimals[uniti].ap = avaliableanimals[uniti].ap -5;
           UpdateUnitUI();

        }
        if(Input.GetKeyDown(KeyCode.Alpha2) ){
            avaliableanimals[uniti].ap = avaliableanimals[uniti].ap +5;
            avaliableanimals[uniti].hp = avaliableanimals[uniti].hp + 5;
            UpdateUnitUI();
        }
        
    }

    //cylce to previous unit if left button is pressed
    public void Leftbutton(){
        if (uniti == 0){
            uniti = maxuniti; //loop to end
        }
        else{
            uniti--;
        }
        UpdateUnitUI();
    }

    //cylce to next unit if left button is pressed
    public void Rightbutton(){
        if (uniti == maxuniti){
            uniti = 0;  //loop back to start
        }
        else{
            uniti++;
        }
        UpdateUnitUI();
    }

    //Update unit health bar 
    public void SetHealth(int health, int maxhealth){
        sliderhealth.maxValue = maxhealth;
        sliderhealth.value = health;
        fill.color = gradient.Evaluate(sliderhealth.normalizedValue);

    }

    public void AddUnit(){
        BlackBear blackbear1 = new BlackBear();
        avaliableanimals.Add(blackbear1);

    }

    public void AddBeaver(){
        Beaver beaver2 = new Beaver();
        avaliableanimals.Add(beaver2);

    }


}





