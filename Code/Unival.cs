namespace Kavlon {
 /// <summary>
 /// Unit Interval [0..1].
 /// </summary>
 public struct Unival {
  private System.Single _value;

  public Unival ( System.Single value ) {
   if ( ( value < 0 ) || ( value > 1 ) ) {
    throw new System.ArgumentOutOfRangeException ( nameof ( value ), "Unit intervals should be between zero and one." );
   }
   _value = value;
  }

  public static implicit operator System.Single ( Unival unival ) => unival._value;

  public static implicit operator Unival ( System.Single single ) => new Unival ( single );
 }
}