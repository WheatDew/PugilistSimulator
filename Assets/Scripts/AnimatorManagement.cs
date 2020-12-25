using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorManagement : MonoBehaviour
{
    public Animator ani;
    public Text self, opponent;
    private float timer,targetTime;
    

    public void SetAction(string actName)
    {
        ani.SetTrigger(actName);
        self.text = actName;
        targetTime = 3;
    }

    private void Update()
    {
        timer+=Time.deltaTime;
        if(timer>targetTime)
        {
            self.text = "";
            timer = 0;
        }
    }
}
