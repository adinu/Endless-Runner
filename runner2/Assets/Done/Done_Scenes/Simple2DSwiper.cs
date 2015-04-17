using UnityEngine;

// This script will push a rigidbody around when you swipe
[RequireComponent(typeof(Rigidbody2D))]
public class Simple2DSwiper : MonoBehaviour
{
    public float ForceMultiplier;

    protected virtual void OnEnable()
    {

        // Hook into the OnSwipe event
        Lean.LeanTouch.OnFingerSwipe += OnFingerSwipe;
    }

    protected virtual void OnDisable()
    {
        // Unhook into the OnSwipe event
        Lean.LeanTouch.OnFingerSwipe -= OnFingerSwipe;
    }

    public void OnFingerSwipe(Lean.LeanFinger finger)
    {
        //Create a Ray on the tapped / clicked position
        Ray ray = Camera.main.ScreenPointToRay(finger.StartScreenPosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

        //Check if the ray hits any collider
		if (hit.collider.gameObject != null) {

			if (hit.collider.gameObject == gameObject) {

				Debug.Log ("Hi");
				// Get the rigidbody component
				var rigidbody = GetComponent<Rigidbody2D> ();

				// Add force to the rigidbody based on the swipe force
				rigidbody.AddForce (finger.ScaledSwipeDelta * ForceMultiplier);
				Debug.Log (finger.ScaledSwipeDelta);
			}
		}


        /*print("YOOOOOO");
        // Raycast information
        var ray = finger.GetRay();
        Vector2 hit = default(RaycastHit2D);
        
        // Was this finger pressed down on a collider?
        if (Physics2D.Raycast(ray, out hit) == true)
        {
            print("HI");
            print(hit);
            // Was that collider this one?
            if (hit.collider.gameObject == gameObject)
            {
                print(hit);
                // Get the rigidbody component
           //     var rigidbody = GetComponent<Rigidbody2D>();

                // Add force to the rigidbody based on the swipe force
             //   rigidbody.AddForce(finger.ScaledSwipeDelta * ForceMultiplier);
            }
        }*/
    }
}