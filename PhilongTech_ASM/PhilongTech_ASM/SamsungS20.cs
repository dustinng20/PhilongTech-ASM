using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class SamsungS20 : Samsung
	{
		public SamsungS20(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Samsung S 20";
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge30();
		}
	}
}
