using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public class SamsungFactory : ICellPhoneFactory
	{
		public ICellPhone GetHighEnd()
		{
			return new Samsung(new GoldColor(), new StrongBattery(), new Charge40());
		}
		public ICellPhone GetMidRange()
		{
			return new Samsung(new BlackColor(), new NormalBattery(), new Charge40());
		}
		public ICellPhone GetLowerEnd()
		{
			return new Samsung(new BlackColor(), new NormalBattery(), new Charge30());
		}
	}
}
