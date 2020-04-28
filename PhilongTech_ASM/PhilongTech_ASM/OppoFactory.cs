using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public class OppoFactory : ICellPhoneFactory
	{
		public ICellPhone GetHighEnd()
		{
			return new Oppo(new GoldColor(), new StrongBattery(), new Charge40());
		}
		public ICellPhone GetMidRange()
		{
			return new Oppo(new BlackColor(), new NormalBattery(), new Charge40());
		}
		public ICellPhone GetLowerEnd()
		{
			return new Oppo(new BlackColor(), new NormalBattery(), new Charge30());
		}
	}
}
