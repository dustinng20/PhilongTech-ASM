using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class OppoFindX2 : Oppo
	{
		public OppoFindX2(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Oppo Find X2";
			_color = new GoldColor();
			_battery = new StrongBattery();
			_quickcharge = new Charge40();
		}
	}
}
