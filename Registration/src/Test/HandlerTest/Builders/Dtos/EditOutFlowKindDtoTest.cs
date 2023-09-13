using Registration.Mapper.DTOs.Registration.OutFlow;
using Registration.Mapper.DTOs.Registration.OutFlowKind;

namespace HandlersTest.Builders.Dtos;

public class EditOutFlowKindDtoTest
{
    public static EditOutFlowKindDto ValidObjectOne() =>
        new EditOutFlowKindDto() { Id = 1, Name = "Conta de Enegia", Description = "Conta de energia mensal" };
    public static EditOutFlowKindDto ValidObjectTwo() =>
        new EditOutFlowKindDto() { Id = 2, Name = "Conta de agua", Description = "Conta de água mensal" };
    public static EditOutFlowKindDto ValidObjectThree() =>
        new EditOutFlowKindDto() { Id = 3, Name = "Vonluntariado Pastor", Description = "Pagamento voluntariado do pastor mensal" };
    public static EditOutFlowKindDto ValidObjectFour() =>
        new EditOutFlowKindDto() { Id = 4, Name = "Zeladoria", Description = "Gastos para zeladoria da igreja" };
}