#pragma strict

 /* this variable is used to make use of the swipe. Once a swipe is detected
  * a function called Swipe(swipeType : Vector2) is called
  */
 
 class sc{
// var controller : CharacterController;
// 
// // variables:
// 
// private var fingerStartTime : float   = 0.0;
// private var fingerStartPos  : Vector2 = Vector2.zero;
//  
// private var isSwipe         : boolean = false;
// private var minSwipeDist    : float   = 50.0;
// private var maxSwipeTime    : float   = 0.5;
//  
// // main function:
// function Update()
// {
//     if (Input.touchCount > 0)
//     {
//         for (var touch : Touch in Input.touches)
//         {
//             switch (touch.phase)
//             {
//                 case TouchPhase.Began :
//                     /* this is a new touch */
//                     isSwipe = true;
//                     fingerStartTime = Time.time;
//                     fingerStartPos = touch.position;
//                     break;
// 
//                 case TouchPhase.Canceled :
//                     /* The touch is being canceled */
//                     isSwipe = false;
//                     break;
// 
//                 case TouchPhase.Ended :
//                     var gestureTime : float = Time.time - fingerStartTime;
//                     var gestureDist : float = (touch.position - fingerStartPos).magnitude;
//                     
//                     if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist)
//                     {
//                         var direction : Vector2 = touch.position - fingerStartPos;
//                         var swipeType : Vector2 = Vector2.zero;
//                         
//                         if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
//                         {
//                             // the swipe is horizontal:
//                             swipeType = Vector2.right * Mathf.Sign(direction.x);
//                         }
//                         else
//                         {
//                             // the swipe is vertical:
//                             swipeType = Vector2.up * Mathf.Sign(direction.y);
//                         }
//                         
//                         controller.Swipe(swipeType);
//                     }
// 
//                     break;
//                 }
//             }
//         }
//     }
 }
