namespace Kavlon {
 public interface IAudioSource {
  UnityEngine.AudioSource AudioSource { get; }

  void PlayAudioClip ( UnityEngine.AudioClip audioClip = null );

  void PlayAudioClipAtCamera ( UnityEngine.AudioClip audioClip = null );

  void PlayAudioClipAtCamera ( System.Single volume, UnityEngine.AudioClip audioClip = null );
 }

 public static class IAudioSourceExtensions {
  public static UnityEngine.AudioSource GetAudioSourceComponent ( this IAudioSource audioSource ) => ( audioSource as UnityEngine.Component )?.GetComponent<UnityEngine.AudioSource> ();

  public static void PlayAudioClip ( this IAudioSource audioSource, UnityEngine.AudioClip audioClip = null ) => UnityEngine.AudioSource.PlayClipAtPoint ( audioClip ?? audioSource.AudioSource.clip, ( ( audioSource as UnityEngine.Component ) ?? UnityEngine.Camera.main ).transform.position );

  public static void PlayAudioClip ( this IAudioSource audioSource, System.Single volume, UnityEngine.AudioClip audioClip = null ) => UnityEngine.AudioSource.PlayClipAtPoint ( audioClip ?? audioSource.AudioSource.clip, ( ( audioSource as UnityEngine.Component ) ?? UnityEngine.Camera.main ).transform.position, volume );

  public static void PlayOneShot ( this IAudioSource audioSource, UnityEngine.AudioClip audioClip = null ) => audioSource.AudioSource.PlayOneShot ( audioClip ?? audioSource.AudioSource.clip );

  public static void PlayOneShot ( this IAudioSource audioSource, System.Single volume, UnityEngine.AudioClip audioClip = null ) => audioSource.AudioSource.PlayOneShot ( audioClip ?? audioSource.AudioSource.clip, volume );
 }
}