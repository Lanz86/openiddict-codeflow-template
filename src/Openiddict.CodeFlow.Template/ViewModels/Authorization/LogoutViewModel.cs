using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Openiddict.CodeFlow.Template.ViewModels.Authorization;

public class LogoutViewModel
{
    [BindNever]
    public string RequestId { get; set; }
}
