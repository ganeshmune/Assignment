using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class AnimationController : MonoBehaviour
    {
        public Animator animator;
        StarterAssetsInputs starterAssetsInputs;

        // Start is called before the first frame update
        void Start()
        {
            starterAssetsInputs = this.GetComponent<StarterAssetsInputs>();
        }

        // Update is called once per frame
        void Update()
        {
            if (animator != null)
            {
                animator.SetFloat("Speed", starterAssetsInputs.move.y);
            }

        }
    }
}
