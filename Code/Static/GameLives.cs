namespace Kavlon {
 public static class GameLives {
  #region Events

  public static event System.EventHandler<System.Byte> LivesDownEvent;

  private static void _onLivesDown () => LivesDownEvent?.Invoke ( null, Lives );

  public static event System.EventHandler<System.Byte> LivesUpEvent;

  private static void _onLivesUp () => LivesUpEvent?.Invoke ( null, Lives );

  public static event System.EventHandler LivesGoneEvent;

  private static void _onLivesGone () => LivesGoneEvent?.Invoke ( null, System.EventArgs.Empty );

  public static event System.EventHandler ResetEvent;

  private static void _onReset () => ResetEvent?.Invoke ( null, System.EventArgs.Empty );

  #endregion

  public static System.Byte BaseLives { get; private set; }

  public static System.Boolean IsDead => Lives < 1;

  public static System.Byte Lives { get; private set; }

  public static System.Byte MaxLives { get; } = System.Byte.MaxValue;

  private static void _addLife () {
   Lives++;
   _onLivesUp ();
  }

  public static void AddLife () {
   if ( Lives < MaxLives ) {
    _addLife ();
   }
  }

  private static void _removeLife () {
   Lives--;
   _onLivesDown ();
   _ifDead ();
  }

  public static void RemoveLife () {
   if ( !IsDead ) {
    _removeLife ();
   }
  }

  public static void ResetLives () => Lives = BaseLives;

  public static void SetBaseLives ( System.Byte lives ) => BaseLives = lives;

  private static void _ifDead () {
   if ( IsDead ) {
    _onLivesGone ();
   }
  }
 }
}