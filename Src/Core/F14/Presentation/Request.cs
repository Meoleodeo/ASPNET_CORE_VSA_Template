using F14.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace F14.Presentation;

[ValidateNever]
public sealed class Request
{
    [FromRoute]
    public long TodoTaskId { get; set; }

    [FromRoute]
    public long TodoTaskListId { get; set; }

    [FromQuery(Name = Constant.Url.Query.NumberOfRecord)]
    public int NumberOfRecord { get; set; }
}
