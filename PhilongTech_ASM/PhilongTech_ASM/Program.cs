using System;

namespace PhilongTech_ASM
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Phi Long Technology!");
			Console.ReadLine();

			Console.WriteLine("This is a High-end smartphone of Samsung Factory");
			ICellPhoneFactory cellPhoneFactory = new SamsungFactory();
			ICellPhone samsung = cellPhoneFactory.GetHighEnd();
			IColor color = samsung.GetColor();
			IBattery battery = samsung.GetBattery();
			IQuickCharge quickcharge = samsung.GetQuickCharge();

			Console.WriteLine(color.GetColorType());
			Console.WriteLine(battery.GetBatteryType());
			Console.WriteLine(quickcharge.GetQuickChargeType());
			Console.ReadLine();

			Console.WriteLine("------------------------------------------");
			Console.ReadLine();

			Console.WriteLine("This is a Mid-range smartphone of Oppo Factory");
			ICellPhoneFactory cellPhoneFactory2 = new OppoFactory();
			ICellPhone oppo = cellPhoneFactory.GetMidRange();
			IColor color2 = oppo.GetColor();
			IBattery battery2 = oppo.GetBattery();
			IQuickCharge quickcharge2 = oppo.GetQuickCharge();

			Console.WriteLine(color2.GetColorType());
			Console.WriteLine(battery2.GetBatteryType());
			Console.WriteLine(quickcharge2.GetQuickChargeType());
			Console.ReadLine();

			Console.WriteLine("------------------------------------------");
			Console.ReadLine();

			Console.WriteLine("This is a Lower-end smartphone of IPhone Factory");
			ICellPhoneFactory cellPhoneFactory3 = new IPhoneFactory();
			ICellPhone iphone = cellPhoneFactory.GetLowerEnd();
			IColor color3 = iphone.GetColor();
			IBattery battery3 = iphone.GetBattery();
			IQuickCharge quickcharge3 = iphone.GetQuickCharge();

			Console.WriteLine(color3.GetColorType());
			Console.WriteLine(battery3.GetBatteryType());
			Console.WriteLine(quickcharge3.GetQuickChargeType());
			Console.ReadLine();
		}
	}
}
