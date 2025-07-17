using Structural.Bridge.Implementation;

namespace Structural.Bridge.Abstraction;

public class VegetarianMenu(ICoupon coupon) : Menu(coupon)
{
    public override int CalculatePrice()
    {
        return 20 - Coupon.CouponValue; 
    }
}