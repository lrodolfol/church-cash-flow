using HandlersTest.Builders.Dto;
using HandlersTest.Builders.Dtos;
using Registration.DomainBase.Entities.Registrations;
using Registration.Mapper.DTOs.Registration.OutFlowKind;

namespace HandlersTest.Builders.Entities;

public class OutFlowKindTest
{
    public static OutFlowKind ValidObjectOne() =>
        ConvertTo(EditOutFlowKindDtoTest.ValidObjectOne());
    public static OutFlowKind ValidObjectTwo() =>
        ConvertTo(EditOutFlowKindDtoTest.ValidObjectTwo());
    public static OutFlowKind ValidObjectThree() =>
        ConvertTo(EditOutFlowKindDtoTest.ValidObjectThree());
    public static OutFlowKind ValidObjectFour() =>
        ConvertTo(EditOutFlowKindDtoTest.ValidObjectFour());

    private static OutFlowKind ConvertTo(EditOutFlowKindDto dto) =>
        new OutFlowKind(dto.Id,dto.Name, dto.Description);
}