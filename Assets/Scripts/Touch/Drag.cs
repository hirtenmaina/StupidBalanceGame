using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

	[SerializeField]
	float		_horizontalLimit =2.5f, _verticalLimit =2.5f, dragSpeed =0.1f;

	Transform cachedTransform;

	Vector3 startingPos;

	void Start () {
		cachedTransform = transform;

		startingPos = cachedTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount > 0) {

			Vector2 deltaPosition = Input.GetTouch(0).deltaPosition;

			switch(Input.GetTouch(0).phase){
			case TouchPhase.Began:
				break;

			case TouchPhase.Moved:
				DragObject(deltaPosition);
				break;

			case TouchPhase.Ended:
				break;
			}
		}

	}

	void DragObject(Vector2 deltaPosition){
	
		cachedTransform.position = new Vector3 (Mathf.Clamp ((deltaPosition.x * dragSpeed) + cachedTransform.position.x,
		              startingPos.x - _horizontalLimit, startingPos.x + _horizontalLimit),
		              Mathf.Clamp ((deltaPosition.y * dragSpeed) + cachedTransform.position.y,
		              startingPos.y - _verticalLimit, startingPos.y + _verticalLimit),
		                                       cachedTransform.position.z);

	}
}
