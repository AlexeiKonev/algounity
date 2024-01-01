using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : MonoBehaviour
{
  [SerializeField]
  private int[] mas = { 5999,33,666,777,97};

  public  void StartSort()
    {
        
    }

    
}

//static int[] ViborSort(int[] mas)
//{

//    for (int i = 0; i < mas.Length - 1; i++)
//    {
//        //поиск минимального числа
//        int min = i;
//        for (int j = i + 1; j < mas.Length; j++)
//        {
//            if (mas[j] < mas[min])
//            {
//                min = j;
//            }
//        }
//        //обмен элементов
//        int temp = mas[min];
//        mas[min] = mas[i];
//        mas[i] = temp;
//    }
//    return mas;
//}