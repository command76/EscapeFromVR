using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperScript : MonoBehaviour
{
    public Text thisText;
    
    private bool glassesCheck;
  
    void Start()
    {
        //thisText.text = "Password: "; 
        ChangeTextToHide();
    }

    void FixedUpdate()
    {
        CheckForGlasses();

        if (glassesCheck)
        {
            ChangeTextToReveal();
        }

        else if (!glassesCheck)
        {
            ChangeTextToHide();
        }
    }

    void CheckForGlasses()
    {
        if (HeadSphereControl.areGlassesEquiped)
        {
            glassesCheck = true;
        }
        else
        {
            glassesCheck = false;
        }
    }

    void ChangeTextToReveal()
    {
        thisText.text = "Password: 1234";
    }

    void ChangeTextToHide()
    {
        thisText.text = "Password: ";
    }
}


