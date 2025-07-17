using Bridge.Implementation;

namespace Bridge.Abstraction;

public abstract class Menu(ICoupon coupon)
{
    /*En el patrón Bridge, el campo que referencia a la implementación (ICoupon)
     suele ser protected para que las subclases de Menu puedan acceder a él, 
     pero no sea accesible desde fuera de la jerarquía de herencia. 
     Así se mantiene el principio de encapsulamiento y se permite la extensión en subclases.  
     La declaración actual protected readonly ICoupon Coupon; es la más adecuada para este caso.
     No es recomendable hacerlo public, ya que expondría detalles internos de la abstracción.*/
    protected readonly ICoupon Coupon = coupon;
    public abstract int CalculatePrice();
}