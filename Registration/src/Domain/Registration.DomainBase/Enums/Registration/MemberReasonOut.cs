using System.ComponentModel;

namespace Registration.DomainBase.Enums.Registration;

public enum MemberReasonOut
{
    [Description("Abandono")]
    ABANDONO = 1,
    [Description("Solicitacao")]
    SOLICITACAO = 2,
    [Description("Falecimento")]
    FALECIMENTO = 3
}
