using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public class StrongBattery : IBattery
	{
		public string GetBatteryType()
		{
			return "Battery is 4000mAh";
		}
	}
}
