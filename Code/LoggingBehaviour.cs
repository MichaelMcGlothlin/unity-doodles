#if LOG_ANIMATOR
#define LOG_ONANIMATORIK
#define LOG_ONANIMATORMOVE
#endif

#if LOG_APPLICATION
#define LOG_ONAPPLICATIONFOCUS
#define LOG_ONAPPLICATIONPAUSE
#define LOG_ONAPPLICATIONQUIT
#endif

#if LOG_COLLISIONS
#define LOG_ONCOLLISIONENTER
#define LOG_ONCOLLISIONENTER2D
#define LOG_ONCOLLISIONEXIT
#define LOG_ONCOLLISIONEXIT2D
#define LOG_ONCOLLISIONSTAY
#define LOG_ONCOLLISIONSTAY2D
#define LOG_ONCONTROLLERCOLLIDERHIT
#define LOG_ONPARTICLECOLLISION
#endif

#if LOG_IMPORTANT
#define LOG_FIXEDUPDATE
#define LOG_LATEUPDATE
#define LOG_ONDISABLE
#define LOG_ONENABLE
#define LOG_ONGUI
#define LOG_START
#define LOG_UPDATE
#endif

#if LOG_LIFECYCLE
#define LOG_AWAKE
#define LOG_FIXEDUPDATE
#define LOG_LATEUPDATE
#define LOG_ONDESTROY
#define LOG_ONDISABLE
#define LOG_ONENABLE
#define LOG_ONGUI
#define LOG_RESET
#define LOG_START
#define LOG_UPDATE
#endif

#if LOG_MOUSE
#define LOG_MOUSEDOWN
#define LOG_MOUSEDRAG
#define LOG_MOUSEENTER
#define LOG_MOUSEEXIT
#define LOG_MOUSEOVER
#define LOG_MOUSEUP
#define LOG_MOUSEUPASBUTTON
#endif

#if LOG_TRIGGERS
#define LOG_ONTRIGGERENTER
#define LOG_ONTRIGGERENTER2D
#define LOG_ONTRIGGEREXIT
#define LOG_ONTRIGGEREXIT2D
#define LOG_ONTRIGGERSTAY
#define LOG_ONTRIGGERSTAY2D
#define LOG_ONPARTICLETRIGGER
#endif

#if LOG_UPDATES
#define LOG_FIXEDUPDATE
#define LOG_LATEUPDATE
#define LOG_UPDATE
#endif

namespace Kavlon {
 /// <summary>
 /// Set these flags under Edit.. Project settings.. Player.. Scripting Define Symbols
 /// Inherit from Kavlon.LoggingBehavior instead of UnityEngine.MonoBehavior
 /// Remember to call the base method if you override the method and want to retain the logging
 /// </summary>
 public abstract class LoggingBehaviour : UnityEngine.MonoBehaviour {
  private const System.String LOG_FLAG = ">>> ";

  private const System.String LOG_INDENT = "\n\t\t";

  /// <summary>
  /// Break for debugging.
  /// </summary>
  [System.Diagnostics.Conditional ( "DEBUG" )]
  protected static void DebugBreak () => UnityEngine.Debug.Break ();

  /// <summary>
  /// Log the specified tag and message.
  /// </summary>
  /// <param name="tag">Tag such as method name.</param>
  /// <param name="message">Message to log.</param>
  [System.Diagnostics.Conditional ( "DEBUG" )]
  protected void Log ( System.String tag, System.String message ) => UnityEngine.Debug.Log ( $"{LOG_FLAG}{tag}{LOG_INDENT}{message}", this );

  /// <summary>
  /// Awake is called when the script instance is being loaded
  /// </summary>
#if LOG_AWAKE
  protected virtual void Awake () => Log ( nameof ( Awake ), $"\t{this}[{GetInstanceID ()}]" );
#else
  protected virtual void Awake () { }
#endif

  /// <summary>
  /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled
  /// </summary>
#if LOG_FIXEDUPDATE
  protected virtual void FixedUpdate () => Log ( nameof ( FixedUpdate ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void FixedUpdate () { }
#endif

  /// <summary>
  /// LateUpdate is called every frame, if the Behaviour is enabled
  /// </summary>
#if LOG_LATEUPDATE
  protected virtual void LateUpdate () => Log ( nameof ( LateUpdate ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void LateUpdate () { }
#endif

  /// <summary>
  /// Callback for setting up animation IK (inverse kinematics)
  /// </summary>
#if LOG_ONANIMATORIK
 protected virtual void OnAnimatorIK ( System.Int32 layerIndex ) => Log (  "OnAnimatorIK", $"{this} [{GetInstanceID ()}] ({layerIndex})" );
#else
  protected virtual void OnAnimatorIK ( System.Int32 layerIndex ) { }
#endif

  /// <summary>
  /// This callback will be invoked at each frame after the state machines and the animations have been evaluated, but before OnAnimatorIK
  /// </summary>
#if LOG_ONANIMATORMOVE
 protected virtual void OnAnimatorMove () => Log (  "OnAnimatorMove", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnAnimatorMove () { }
#endif

  /// <summary>
  /// Sent to all game objects when the player gets or loses focus
  /// </summary>
#if LOG_ONAPPLICATIONFOCUS
 protected virtual void OnApplicationFocus ( System.Boolean focus ) => Log (  "OnApplicationFocus", $"{this} [{GetInstanceID ()}] ({focus})" );
#else
  protected virtual void OnApplicationFocus ( System.Boolean focus ) { }
#endif

  /// <summary>
  /// Sent to all game objects when the player pauses
  /// </summary>
#if LOG_ONAPPLICATIONPAUSE
 protected virtual void OnApplicationPause ( System.Boolean pause ) => Log (  "OnApplicationPause", $"{this} [{GetInstanceID ()}] ({pause})" );
#else
  protected virtual void OnApplicationPause ( System.Boolean pause ) { }
#endif

  /// <summary>
  /// Sent to all game objects before the application is quit
  /// </summary>
#if LOG_ONAPPLICATIONQUIT
 protected virtual void OnApplicationQuit () => Log (  "OnApplicationQuit", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnApplicationQuit () { }
#endif

  /// <summary>
  /// If OnAudioFilterRead is implemented, Unity will insert a custom filter into the audio DSP chain
  /// </summary>
#if LOG_ONAUDIOFILTERREAD
 protected virtual void OnAudioFilterRead ( System.Single[] data, System.Int32 channels ) => Log (  "OnAudioFilterRead", $"{this} [{GetInstanceID ()}] ({data}, {channels})" );
#else
  protected virtual void OnAudioFilterRead ( System.Single[] data, System.Int32 channels ) { }
#endif

  /// <summary>
  /// OnBecameInvisible is called when the renderer is no longer visible by any camera
  /// </summary>
#if LOG_ONBECAMEINVISIBLE
 protected virtual void OnBecameInvisible () => Log (  "OnBecameInvisible", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnBecameInvisible () { }
#endif

  /// <summary>
  /// OnBecameVisible is called when the renderer became visible by any camera
  /// </summary>
#if LOG_ONBECAMEVISIBLE
 protected virtual void OnBecameVisible () => Log (  "OnBecameVisible", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnBecameVisible () { }
#endif

  /// <summary>
  /// Callback sent to the graphic before a Transform parent change occurs
  /// </summary>
#if LOG_ONBEFORETRANSFORMPARENTCHANGED
 protected virtual void OnBeforeTransformParentChanged () => Log (  "OnBeforeTransformParentChanged", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnBeforeTransformParentChanged () { }
#endif

  /// <summary>
  /// Callback that is sent if the canvas group is changed
  /// </summary>
#if LOG_ONCANVASGROUPCHANGED
 protected virtual void OnCanvasGroupChanged () => Log (  "OnCanvasGroupChanged", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnCanvasGroupChanged () { }
#endif

  /// <summary>
  /// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
  /// </summary>
#if LOG_ONCOLLISIONENTER
 protected virtual void OnCollisionEnter ( UnityEngine.Collision collision ) => Log (  "OnCollisionEnter", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionEnter ( UnityEngine.Collision collision ) { }
#endif

  /// <summary>
  /// OnCollisionEnter2D is called when this collider2D/rigidbody2D has begun touching another rigidbody2D/collider2D (2D physics only)
  /// </summary>
#if LOG_ONCOLLISIONENTER2D
 protected virtual void OnCollisionEnter2D ( UnityEngine.Collision2D collision ) => Log (  "OnCollisionEnter2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionEnter2D ( UnityEngine.Collision2D collision ) { }
#endif

  /// <summary>
  /// OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider
  /// </summary>
#if LOG_ONCOLLISIONEXIT
 protected virtual void OnCollisionExit ( UnityEngine.Collision collision ) => Log (  "OnCollisionExit", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionExit ( UnityEngine.Collision collision ) { }
#endif

  /// <summary>
  /// OnCollisionExit2D is called when this collider2D/rigidbody2D has stopped touching another rigidbody2D/collider2D (2D physics only)
  /// </summary>
#if LOG_ONCOLLISIONEXIT2D
 protected virtual void OnCollisionExit2D ( UnityEngine.Collision2D collision ) => Log (  "OnCollisionExit2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionExit2D ( UnityEngine.Collision2D collision ) { }
#endif

  /// <summary>
  /// OnCollisionStay is called once per frame for every collider/rigidbody that is touching rigidbody/collider
  /// </summary>
#if LOG_ONCOLLISIONSTAY
 protected virtual void OnCollisionStay ( UnityEngine.Collision collision ) => Log (  "OnCollisionStay", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionStay ( UnityEngine.Collision collision ) { }
#endif

  /// <summary>
  /// OnCollisionStay2D is called once per frame for every collider2D/rigidbody2D that is touching rigidbody2D/collider2D (2D physics only)
  /// </summary>
#if LOG_ONCOLLISIONSTAY2D
 protected virtual void OnCollisionStay2D ( UnityEngine.Collision2D collision ) => Log (  "OnCollisionStay2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnCollisionStay2D ( UnityEngine.Collision2D collision ) { }
#endif

  /// <summary>
  /// Called on the client when you have successfully connected to a server
  /// </summary>
#if LOG_ONCONNECTEDTOSERVER
 protected virtual void OnConnectedToServer () => Log (  "OnConnectedToServer", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnConnectedToServer () { }
#endif

  /// <summary>
  /// OnControllerColliderHit is called when the controller hits a collider while performing a Move
  /// </summary>
#if LOG_ONCONTROLLERCOLLIDERHIT
 protected virtual void OnControllerColliderHit ( UnityEngine.ControllerColliderHit hit ) => Log (  "OnControllerColliderHit", $"{this} [{GetInstanceID ()}] ({hit})" );
#else
  protected virtual void OnControllerColliderHit ( UnityEngine.ControllerColliderHit hit ) { }
#endif

  /// <summary>
  /// This function is called when the MonoBehaviour will be destroyed
  /// </summary>
#if LOG_ONDESTROY
  protected virtual void OnDestroy () => Log ( nameof ( OnDestroy ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnDestroy () { }
#endif

  /// <summary>
  /// This function is called when the behaviour becomes disabled or inactive
  /// </summary>
#if LOG_ONDISABLE
  protected virtual void OnDisable () => Log ( nameof ( OnDisable ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnDisable () { }
#endif

  /// <summary>
  /// Implement this OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn
  /// </summary>
#if LOG_ONDRAWGIZMOS
 protected virtual void OnDrawGizmos () => Log (  "OnDrawGizmos", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnDrawGizmos () { }
#endif

  /// <summary>
  /// Implement this OnDrawGizmosSelected if you want to draw gizmos only if the object is selected
  /// </summary>
#if LOG_ONDRAWGIZMOSSELECTED
 protected virtual void OnDrawGizmosSelected () => Log (  "OnDrawGizmosSelected", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnDrawGizmosSelected () { }
#endif

  /// <summary>
  /// This function is called when the object becomes enabled and active
  /// </summary>
#if LOG_ONENABLE
  protected virtual void OnEnable () => Log ( nameof ( OnEnable ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnEnable () { }
#endif

  /// <summary>
  /// OnGUI is called for rendering and handling GUI events
  /// </summary>
#if LOG_ONGUI
  protected virtual void OnGUI () => Log ( nameof ( OnGUI ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnGUI () { }
#endif

  /// <summary>
  /// Called when a joint attached to the same game object broke
  /// </summary>
#if LOG_ONJOINTBREAK
 protected virtual void OnJointBreak ( System.Single breakForce ) => Log (  "OnJointBreak", $"{this} [{GetInstanceID ()}] ({breakForce})" );
#else
  protected virtual void OnJointBreak ( System.Single breakForce ) { }
#endif

  /// <summary>
  /// Called when a Joint2D attached to the same game object broke (2D physics only)
  /// </summary>
#if LOG_ONJOINTBREAK2D
 protected virtual void OnJointBreak2D ( UnityEngine.Joint2D joint ) => Log (  "OnJointBreak2D", $"{this} [{GetInstanceID ()}] ({joint})" );
#else
  protected virtual void OnJointBreak2D ( UnityEngine.Joint2D joint ) { }
#endif

  /// <summary>
  /// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
  /// </summary>
#if LOG_ONMOUSEDOWN
 protected virtual void OnMouseDown () => Log (  "OnMouseDown", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseDown () { }
#endif

  /// <summary>
  /// OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse
  /// </summary>
#if LOG_ONMOUSEDRAG
 protected virtual void OnMouseDrag () => Log (  "OnMouseDrag", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseDrag () { }
#endif

  /// <summary>
  /// OnMouseEnter is called when the mouse entered the GUIElement or Collider
  /// </summary>
#if LOG_ONMOUSEENTER
 protected virtual void OnMouseEnter () => Log (  "OnMouseEnter", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseEnter () { }
#endif

  /// <summary>
  /// OnMouseExit is called when the mouse is no longer over the GUIElement or Collider
  /// </summary>
#if LOG_ONMOUSEEXIT
 protected virtual void OnMouseExit () => Log (  "OnMouseExit", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseExit () { }
#endif

  /// <summary>
  /// OnMouseOver is called every frame while the mouse is over the GUIElement or Collider
  /// </summary>
#if LOG_ONMOUSEOVER
 protected virtual void OnMouseOver () => Log (  "OnMouseOver", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseOver () { }
#endif

  /// <summary>
  /// OnMouseUp is called when the user has released the mouse button
  /// </summary>
#if LOG_ONMOUSEUP
 protected virtual void OnMouseUp () => Log ( $"OnMouseUp : {this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseUp () { }
#endif

  /// <summary>
  /// OnMouseUpAsButton is only called when the mouse is released over the same GUIElement or Collider as it was pressed
  /// </summary>
#if LOG_ONMOUSEUPASBUTTON
 protected virtual void OnMouseUpAsButton () => Log (  "OnMouseUpAsButton", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnMouseUpAsButton () { }
#endif

  /// <summary>
  /// OnParticleCollision is called when a particle hits a collider
  /// </summary>
#if LOG_ONPARTICLECOLLISION
 protected virtual void OnParticleCollision ( UnityEngine.GameObject other ) => Log (  "OnParticleCollision", $"{this} [{GetInstanceID ()}] ({other})" );
#else
  protected virtual void OnParticleCollision ( UnityEngine.GameObject other ) { }
#endif

  /// <summary>
  /// Called when any particles in a particle system meet the conditions in the trigger module
  /// </summary>
#if LOG_ONPARTICLETRIGGER
 protected virtual void OnParticleTrigger () => Log (  "OnParticleTrigger", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnParticleTrigger () { }
#endif

  /// <summary>
  /// OnPostRender is called after a camera finished rendering the scene
  /// </summary>
#if LOG_ONPOSTRENDER
 protected virtual void OnPostRender () => Log (  "OnPostRender", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnPostRender () { }
#endif

  /// <summary>
  /// OnPreCull is called before a camera culls the scene
  /// </summary>
#if LOG_ONPRECULL
 protected virtual void OnPreCull () => Log (  "OnPreCull", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnPreCull () { }
#endif

  /// <summary>
  ///  OnPreRender is called before a camera starts rendering the scene
  /// </summary>
#if LOG_ONPRERENDER
 protected virtual void OnPreRender () => Log (  "OnPreRender", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnPreRender () { }
#endif

  /// <summary>
  /// Callback that is sent if an associated RectTransform has it's dimensions changed
  /// </summary>
#if LOG_ONRECTTRANSFORMDIMENSIONSCHANGE
 protected virtual void OnRectTransformDimensionsChange () => Log (  "OnRectTransformDimensionsChange", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnRectTransformDimensionsChange () { }
#endif

  /// <summary>
  /// Callback that is sent if an associated RectTransform is removed
  /// </summary>
#if LOG_ONRECTTRANSFORMREMOVED
 protected virtual void OnRectTransformRemoved () => Log (  "OnRectTransformRemoved", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnRectTransformRemoved () { }
#endif

  /// <summary>
  /// OnRenderImage is called after all rendering is complete to render image.
  /// Set LOG_ONRENDERIMAGE_BLITLESS if you don't want LOG_ONRENDERIMAGE to blit for you.
  /// </summary>
#if LOG_ONRENDERIMAGE

#if LOG_ONRENDERIMAGE_BLITLESS

#warning Set LOG_ONRENDERIMAGE_BLITLESS if you don't want LOG_ONRENDERIMAGE to blit for you.

 protected virtual void OnRenderImage ( UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination ) => Log (  "OnRenderImage", $"{this} [{GetInstanceID ()}] ({source}, {destination})" );
#else
  protected virtual void OnRenderImage ( UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination ) {
   Log (  "OnRenderImage", $"{this} [{GetInstanceID ()}] ({source}, {destination})" );
   UnityEngine.Graphics.Blit ( source, destination );
  }
#endif

#else

#if LOG_ONRENDERIMAGE_BLITLESS

#warning Set LOG_ONRENDERIMAGE_BLITLESS if you don't want LOG_ONRENDERIMAGE to blit for you.

 protected virtual void OnRenderImage ( UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination ) { }
#else
  protected virtual void OnRenderImage ( UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination ) => UnityEngine.Graphics.Blit ( source, destination );
#endif

#endif

  /// <summary>
  /// OnRenderObject is called after camera has rendered the scene
  /// </summary>
#if LOG_ONRENDEROBJECT
 protected virtual void OnRenderObject () => Log (  "OnRenderObject", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnRenderObject () { }
#endif

  /// <summary>
  /// Called on the server whenever a Network.InitializeServer was invoked and has completed
  /// </summary>
#if LOG_ONSERVERINITIALIZED
 protected virtual void OnServerInitialized () => Log (  "OnServerInitialized", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnServerInitialized () { }
#endif

  /// <summary>
  /// Callback sent to the graphic afer a Transform children change occurs
  /// </summary>
#if LOG_ONTRANSFORMCHILDRENCHANGED
 protected virtual void OnTransformChildrenChanged () => Log (  "OnTransformChildrenChanged", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnTransformChildrenChanged () { }
#endif

  /// <summary>
  /// Callback sent to the graphic afer a Transform parent change occurs
  /// </summary>
#if LOG_ONTRANSFORMPARENTCHANGED
 protected virtual void OnTransformParentChanged () => Log (  "OnTransformParentChanged", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnTransformParentChanged () { }
#endif

  /// <summary>
  /// OnTriggerEnter is called when the Collider other enters the trigger
  /// </summary>
#if LOG_ONTRIGGERENTER
 protected virtual void OnTriggerEnter ( UnityEngine.Collider other ) => Log (  "OnTriggerEnter", $"{this} {GetInstanceID ()} ({other})" );
#else
  protected virtual void OnTriggerEnter ( UnityEngine.Collider other ) { }
#endif

  /// <summary>
  /// OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
  /// </summary>
#if LOG_ONTRIGGERENTER2D
 protected virtual void OnTriggerEnter2D ( UnityEngine.Collider2D collision ) => Log (  "OnTriggerEnter2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnTriggerEnter2D ( UnityEngine.Collider2D collision ) { }
#endif

  /// <summary>
  /// OnTriggerExit is called when the Collider other has stopped touching the trigger
  /// </summary>
#if LOG_ONTRIGGEREXIT
 protected virtual void OnTriggerExit ( UnityEngine.Collider other ) => Log (  "OnTriggerExit", $"{this} [{GetInstanceID ()}] ({other})" );
#else
  protected virtual void OnTriggerExit ( UnityEngine.Collider other ) { }
#endif

  /// <summary>
  /// OnTriggerExit2D is called when the Collider2D other has stopped touching the trigger (2D physics only)
  /// </summary>
#if LOG_ONTRIGGEREXIT2D
 protected virtual void OnTriggerExit2D ( UnityEngine.Collider2D collision ) => Log (  "OnTriggerExit2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnTriggerExit2D ( UnityEngine.Collider2D collision ) { }
#endif

  /// <summary>
  /// OnTriggerStay is called once per frame for every Collider other that is touching the trigger
  /// </summary>
#if LOG_ONTRIGGERSTAY
 protected virtual void OnTriggerStay ( UnityEngine.Collider other ) => Log (  "OnTriggerStay", $"{this} [{GetInstanceID ()}] ({other})" );
#else
  protected virtual void OnTriggerStay ( UnityEngine.Collider other ) { }
#endif

  /// <summary>
  /// OnTriggerStay2D is called once per frame for every Collider2D other that is touching the trigger (2D physics only)
  /// </summary>
#if LOG_ONTRIGGERSTAY2D
 protected virtual void OnTriggerStay2D ( UnityEngine.Collider2D collision ) => Log (  "OnTriggerStay2D", $"{this} [{GetInstanceID ()}] ({collision})" );
#else
  protected virtual void OnTriggerStay2D ( UnityEngine.Collider2D collision ) { }
#endif

  /// <summary>
  /// This function is called when the script is loaded or a value is changed in the inspector (Called in the editor only)
  /// </summary>
#if LOG_ONVALIDATE
 protected virtual void OnValidate () => Log (  "OnValidate", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnValidate () { }
#endif

  /// <summary>
  /// OnWillRenderObject is called once for each camera if the object is visible
  /// </summary>
#if LOG_ONWILLRENDEROBJECT
 protected virtual void OnWillRenderObject () => Log (  "OnWillRenderObject", $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void OnWillRenderObject () { }
#endif

  /// <summary>
  /// Reset to default values
  /// </summary>
#if LOG_RESET
  protected virtual void Reset () => Log ( nameof ( Reset ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void Reset () { }
#endif

  /// <summary>
  /// Start is called just before any of the Update methods is called the first time
  /// </summary>
#if LOG_START
  protected virtual void Start () => Log ( nameof ( Start ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void Start () { }
#endif

  /// <summary>
  /// Update is called every frame, if the MonoBehaviour is enabled
  /// </summary>
#if LOG_UPDATE
  protected virtual void Update () => Log ( nameof ( Update ), $"{this} [{GetInstanceID ()}]" );
#else
  protected virtual void Update () { }
#endif
 }
}