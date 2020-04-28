using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public class NormalBattery : IBattery
	{
		public string GetBatteryType()
		{
			return "Battery is 2000mAh";
		}
	}
}
