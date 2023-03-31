using UnityEngine;

public class EndTriggerReal : MonoBehaviour
{
	public GameManager gameManager;
	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
	}
}
