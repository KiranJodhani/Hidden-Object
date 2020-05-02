using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject InstructionScreen;
    void Start()
    {
		RevenueManager.Instance.ShowInterstitialAd ();
		Time.timeScale = 0;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void HideInstructionPanel()
	{
		Time.timeScale = 1;
		InstructionScreen.SetActive (false);
	}
}
