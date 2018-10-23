namespace Kavlon {
 public interface IPosition {
  UnityEngine.Vector2 Position { get; }

  System.Single X { get; set; }

  System.Single Y { get; set; }

  void SetPositionOffset ( UnityEngine.Vector2 position, UnityEngine.Vector2 offset );
 }
}