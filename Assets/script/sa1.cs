using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa1 : StateMachineBehaviour {
    GameObject a1;
    GameObject a2;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        a2 = GameObject.Find("cv4_int2");
        a2.GetComponent<AudioSource>().Stop();

        a1 = GameObject.Find("cv4_int1");
        a1.GetComponent<AudioSource>().Play();
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
