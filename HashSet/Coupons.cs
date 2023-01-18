namespace HashSet
{
    public class Coupons
    {
        public static void CouponsFunctionality()
        {
            HashSet<int> usedCoupons = new();

            do
            {
                Console.Write("Enter a coupon name: ");
                string couponString = Console.ReadLine();

                if (int.TryParse(couponString, out int coupon))
                {
                    if (usedCoupons.Contains(coupon))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It has been already used :-(");
                    }
                    else
                    {
                        usedCoupons.Add(coupon);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thank you :-)");
                    }
                }
                else
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("A list of used coupons:");

                    foreach (int usedCoupon in usedCoupons)
                    {
                        Console.WriteLine(usedCoupon);
                    }

                    break;
                }
            } while (true);
        }
    }
}
