using System;
using System.Collections.Generic;

namespace BafflerStandalone
{
	public class HotKeyActionItem
	{
		private HotKeyAction m_action;
		private List<string> m_parms = new List<string>();
		
		public HotKeyAction Action
		{
			get
			{
				return this.m_action;
			}
		}

		public List<string> Params
		{
			get
			{
				return this.m_parms;
			}
		}

		public HotKeyActionItem(HotKeyAction action, List<string> parameters)
		{
			this.m_action = action;
			this.m_parms = parameters;
		}

		public string toString()
		{
			return this.m_action.ToString() + " (" + string.Join(",", this.m_parms.ToArray()) + ")";
		}
	}
}
