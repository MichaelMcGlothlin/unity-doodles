namespace Kavlon {
 public static class Application {
  public static System.String DataPath => UnityEngine.Application.dataPath;

  public static void Log ( System.String message ) => UnityEngine.Debug.Log ( message );

  public static void Log ( System.Exception exception ) => UnityEngine.Debug.LogWarning ( exception.StackTrace );

  public static void Quit () => UnityEngine.Application.Quit ();
 }
}