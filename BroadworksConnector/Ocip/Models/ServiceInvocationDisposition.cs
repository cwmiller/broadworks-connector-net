using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates the type of service invocation that caused the call to be detached.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceInvocationDisposition    {
            [XmlEnum(Name = "Automatic Hold/Retrieve")]
        AutomaticHoldRetrieve,
            [XmlEnum(Name = "Call Forward Always")]
        CallForwardAlways,
            [XmlEnum(Name = "Call Forward Busy")]
        CallForwardBusy,
            [XmlEnum(Name = "Call Forward No Answer")]
        CallForwardNoAnswer,
            [XmlEnum(Name = "Call Forward Not Reachable")]
        CallForwardNotReachable,
            [XmlEnum(Name = "Call Forward Selective")]
        CallForwardSelective,
            [XmlEnum(Name = "Call Park")]
        CallPark,
            [XmlEnum(Name = "Call Pickup")]
        CallPickup,
            [XmlEnum(Name = "Deflection")]
        Deflection,
            [XmlEnum(Name = "Directed Call Pickup")]
        DirectedCallPickup,
            [XmlEnum(Name = "Distribution from Call Center")]
        DistributionfromCallCenter,
            [XmlEnum(Name = "Distribution from Hunt Group")]
        DistributionfromHuntGroup,
            [XmlEnum(Name = "Distribution from Route Point")]
        DistributionfromRoutePoint,
            [XmlEnum(Name = "Do Not Disturb")]
        DoNotDisturb,
            [XmlEnum(Name = "Fax Deposit")]
        FaxDeposit,
            [XmlEnum(Name = "Group Night Forwarding")]
        GroupNightForwarding,
            [XmlEnum(Name = "Sequential Ring")]
        SequentialRing,
            [XmlEnum(Name = "Series Completion")]
        SeriesCompletion,
            [XmlEnum(Name = "Simultaneous Ring")]
        SimultaneousRing,
            [XmlEnum(Name = "Third Party Deflection")]
        ThirdPartyDeflection,
            [XmlEnum(Name = "Third Party Voice Mail Support")]
        ThirdPartyVoiceMailSupport,
            [XmlEnum(Name = "Transfer Consult")]
        TransferConsult,
            [XmlEnum(Name = "Trunk Group Forward Capacity Exceeded")]
        TrunkGroupForwardCapacityExceeded,
            [XmlEnum(Name = "Trunk Group Forward Unreachable")]
        TrunkGroupForwardUnreachable,
            [XmlEnum(Name = "Trunk Group Forward Unconditional")]
        TrunkGroupForwardUnconditional,
            [XmlEnum(Name = "Voice Mail Transfer")]
        VoiceMailTransfer,
            [XmlEnum(Name = "Voice Messaging")]
        VoiceMessaging,
            [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
     }
}
