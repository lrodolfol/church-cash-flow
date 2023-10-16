using Flunt.Notifications;
using Flunt.Validations;
using Registration.DomainBase.Enums.Registration;

namespace Registration.Mapper.DTOs.Registration.MemberIn;

public class EditMemberInDto : ModelDto
{
    public string ChurchName { get; set; } = null!;
    public string LastPost { get; set; } = null!;
    public string LetterReceiver { get; set; } = null!;
    public int MemberId { get; set; }

    public void Validate()
    {
        if (!Enum.IsDefined(typeof(MemberLetterReceiver), LetterReceiver.Replace(" ","_").ToUpper()))
            AddNotification(new Notification("LetterReceiver", "LetterReceiver is not valid"));        

        AddNotifications(new Contract<Notification>()
            .IsNotNullOrEmpty(ChurchName, "ChurchName", "ChurchName cannot be null")
            .IsNotNullOrEmpty(LastPost, "LastPost", "LastPost cannot be null")
            .IsNotNullOrEmpty(LetterReceiver, "LetterReceiver", "LetterReceiver cannot be null")
            .IsNotNull(MemberId, "MemberId", "MemberId cannot be null")
            );
    }
}