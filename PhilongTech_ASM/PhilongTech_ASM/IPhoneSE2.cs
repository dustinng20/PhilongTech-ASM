using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class IPhoneSE2 : IPhone
	{
		public IPhoneSE2(IColor color, IBattery battery, IQuickCharge quickcharge) : base(color, battery, quickcharge)
		{
			_color = new GoldColor();
			_battery = new StrongBattery();
			_quickcharge = new Charge40();
			_model = "IPhone SE 2";
		}
	}
}
