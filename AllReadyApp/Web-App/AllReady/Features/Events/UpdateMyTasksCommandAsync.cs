using System.Collections.Generic;
using AllReady.ViewModels.Event;
using MediatR;

namespace AllReady.Features.Event
{
    public class UpdateMyTasksCommandAsync : IAsyncRequest
    {
        public string UserId { get; set; }
        public IEnumerable<TaskSignupViewModel> TaskSignups { get; set; }
    }
}