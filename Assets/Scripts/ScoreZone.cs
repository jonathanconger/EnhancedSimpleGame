using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ScoreZone : MonoBehaviour
{
	[SerializeField]
	EventTrigger.TriggerEvent scoreTrigger;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Ball ball = collision.gameObject.GetComponent<Ball>();

		if (ball != null)
		{
			BaseEventData eventData = new BaseEventData(EventSystem.current);
			scoreTrigger.Invoke(eventData);
		}
	}
}
