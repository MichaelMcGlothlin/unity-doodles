namespace Kavlon {
 public interface IPlayAudio : IAudioSource {
  System.Boolean IsPlaying { get; }

  UnityEngine.AudioClip SelectedSong { get; }

  System.Int32 SelectedSongIndex { get; }

  System.Collections.Generic.IEnumerable<UnityEngine.AudioClip> Songs { get; }

  System.Int32 SongCount { get; }

  System.Single Volume { get; set; }

  new void PlayAudioClip ( UnityEngine.AudioClip audioClip );

  void PlayFirstSong ();

  void PlayNextSong ();

  void PlayPreviousSong ();

  void PlayRandomSong ();

  void PlaySelectedSong ();

  void PlaySong ( System.Int32 songIndex );

  void StopPlaying ();
 }
}