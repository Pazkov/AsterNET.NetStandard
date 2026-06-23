namespace AsterNET.NetStandard.Manager.Event
{
    /// <summary>
    ///     Raised when a confbridge participant is unmuted.<br />
    /// </summary>
    public class ConfbridgeUnmuteEvent : AbstractConfbridgeEvent
    {
        public ConfbridgeUnmuteEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}
