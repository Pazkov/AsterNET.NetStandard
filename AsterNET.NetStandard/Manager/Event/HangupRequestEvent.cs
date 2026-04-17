namespace AsterNET.NetStandard.Manager.Event
{
	/// <summary>
	/// A HangupRequestEvent is raised when a channel is hang up.<br/>
	/// </summary>
	public class HangupRequestEvent : AbstractChannelEvent
	{
		/// <inheritdoc />
		public HangupRequestEvent(ManagerConnection source) : base(source)
		{
		}

		/// <summary>
		/// Get/Set the cause of the hangup.
		/// </summary>
		public int Cause { get; set; }
	}
}