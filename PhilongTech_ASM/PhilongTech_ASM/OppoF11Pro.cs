using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class OppoF11Pro :Oppo
	{
		public OppoF11Pro(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Oppo F11 Pro";
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge40();
		}
	}
}
