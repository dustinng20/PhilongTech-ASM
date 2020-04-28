using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class OppoReno2 : Oppo
	{
		public OppoReno2(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_model = "Oppo Reno 2";
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge30();
		}
	}
}
