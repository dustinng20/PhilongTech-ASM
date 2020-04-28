using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	class Oppo : ICellPhone
	{
		protected string _model;
		protected IColor _color;
		protected IBattery _battery;
		protected IQuickCharge _quickcharge;

		public Oppo(IColor color, IBattery battery, IQuickCharge quickcharge)
		{
			_color = color;
			_battery = battery;
			_quickcharge = quickcharge;
		}
		public string GetModel()
		{
			return _model;
		}
		public IColor GetColor()
		{
			return _color;
		}
		public IBattery GetBattery()
		{
			return _battery;
		}
		public IQuickCharge GetQuickCharge()
		{
			return _quickcharge;
		}

		public string GetMode()
		{
			throw new NotImplementedException();
		}
	}

}
