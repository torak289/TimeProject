using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorEvents : MonoBehaviour {

    public void ToggleClicked(Animator currAnimator){
        currAnimator.SetBool("Activated", !currAnimator.GetBool("Activated"));
    }
}
