using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
  [SerializeField]  private int[] array = { 1,14,12,24,16};
    private int arrayIndex = 0 ; 
     

    
    void Update()
    {
        
    }
  public  void StartSort()
    {
        for (int write = 0; write < array.Length; write++)
        {
            for(int sort = 0; sort < array.Length - 1; sort++)
            {
                if (array[sort] > array[sort + 1])
                {
                    arrayIndex = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = arrayIndex;
                }
            }
            Debug.Log($"{0} ");
            Debug.Log(  array[write]);
        }
    }
}
//int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

//int temp = 0;

//for (int write = 0; write<arr.Length; write++)
//{
//    for (int sort = 0; sort<arr.Length - 1; sort++)
//    {
//        if (arr[sort] > arr[sort + 1])
//        {
//            temp = arr[sort + 1];
//            arr[sort + 1] = arr[sort];
//            arr[sort] = temp;
//        }       
//    }   
//    Console.Write("{0} ", arr[write]);  
//}