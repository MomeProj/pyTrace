using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyTrace
{
	public abstract class CommandItem
	{
		public abstract int CmdId { get;}
	}

	public class MsgCommandItem : CommandItem
	{
		protected int _commandId = 500;
		public override int CmdId { get {return _commandId; } }
		public string Msg {get;set;}="";
	}
}
