using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetPackage;
using BMLRealizer;

public class BMLScriptRealizer : MonoBehaviour
{
    public RageBMLRealizer bml = new RageBMLRealizer();
	//public int test_count = 0;

    private void Start()
    {
        bml.OnSyncPointCompleted += SyncPointCompleted;
        bml.ParseFromString(System.IO.File.ReadAllText("Assets/BML-Realizer/BMLScriptRealizer/BML.xml"));
    }

    private void Update()
    {
        bml.Update(Time.deltaTime);
     
		//Debug.Log(test_count);
		//test_count++;
    }

    public void SyncPointCompleted(string behaviorID, string eventName)
	{
		BMLBlock block = bml.GetBehaviorFromId(behaviorID);

		GameObject character = GameObject.Find(block.getCharacterId());
		if (block is BMLFace)
		{
			BMLFace face = (BMLFace)block;

		}
		else if (block is BMLFaceFacs)
		{
			BMLFaceFacs face = (BMLFaceFacs)block;

		}
		else if (block is BMLFaceLexeme)
		{
			BMLFaceLexeme face = (BMLFaceLexeme)block;

		}
		else if (block is BMLFaceShift)
		{
			BMLFaceShift face = (BMLFaceShift)block;

		}

		else if (block is BMLGaze)
		{
			BMLGaze gaze = (BMLGaze)block;

		}
		else if (block is BMLGazeShift)
		{
			BMLGazeShift gazeShift = (BMLGazeShift)block;

		}

		else if (block is BMLGesture)
		{
			BMLGesture gesture = (BMLGesture)block;

		}
		else if (block is BMLPointing)
		{
			BMLPointing pointing = (BMLPointing)block;

		}

		else if (block is BMLHead)
		{
			BMLHead head = (BMLHead)block;


		}
		else if (block is BMLHeadDirectionShift)
		{
			BMLHeadDirectionShift headDirectionShift = (BMLHeadDirectionShift)block;

		}

		else if (block is BMLLocomotion)
		{
			BMLLocomotion locomotion = (BMLLocomotion)block;

		}

		else if (block is BMLPosture)
		{
			BMLPosture posture = (BMLPosture)block;

		}
		else if (block is BMLPostureShift)
		{
			BMLPostureShift postureShift = (BMLPostureShift)block;

		}
		else if (block is BMLStance)
		{
			BMLStance stance = (BMLStance)block;

		}
		else if (block is BMLPose)
		{
			BMLPose pose = (BMLPose)block;

		}

		else if (block is BMLSpeech)
		{
			BMLSpeech speech = (BMLSpeech)block;

		}
	}
}
