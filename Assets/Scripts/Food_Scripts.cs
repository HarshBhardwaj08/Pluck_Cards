using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Scripts : MonoBehaviour
{
    public GameObject food_child;
    public int foodIndex;
    public Food_SO foods;

    public SpriteRenderer spriteRenderer;
    void Start()
    {   
    
         food_child.SetActive(false);
    }

    public void SetFoodIndex(int foodIndex)
    {
        this.foodIndex = foodIndex;
      
        foods = Food_Menu.Instance.GetFoodItem(foodIndex);
        spriteRenderer.sprite = foods.Texture;
        food_child.SetActive(true); 
    }
    private void OnMouseDown()
    {
        UI_Scripts.instance.onOpenPanel(foods);



    }

}
