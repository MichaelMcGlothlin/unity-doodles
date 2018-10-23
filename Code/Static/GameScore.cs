namespace Kavlon {
 public static class GameScore {
  #region Events

  public static event System.EventHandler ResetEvent;

  private static void _onReset () => ResetEvent?.Invoke ( null, System.EventArgs.Empty );

  public static event System.EventHandler<System.Int32> PointsAddedEvent;

  private static void _onPointsAdded () => PointsAddedEvent?.Invoke ( null, Points );

  #endregion

  public static System.Int32 Points { get; private set; } = 0;

  public static void AddPoints ( System.Int32 points ) {
   Points += points;
   _onPointsAdded ();
  }

  public static void ResetPoints () {
   Points = 0;
   _onReset ();
  }
 }
}