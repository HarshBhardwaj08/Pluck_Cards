using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class UI_Scripts : MonoBehaviour
{
    public static UI_Scripts instance;
    public GameObject FoodInfoPanel;
    public GameObject Food_Icon;
    public TMP_Text FoodName;
    public TMP_Text vitaminname;
    public TMP_Text protienname;
    public Image image;
    public int randomindex;
    public int index_count = -1;
    private void Awake()
    {
        instance = this;
        
    }
    public void onClick() 
    {
        Food_Menu.Instance.SetFoodItems();
    
    }

    public void onOpenPanel(Food_SO foods )
    {
        FoodInfoPanel.SetActive(true);

        image.sprite = foods.Texture;
        FoodName.text = foods.name_food;
        vitaminname.text = foods.food_vitamin.ToString();
        protienname.text = foods.total_Protien;

    }

    public void onExitPanel()
    {
        FoodInfoPanel.SetActive(false);

    }
}
