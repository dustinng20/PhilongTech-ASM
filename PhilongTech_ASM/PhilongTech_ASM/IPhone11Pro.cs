using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class IPhone11Pro : IPhone
	{
		public IPhone11Pro(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color,battery,quickcharge)
		{
			_color = new BlackColor();
			_battery = new NormalBattery();
			_quickcharge = new Charge40();
			_model = "IPhone 11 Pro";
		}
	}
}
