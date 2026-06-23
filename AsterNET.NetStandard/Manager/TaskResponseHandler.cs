using System.Threading.Tasks;
using AsterNET.NetStandard.Manager.Action;
using AsterNET.NetStandard.Manager.Response;

namespace AsterNET.NetStandard.Manager
{
    /// <summary>
    ///     A response handler that completes a <see cref="TaskCompletionSource{TResult}" /> when the
    ///     response is received, enabling asynchronous (await-able) action sending.
    /// </summary>
    public class TaskResponseHandler : ResponseHandler
    {
        private readonly TaskCompletionSource<ManagerResponse> taskCompletionSource;

        /// <summary>
        ///     Creates a new instance.
        /// </summary>
        /// <param name="action">the action that has been sent</param>
        /// <param name="taskCompletionSource">the task completion source to complete when the response is received</param>
        public TaskResponseHandler(ManagerAction action, TaskCompletionSource<ManagerResponse> taskCompletionSource)
            : base(action, null)
        {
            this.taskCompletionSource = taskCompletionSource;
        }

        public override void HandleResponse(ManagerResponse response)
        {
            taskCompletionSource.TrySetResult(response);
        }
    }
}
