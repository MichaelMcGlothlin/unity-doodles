namespace Kavlon {
 /// <summary>
 /// Enumerator that grows and shrinks endlessly.
 /// </summary>
 public class Pulse : System.Collections.Generic.IEnumerator<System.Single> {
  #region Static

  private const System.Int16 BYTE_DIVISOR = 256;

  private static System.Double SINGLE_DIVISOR = ( (System.Double) System.Single.MaxValue - System.Single.MinValue ) + 1;

  private static System.Random _random = new System.Random ();

  public static Pulse Random () {
   var random = _random.Next ();
   return new Pulse ( ( (System.Byte) ( random % BYTE_DIVISOR ) ), Equals ( random & 1, 0 ) );
  }

  #endregion

  #region IEnumerator

  public System.Single Current => (System.Single) _power / BYTE_DIVISOR;

  System.Object System.Collections.IEnumerator.Current => Current;

  public System.Boolean MoveNext () {
   if ( _growing ) {
    _power++;
   } else {
    _power--;
   }

   if ( Equals ( _power, System.Byte.MinValue ) || Equals ( _power, System.Byte.MaxValue ) ) {
    _growing = !_growing;
   }

   return true;
  }

  public void Reset () {
   _power = default ( System.Byte );
   _growing = default ( System.Boolean );
  }

  public void Dispose () { }

  #endregion

  public Pulse ( System.Single power, System.Boolean growing = default ( System.Boolean ) ) {
   _power = (System.Byte) ( ( power / SINGLE_DIVISOR ) * System.Byte.MaxValue );
   _growing = growing;
  }

  protected Pulse ( System.Byte power, System.Boolean growing = default ( System.Boolean ) ) {
   _power = power;
   _growing = growing;
  }

  public Pulse () : this ( 0 ) { }

  private System.Boolean _growing;

  private System.Byte _power;

  public System.Single Power {
   get {
    MoveNext ();
    return Current;
   }
  }
 }
}