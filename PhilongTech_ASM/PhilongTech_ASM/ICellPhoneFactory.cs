using System;
using System.Collections.Generic;
using System.Text;

namespace PhilongTech_ASM
{
	public interface ICellPhoneFactory
	{
			ICellPhone GetHighEnd();
			ICellPhone GetMidRange();
			ICellPhone GetLowerEnd();
	}
}
