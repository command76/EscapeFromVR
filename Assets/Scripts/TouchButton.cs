using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TouchButton : MonoBehaviour
{
    public SafeControl other;
    int count = 0;
    // Start is called before the first frame update
    //public int[] buttons2;
    public List<int> buttons = new List<int>();
    private static int[] correctCombo = { 1, 1, 1, 1, 1, 1 };
    void Start()
    {

    }
      // Update is called once per frame
    void Update()
    {

    }
    //Use Interactable Asset from VRTK Game Assets > Prefab > Interations > Interactables > Interactable.Primary_Grap.Secondard_None(Prefab Asset)
    //Assign interactable asset as collision handler for Collision Started event data
    //Array.Empty() could be useful

    public void SafeLogic(int buttonNum){

        buttons.Add(buttonNum);
        //buttons [count] = buttonNum;
        //count++;
        Debug.Log(buttons.Count);
               
            
        
        if (buttons.Count == 6){
            if ((buttons[0] == correctCombo[0]) && (buttons[1] == correctCombo[1])
                && (buttons[2] == correctCombo[2]) && (buttons[3] == correctCombo[3])
                && (buttons[4] == correctCombo[4]) && (buttons[5] == correctCombo[5])){
                Debug.Log("You did it!");
                other.OpenSafe();
            }
        } 
        if (buttons.Count == 7){
                buttons.Clear();
               // Debug.Log(buttons[0]);
               // count = 0;
            }
          
    
     Debug.Log("buttonNum is " + buttonNum);
     Debug.Log("buttons array length is " + buttons.Count);
    }
}


 





















    //public void Button1Touched()
    //{
    //    buttons[0] = 1;
    //    Debug.Log(buttons[0]);

    //}
    //public void Button2Touched()
    //{
    //    buttons[1] = 2;
    //    Debug.Log(buttons[1]);

    //}
    //public void Button3Touched()
    //{
    //    buttons[2] = 3;
    //    Debug.Log(buttons[2]);

    //}
    //public void Button4Touched()
    //{
    //    buttons[3] = 4;
    //    Debug.Log(buttons[3]);

    //}
    //public void Button5Touched()
    //{
    //    buttons[4] = 5;
    //    Debug.Log(buttons[4]);

    //}
    //public void Button6Touched()
    //{
    //    buttons[5] = 6;
    //    Debug.Log(buttons[5]);

    //}


//}
