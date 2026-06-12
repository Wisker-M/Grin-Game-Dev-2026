using UnityEngine;
namespace FlappyBirdClone
{
public class BirdRandomizer : MonoBehaviour
{
    [SerializeField] private RuntimeAnimatorController[] controllers;
    private void Start()
    {
        if (controllers != null && controllers.Length > 0)
        {
            var anim = GetComponent<Animator>();
            if (anim != null)
            {
                int idx = Random.Range(0, controllers.Length);
                anim.runtimeAnimatorController = controllers[idx];
            }
        }
    }
}

}