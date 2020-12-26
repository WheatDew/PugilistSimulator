using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorManagement : MonoBehaviour
{
    public Animator ani,ani2;
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
        //读秒判定
        timer+=Time.deltaTime;
        if(timer>targetTime)
        {
            self.text = "";
            timer = 0;
        }
        //对手被击判定
        if ((self.text == "L1" || self.text == "R1")&&opponent.text=="")
        {
            ani2.SetTrigger("B1");
            opponent.text = "B1";
        }
        //重置状态
        if(ani2.GetCurrentAnimatorStateInfo(0).IsName("A0"))
        {
            opponent.text = "";
        }
    }
}
