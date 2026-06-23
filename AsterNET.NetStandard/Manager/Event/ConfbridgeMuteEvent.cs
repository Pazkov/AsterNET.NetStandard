namespace AsterNET.NetStandard.Manager.Event
{
    /// <summary>
    ///     Raised when a confbridge participant is muted.<br />
    /// </summary>
    public class ConfbridgeMuteEvent : AbstractConfbridgeEvent
    {
        public ConfbridgeMuteEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}
