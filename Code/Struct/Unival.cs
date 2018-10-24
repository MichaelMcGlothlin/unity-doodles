namespace Kavlon {
 /// <summary>
 /// Unit Interval [0..1].
 /// </summary>
 public struct Unival {
  private System.Single _value;

  /// <summary>
  /// Create a Unival from a value. If value is out of range [0..1] an ArgumentOutOfRangeException
  /// will be thrown.
  /// </summary>
  /// <param name="value">Value.</param>
  public Unival ( System.Single value ) {
   if ( ( value < 0 ) || ( value > 1 ) ) {
    throw new System.ArgumentOutOfRangeException ( nameof ( value ), "Unit intervals should be between zero and one." );
   }
   _value = value;
  }

  public static implicit operator System.Single ( Unival unival ) => unival._value;

  public static implicit operator Unival ( System.Single single ) => Clamped ( single );

  private static System.Single _clamp ( System.Single value ) => System.Math.Max ( 0, System.Math.Min ( 1, value ) );

  /// <summary>
  /// Creates a new Unival from a value that has been clamped to the correct range.
  /// </summary>
  /// <returns>Unival</returns>
  /// <param name="value">Value.</param>
  public static Unival Clamped ( System.Single value ) => new Unival ( _clamp ( value ) );
 }
}