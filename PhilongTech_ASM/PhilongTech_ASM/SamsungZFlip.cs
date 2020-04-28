using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class SamsungZFlip : Samsung
	{
		public SamsungZFlip(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Samsung Z Flip";
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge40();
		}
	}
}
