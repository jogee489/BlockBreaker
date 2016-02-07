using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	
	private Ball ball;
	
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	// Update is called once per frame
	void Update () {
		if (!autoPlay){
			MoveWithMouse();
		} else {
			AutoPlay();
		}
	}
	
	void AutoPlay () {
		Vector3 paddlePostion = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPosition = ball.transform.position;
		paddlePostion.x = Mathf.Clamp(ballPosition.x, 0.5f, 15.5f);
		this.transform.position = paddlePostion;
	}
	
	void MoveWithMouse () {
		Vector3 paddlePostion = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePositionInBlocks = (Input.mousePosition.x / Screen.width) * 16;
		paddlePostion.x = Mathf.Clamp(mousePositionInBlocks, 0.5f, 15.5f);
		this.transform.position = paddlePostion;
	}
}
