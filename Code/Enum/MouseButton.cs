namespace Kavlon {
 public enum MouseButton {
  Primary = 0, // UnityEngine.KeyCode.Mouse0
  Secondary, // UnityEngine.KeyCode.Mouse1
  Middle, // UnityEngine.KeyCode.Mouse2
  Button4, // UnityEngine.KeyCode.Mouse3
  Button5, // UnityEngine.KeyCode.Mouse4
  Button6, // UnityEngine.KeyCode.Mouse5
  Button7 // UnityEngine.KeyCode.Mouse6
 }

 public static class MouseButtonExtensions {
  public static UnityEngine.KeyCode ToKeyCode ( this MouseButton mouseButton ) {
   switch ( mouseButton ) {
    case MouseButton.Primary: {
      return UnityEngine.KeyCode.Mouse0;
     }
    case MouseButton.Secondary: {
      return UnityEngine.KeyCode.Mouse1;
     }
    case MouseButton.Middle: {
      return UnityEngine.KeyCode.Mouse2;
     }
    case MouseButton.Button4: {
      return UnityEngine.KeyCode.Mouse3;
     }
    case MouseButton.Button5: {
      return UnityEngine.KeyCode.Mouse4;
     }
    case MouseButton.Button6: {
      return UnityEngine.KeyCode.Mouse5;
     }
    case MouseButton.Button7: {
      return UnityEngine.KeyCode.Mouse6;
     }
   }

   return UnityEngine.KeyCode.None;
  }
 }
}