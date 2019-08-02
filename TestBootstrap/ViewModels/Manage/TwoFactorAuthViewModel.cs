
namespace DiaryAppOlga.ViewModels.Manage
{
    public class TwoFactorAuthViewModel
    {
        public bool HasAuthenticator { get; set; }
        public int RecoveryCodesLeft { get; set; }
        public bool Is2faEnabled { get; set; }
    }
}
