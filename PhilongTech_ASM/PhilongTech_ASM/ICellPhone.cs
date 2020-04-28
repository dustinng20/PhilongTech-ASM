using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public interface ICellPhone
	{
		string GetMode();
		IColor GetColor();
		IBattery GetBattery();
		IQuickCharge GetQuickCharge();
	}
}
