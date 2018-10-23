namespace Kavlon {
 public interface ITextMesh {
  TMPro.TextMeshProUGUI TextMesh { get; }

  void SetText ( System.String text );
 }
}