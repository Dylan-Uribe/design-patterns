using Structural.Bridge.Implementation;

namespace Structural.Bridge.Abstraction;

public class MeatBasedMenu(ICoupon coupon) : Menu(coupon)
{
    public override int CalculatePrice()
    {
        return 30 - Coupon.CouponValue; 
    }
}