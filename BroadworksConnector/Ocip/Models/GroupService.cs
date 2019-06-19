using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group level services.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupService
    {
        [XmlEnum(Name = "Account/Authorization Codes")]
        AccountAuthorizationCodes,
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "Auto Attendant - Video")]
        AutoAttendantVideo,
        [XmlEnum(Name = "Auto Attendant - Standard")]
        AutoAttendantStandard,
        [XmlEnum(Name = "Call Capacity Management")]
        CallCapacityManagement,
        [XmlEnum(Name = "Call Park")]
        CallPark,
        [XmlEnum(Name = "Call Pickup")]
        CallPickup,
        [XmlEnum(Name = "City-Wide Centrex")]
        CityWideCentrex,
        [XmlEnum(Name = "Custom Ringback Group")]
        CustomRingbackGroup,
        [XmlEnum(Name = "Custom Ringback Group - Video")]
        CustomRingbackGroupVideo,
        [XmlEnum(Name = "Emergency Zones")]
        EmergencyZones,
        [XmlEnum(Name = "Enhanced Outgoing Calling Plan")]
        EnhancedOutgoingCallingPlan,
        [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
        [XmlEnum(Name = "Group Paging")]
        GroupPaging,
        [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
        [XmlEnum(Name = "Incoming Calling Plan")]
        IncomingCallingPlan,
        [XmlEnum(Name = "Instant Group Call")]
        InstantGroupCall,
        [XmlEnum(Name = "Intercept Group")]
        InterceptGroup,
        [XmlEnum(Name = "Inventory Report")]
        InventoryReport,
        [XmlEnum(Name = "LDAP Integration")]
        LDAPIntegration,
        [XmlEnum(Name = "Meet-Me Conferencing")]
        MeetMeConferencing,
        [XmlEnum(Name = "Music On Hold")]
        MusicOnHold,
        [XmlEnum(Name = "Music On Hold - Video")]
        MusicOnHoldVideo,
        [XmlEnum(Name = "Outgoing Calling Plan")]
        OutgoingCallingPlan,
        [XmlEnum(Name = "Preferred Carrier Group")]
        PreferredCarrierGroup,
        [XmlEnum(Name = "Route Point")]
        RoutePoint,
        [XmlEnum(Name = "Series Completion")]
        SeriesCompletion,
        [XmlEnum(Name = "Service Scripts Group")]
        ServiceScriptsGroup,
        [XmlEnum(Name = "Trunk Group")]
        TrunkGroup,
        [XmlEnum(Name = "Voice Messaging Group")]
        VoiceMessagingGroup,
        [XmlEnum(Name = "VoiceXML")]
        VoiceXML,
    }
}
