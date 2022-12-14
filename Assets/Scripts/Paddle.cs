using UnityEngine;

public class Paddle : MonoBehaviour
{
	[SerializeField]
	public float _moveSpeed = 10.0f;

	protected Rigidbody2D _rigidbody2D;

	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	public void ResetPosition()
	{
		_rigidbody2D.position = new Vector2(_rigidbody2D.position.x, 0.0f);
		_rigidbody2D.velocity = Vector2.zero;
	}
}
