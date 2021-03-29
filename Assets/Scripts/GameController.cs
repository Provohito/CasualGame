using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    Animator menuAnimatorBoost;
    void Start()
    {
       
    }
    public void OpenSettings(GameObject objWithAnimator) // Получаем из объекта в инспекторе аниматор и запускаем соответствующую анимацию
    {
        Animator menuAnimator; // переменная типа Animator для получения его из назначенного объекта
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

    public void OpenBoostMenu(GameObject objWithAnimator)
    {
        if (menuAnimatorBoost != null)
        {
            menuAnimatorBoost.Play("close");
            menuAnimatorBoost.SetBool("isHide", true);
        }


        menuAnimatorBoost = objWithAnimator.GetComponent<Animator>();
        
        if (menuAnimatorBoost.GetBool("isHide") == true)
        {
            menuAnimatorBoost.Play("open");
            menuAnimatorBoost.SetBool("isHide", false);
        }
        else
        {
            menuAnimatorBoost.Play("close");
            menuAnimatorBoost.SetBool("isHide", true);
        }
    }
}
