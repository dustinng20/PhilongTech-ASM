using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class SamsungNote10 : Samsung
	{
		public SamsungNote10(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Samsung Note 10";
			_color = new GoldColor();
			_battery = new StrongBattery();
			_quickcharge = new Charge40();
		}
	}
}
