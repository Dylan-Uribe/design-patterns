using Bridge.Implementation;

namespace Bridge.Abstraction;

public class VegetarianMenu(ICoupon coupon) : Menu(coupon)
{
    public override int CalculatePrice()
    {
        return 20 - Coupon.CouponValue; 
    }
}