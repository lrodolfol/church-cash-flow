using AutoMapper;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;

namespace HandlersTest.Builders.BaseHandlers;

public class MemberBridgeHandlerTest
{
    public MemberBridgesHandler GetHandler()
    {
        var memberInHand = new MemberInHandlerTest();
        var memberOutHand = new MemberOutHandlerTest();
        var memberPostHand = new MemberPostHandlerTest();

        var memberInHandler = memberInHand.GetHandler();
        var memberOutHandler = memberOutHand.GetHandler();
        var memberPostHandler = memberPostHand.GetHandler();

        var memberBridgeHandler = new MemberBridgesHandler(memberInHandler, memberOutHandler, memberPostHandler);

        return memberBridgeHandler;
    }
}