using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class IPhone8Plus : IPhone
	{
		public IPhone8Plus(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge30();
			_model = "IPhone 8 Plus";
		}
	}
}
