using FCommon.FeatureService;

namespace F6.Models;

public sealed class AppRequestModel : IServiceRequest<AppResponseModel>
{
    public long AccessTokenId { get; set; }

    public long UserId { get; set; }

    public string RefreshToken { get; set; }
}
