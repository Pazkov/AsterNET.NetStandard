using AsterNET.NetStandard.Manager.Event;
using System;

namespace AsterNET.NetStandard.Manager.Action
{
    /// <summary>
    /// Show queue summary
    /// </summary>
    /// <seealso cref="Manager.Action.QueueStatusAction" />
    public class QueueSummaryAction : ManagerActionEvent
    {
        #region Action

        /// <summary>
        ///     Get the name of this action, i.e. "QueueSummary".
        /// </summary>
        public override string Action
        {
            get { return "QueueSummary"; }
        }

        #endregion

        #region Queue

        /// <summary>
        ///     Name of queue
        /// </summary>
        public string Queue { get; set; }

        #endregion

        #region QueueSummaryAction(string queue)

        public QueueSummaryAction(string queue)
        {
            Queue = queue;
        }

        #endregion

        #region ActionCompleteEventClass()

        public override Type ActionCompleteEventClass()
        {
            return typeof(QueueSummaryEvent);
        }

        #endregion
    }
}
