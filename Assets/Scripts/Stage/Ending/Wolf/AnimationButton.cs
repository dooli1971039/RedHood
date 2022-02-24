using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationButton : MonoBehaviour
{

    public Animator my_animator;
    public int target_motion = 1;

    void OnMouseDown()
    {
        my_animator.SetInteger("motion", target_motion);
        target_motion--;
        if(target_motion == -1)
        {
            SceneManager.LoadScene("Shooting");
        }
    }
}
