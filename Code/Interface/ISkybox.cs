namespace Kavlon {
 public interface ISkybox {
  UnityEngine.Skybox Skybox { get; }

  System.Single SkyboxRotation { get; set; }
 }

 public static class SkyboxExtensions {
  public static UnityEngine.Skybox GetSkybox ( this ISkybox skybox ) => ( skybox as UnityEngine.Component )?.GetComponent<UnityEngine.Skybox> ();

  public static System.Single GetRotation ( this ISkybox skybox ) => skybox.Skybox.material.GetFloat ( "_Rotation" );

  public static void SetRotation ( this ISkybox skybox, System.Single rotation ) => skybox.Skybox.material.SetFloat ( "_Rotation", rotation );
 }
}