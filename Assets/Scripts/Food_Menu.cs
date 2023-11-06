using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Menu : MonoBehaviour
{
    public static Food_Menu Instance; 
   public  List<Food_Scripts> scripts  ;
   public UI_Scripts ui;
    [SerializeField] private List<Food_SO> lstFoods = new List<Food_SO>();
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        ui.index_count = -1;
    }

    
    public  void SetFoodItems()
    {
        for (int i = 0; i < scripts.Count; i++)
        {
            int rand = Random.Range(0, lstFoods.Count);
            scripts[i].SetFoodIndex(rand);
        }
    }
    public Food_SO GetFoodItem(int idx)
    {
        return lstFoods[idx];
    }


}
