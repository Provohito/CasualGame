using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    Animator menuAnimator;  // переменная для получения аниматора из назначенного объекта

    void Start()
    {
       
    }
    public void OpenSettings(GameObject objWithAnimator) // Получаем из объекта в инспекторе аниматор и запускаем соответствующую анимацию
    {
        menuAnimator = objWithAnimator.GetComponent<Animator>();
        if (menuAnimator.GetBool("isHide") == true)
        {
            menuAnimator.Play("open");
            menuAnimator.SetBool("isHide", false);  
        }
        else
        {
            menuAnimator.Play("close");
            menuAnimator.SetBool("isHide", true); 
        }
    }
}
