using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This sealed class does nothing, it is a tool that I am using 
//to store loads of code snippets that are going to be used in the animator to trigger animations 
//and work with blendtrees.

//This should not be included in any documentation, and should not be added to ANY gameObject

public struct DefaultAnimations
{
	//Do this for everything that has animations, store a reference to them as strings.

	const string PLAYER_IDLE = "Player_Idle";
	const string PLAYER_RUN = "Player_Run";
}

public sealed class AnimationCuttings : MonoBehaviour
{
	//Better ways to work with animations

	// Animation States - Save the string name as a const string with a context approriate label
	const string PLAYER_IDLE = "Player_Idle";

	public float AttackDelay;


	public Animator animationController;

	private string currentState;

	private void Awake()
	{
		//Get the animator component attached to the gameObject
		animationController = GetComponent<Animator>();
	}

	void Start()
	{
		//Logic used for setting a bool on and off.
		animationController.SetBool("BoolName", true);

		animationController.SetFloat("WalkSpeed", 0.5f);

		//Do not offload the triggers and the code to the 'black box' of the unity animator.
		animationController.Play("");
	}

	void ChangeAnimationState(string NewState)
	{
		//Stops the animation from interrupting itself.
		if (currentState == NewState) return;

		//Play the animation
		animationController.Play(NewState);

		//reassign the cyrrent state to the new state
		currentState = NewState;
	}

	// Update is called once per frame
	void Update()
	{
		//Sets Attack delay to be equal to the current remaining time of the current playing animation.
		AttackDelay = animationController.GetCurrentAnimatorStateInfo(0).length;
	}
}
