using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public class IPhoneFactory : ICellPhoneFactory
	{
		public ICellPhone GetHighEnd()
		{
			return new IPhone(new GoldColor(), new StrongBattery(), new Charge40());
		}
		public ICellPhone GetMidRange()
		{
			return new IPhone(new BlackColor(), new NormalBattery(), new Charge40());
		}
		public ICellPhone GetLowerEnd()
		{
			return new IPhone(new BlackColor(), new NormalBattery(), new Charge30());
		}
	}
}
