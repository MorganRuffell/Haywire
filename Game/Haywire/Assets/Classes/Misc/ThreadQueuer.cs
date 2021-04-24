using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

public class ThreadQueuer : MonoBehaviour
{

    //delegate == blueprint for a functions signature
    //Action == this function name
    // So here we are just saying that we need a function that returns nothing and requires no paramaters
    // public delegate void SameThingAsAction();

    //Thread Newthread;

    List<Action> functionsToRuninMainThread;


	private void Start()
	{
        functionsToRuninMainThread = new List<Action>();
	}

	//Action is shortform for a delegate that takes no paramaters
	public void StartThreadedFuction(Action someFunction)
    {
        //Newthread.Start(someFunction);
	}

    public void QueueMainThreadFunction(Action someFunction)
    {

	}





}
