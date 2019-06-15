using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User level services.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UserService    {
            [XmlEnum(Name = "3G/4G Continuity")]
        _3G4GContinuity,
            [XmlEnum(Name = "Advice Of Charge")]
        AdviceOfCharge,
            [XmlEnum(Name = "Alternate Numbers")]
        AlternateNumbers,
            [XmlEnum(Name = "Anonymous Call Rejection")]
        AnonymousCallRejection,
            [XmlEnum(Name = "Attendant Console")]
        AttendantConsole,
            [XmlEnum(Name = "Authentication")]
        Authentication,
            [XmlEnum(Name = "Automatic Callback")]
        AutomaticCallback,
            [XmlEnum(Name = "Automatic Collect Call")]
        AutomaticCollectCall,
            [XmlEnum(Name = "Automatic Hold/Retrieve")]
        AutomaticHoldRetrieve,
            [XmlEnum(Name = "Barge-in Exempt")]
        BargeinExempt,
            [XmlEnum(Name = "Basic Call Logs")]
        BasicCallLogs,
            [XmlEnum(Name = "Bria For BroadWorks")]
        BriaForBroadWorks,
            [XmlEnum(Name = "BroadTouch Business Communicator Desktop")]
        BroadTouchBusinessCommunicatorDesktop,
            [XmlEnum(Name = "BroadTouch Business Communicator Desktop - Audio")]
        BroadTouchBusinessCommunicatorDesktopAudio,
            [XmlEnum(Name = "BroadTouch Business Communicator Mobile")]
        BroadTouchBusinessCommunicatorMobile,
            [XmlEnum(Name = "BroadTouch Business Communicator Mobile - Audio")]
        BroadTouchBusinessCommunicatorMobileAudio,
            [XmlEnum(Name = "BroadTouch Business Communicator Tablet")]
        BroadTouchBusinessCommunicatorTablet,
            [XmlEnum(Name = "BroadTouch Business Communicator Tablet - Audio")]
        BroadTouchBusinessCommunicatorTabletAudio,
            [XmlEnum(Name = "BroadTouch Business Communicator Tablet - Video")]
        BroadTouchBusinessCommunicatorTabletVideo,
            [XmlEnum(Name = "BroadWorks Agent")]
        BroadWorksAgent,
            [XmlEnum(Name = "BroadWorks Anywhere")]
        BroadWorksAnywhere,
            [XmlEnum(Name = "BroadWorks Connector for Lotus Sametime")]
        BroadWorksConnectorforLotusSametime,
            [XmlEnum(Name = "BroadWorks Mobility")]
        BroadWorksMobility,
            [XmlEnum(Name = "BroadWorks Receptionist - Office")]
        BroadWorksReceptionistOffice,
            [XmlEnum(Name = "BroadWorks Receptionist - Small Business")]
        BroadWorksReceptionistSmallBusiness,
            [XmlEnum(Name = "BroadWorks Supervisor")]
        BroadWorksSupervisor,
            [XmlEnum(Name = "Busy Lamp Field")]
        BusyLampField,
            [XmlEnum(Name = "Call Center - Basic")]
        CallCenterBasic,
            [XmlEnum(Name = "Call Center Monitoring")]
        CallCenterMonitoring,
            [XmlEnum(Name = "Call Center - Standard")]
        CallCenterStandard,
            [XmlEnum(Name = "Call Center - Premium")]
        CallCenterPremium,
            [XmlEnum(Name = "Call Forwarding Always")]
        CallForwardingAlways,
            [XmlEnum(Name = "Call Forwarding Always Secondary")]
        CallForwardingAlwaysSecondary,
            [XmlEnum(Name = "Call Forwarding Busy")]
        CallForwardingBusy,
            [XmlEnum(Name = "Call Forwarding No Answer")]
        CallForwardingNoAnswer,
            [XmlEnum(Name = "Call Forwarding Not Reachable")]
        CallForwardingNotReachable,
            [XmlEnum(Name = "Call Forwarding Selective")]
        CallForwardingSelective,
            [XmlEnum(Name = "Call Me Now")]
        CallMeNow,
            [XmlEnum(Name = "Call Notify")]
        CallNotify,
            [XmlEnum(Name = "Call Recording")]
        CallRecording,
            [XmlEnum(Name = "Call Return")]
        CallReturn,
            [XmlEnum(Name = "Call Transfer")]
        CallTransfer,
            [XmlEnum(Name = "Call Waiting")]
        CallWaiting,
            [XmlEnum(Name = "Calling Line ID Blocking Override")]
        CallingLineIDBlockingOverride,
            [XmlEnum(Name = "Calling Line ID Delivery Blocking")]
        CallingLineIDDeliveryBlocking,
            [XmlEnum(Name = "Calling Name Delivery")]
        CallingNameDelivery,
            [XmlEnum(Name = "Calling Name Retrieval")]
        CallingNameRetrieval,
            [XmlEnum(Name = "Calling Number Delivery")]
        CallingNumberDelivery,
            [XmlEnum(Name = "Calling Party Category")]
        CallingPartyCategory,
            [XmlEnum(Name = "Charge Number")]
        ChargeNumber,
            [XmlEnum(Name = "Classmark")]
        Classmark,
            [XmlEnum(Name = "Client Call Control")]
        ClientCallControl,
            [XmlEnum(Name = "Client Call Control II")]
        ClientCallControlII,
            [XmlEnum(Name = "Client License 1")]
        ClientLicense1,
            [XmlEnum(Name = "Client License 2")]
        ClientLicense2,
            [XmlEnum(Name = "Client License 3")]
        ClientLicense3,
            [XmlEnum(Name = "Client License 4")]
        ClientLicense4,
            [XmlEnum(Name = "Client License 5")]
        ClientLicense5,
            [XmlEnum(Name = "Client License 6")]
        ClientLicense6,
            [XmlEnum(Name = "Client License 7")]
        ClientLicense7,
            [XmlEnum(Name = "Client License 8")]
        ClientLicense8,
            [XmlEnum(Name = "Client License 9")]
        ClientLicense9,
            [XmlEnum(Name = "Client License 10")]
        ClientLicense10,
            [XmlEnum(Name = "Client License 11")]
        ClientLicense11,
            [XmlEnum(Name = "Client License 12")]
        ClientLicense12,
            [XmlEnum(Name = "Client License 13")]
        ClientLicense13,
            [XmlEnum(Name = "Client License 14")]
        ClientLicense14,
            [XmlEnum(Name = "Client License 15")]
        ClientLicense15,
            [XmlEnum(Name = "Client License 16")]
        ClientLicense16,
            [XmlEnum(Name = "Client License 17")]
        ClientLicense17,
            [XmlEnum(Name = "Client License 18")]
        ClientLicense18,
            [XmlEnum(Name = "Client License 19")]
        ClientLicense19,
            [XmlEnum(Name = "Client License 20")]
        ClientLicense20,
            [XmlEnum(Name = "Client License 21")]
        ClientLicense21,
            [XmlEnum(Name = "Client License 22")]
        ClientLicense22,
            [XmlEnum(Name = "Client License 23")]
        ClientLicense23,
            [XmlEnum(Name = "Client License 24")]
        ClientLicense24,
            [XmlEnum(Name = "Client License 25")]
        ClientLicense25,
            [XmlEnum(Name = "Client License 26")]
        ClientLicense26,
            [XmlEnum(Name = "Client License 27")]
        ClientLicense27,
            [XmlEnum(Name = "Client License 28")]
        ClientLicense28,
            [XmlEnum(Name = "Client License 29")]
        ClientLicense29,
            [XmlEnum(Name = "Client License 30")]
        ClientLicense30,
            [XmlEnum(Name = "Client License 31")]
        ClientLicense31,
            [XmlEnum(Name = "Client License 32")]
        ClientLicense32,
            [XmlEnum(Name = "Client License 33")]
        ClientLicense33,
            [XmlEnum(Name = "Client License 34")]
        ClientLicense34,
            [XmlEnum(Name = "Client License 35")]
        ClientLicense35,
            [XmlEnum(Name = "Client License 36")]
        ClientLicense36,
            [XmlEnum(Name = "Client License 37")]
        ClientLicense37,
            [XmlEnum(Name = "Client License 38")]
        ClientLicense38,
            [XmlEnum(Name = "Client License 39")]
        ClientLicense39,
            [XmlEnum(Name = "Client License 40")]
        ClientLicense40,
            [XmlEnum(Name = "Client License 41")]
        ClientLicense41,
            [XmlEnum(Name = "Client License 42")]
        ClientLicense42,
            [XmlEnum(Name = "Client License 43")]
        ClientLicense43,
            [XmlEnum(Name = "Client License 44")]
        ClientLicense44,
            [XmlEnum(Name = "Client License 45")]
        ClientLicense45,
            [XmlEnum(Name = "Client License 46")]
        ClientLicense46,
            [XmlEnum(Name = "Client License 47")]
        ClientLicense47,
            [XmlEnum(Name = "Client License 48")]
        ClientLicense48,
            [XmlEnum(Name = "Client License 49")]
        ClientLicense49,
            [XmlEnum(Name = "Client License 50")]
        ClientLicense50,
            [XmlEnum(Name = "Collaborate - Audio")]
        CollaborateAudio,
            [XmlEnum(Name = "Collaborate - Video")]
        CollaborateVideo,
            [XmlEnum(Name = "Collaborate - Sharing")]
        CollaborateSharing,
            [XmlEnum(Name = "CommPilot Call Manager")]
        CommPilotCallManager,
            [XmlEnum(Name = "CommPilot Express")]
        CommPilotExpress,
            [XmlEnum(Name = "CommPilot Express SR")]
        CommPilotExpressSR,
            [XmlEnum(Name = "CommPilot Lite")]
        CommPilotLite,
            [XmlEnum(Name = "CommPilot Receptionist")]
        CommPilotReceptionist,
            [XmlEnum(Name = "CommPilot Residential")]
        CommPilotResidential,
            [XmlEnum(Name = "CommPilot Small Business")]
        CommPilotSmallBusiness,
            [XmlEnum(Name = "Communication Barring User-Control")]
        CommunicationBarringUserControl,
            [XmlEnum(Name = "Conference Room")]
        ConferenceRoom,
            [XmlEnum(Name = "Connected Line Identification Presentation")]
        ConnectedLineIdentificationPresentation,
            [XmlEnum(Name = "Connected Line Identification Restriction")]
        ConnectedLineIdentificationRestriction,
            [XmlEnum(Name = "Customer Originated Trace")]
        CustomerOriginatedTrace,
            [XmlEnum(Name = "Custom Ringback User")]
        CustomRingbackUser,
            [XmlEnum(Name = "Custom Ringback User - Call Waiting")]
        CustomRingbackUserCallWaiting,
            [XmlEnum(Name = "Custom Ringback User - Video")]
        CustomRingbackUserVideo,
            [XmlEnum(Name = "Direct Route")]
        DirectRoute,
            [XmlEnum(Name = "Directed Call Pickup")]
        DirectedCallPickup,
            [XmlEnum(Name = "Directed Call Pickup with Barge-in")]
        DirectedCallPickupwithBargein,
            [XmlEnum(Name = "Directory Number Hunting")]
        DirectoryNumberHunting,
            [XmlEnum(Name = "Diversion Inhibitor")]
        DiversionInhibitor,
            [XmlEnum(Name = "Do Not Disturb")]
        DoNotDisturb,
            [XmlEnum(Name = "Dual-Mode VCC")]
        DualModeVCC,
            [XmlEnum(Name = "Enhanced Call Logs")]
        EnhancedCallLogs,
            [XmlEnum(Name = "Executive")]
        Executive,
            [XmlEnum(Name = "Executive-Assistant")]
        ExecutiveAssistant,
            [XmlEnum(Name = "External Calling Line ID Delivery")]
        ExternalCallingLineIDDelivery,
            [XmlEnum(Name = "External Custom Ringback")]
        ExternalCustomRingback,
            [XmlEnum(Name = "Fax Messaging")]
        FaxMessaging,
            [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
            [XmlEnum(Name = "Flash Call Hold")]
        FlashCallHold,
            [XmlEnum(Name = "GETS Calling Line ID Delivery Blocking")]
        GETSCallingLineIDDeliveryBlocking,
            [XmlEnum(Name = "Group Night Forwarding")]
        GroupNightForwarding,
            [XmlEnum(Name = "Hoteling Guest")]
        HotelingGuest,
            [XmlEnum(Name = "Hoteling Host")]
        HotelingHost,
            [XmlEnum(Name = "Flexible Seating Guest")]
        FlexibleSeatingGuest,
            [XmlEnum(Name = "Integrated IMP")]
        IntegratedIMP,
            [XmlEnum(Name = "In-Call Service Activation")]
        InCallServiceActivation,
            [XmlEnum(Name = "IN Integration")]
        INIntegration,
            [XmlEnum(Name = "Intelligent Network Service Control")]
        IntelligentNetworkServiceControl,
            [XmlEnum(Name = "Intercept User")]
        InterceptUser,
            [XmlEnum(Name = "Internal Calling Line ID Delivery")]
        InternalCallingLineIDDelivery,
            [XmlEnum(Name = "Last Number Redial")]
        LastNumberRedial,
            [XmlEnum(Name = "Legacy Automatic Callback")]
        LegacyAutomaticCallback,
            [XmlEnum(Name = "Location-Based Calling Restrictions")]
        LocationBasedCallingRestrictions,
            [XmlEnum(Name = "Lync CTI")]
        LyncCTI,
            [XmlEnum(Name = "Lync Softphone")]
        LyncSoftphone,
            [XmlEnum(Name = "Malicious Call Trace")]
        MaliciousCallTrace,
            [XmlEnum(Name = "Mobile Extension to Extension Dialing")]
        MobileExtensiontoExtensionDialing,
            [XmlEnum(Name = "Mobility")]
        Mobility,
            [XmlEnum(Name = "Multiple Call Arrangement")]
        MultipleCallArrangement,
            [XmlEnum(Name = "Music On Hold User")]
        MusicOnHoldUser,
            [XmlEnum(Name = "Video On Hold User")]
        VideoOnHoldUser,
            [XmlEnum(Name = "MWI Delivery to Mobile Endpoint")]
        MWIDeliverytoMobileEndpoint,
            [XmlEnum(Name = "N-Way Call")]
        NWayCall,
            [XmlEnum(Name = "Number Portability Announcement")]
        NumberPortabilityAnnouncement,
            [XmlEnum(Name = "OMA Presence")]
        OMAPresence,
            [XmlEnum(Name = "Outlook Integration")]
        OutlookIntegration,
            [XmlEnum(Name = "Office Communicator Tab")]
        OfficeCommunicatorTab,
            [XmlEnum(Name = "Personal Assistant")]
        PersonalAssistant,
            [XmlEnum(Name = "Physical Location")]
        PhysicalLocation,
            [XmlEnum(Name = "Polycom Phone Services")]
        PolycomPhoneServices,
            [XmlEnum(Name = "Pre-alerting Announcement")]
        PrealertingAnnouncement,
            [XmlEnum(Name = "Preferred Carrier User")]
        PreferredCarrierUser,
            [XmlEnum(Name = "Prepaid")]
        Prepaid,
            [XmlEnum(Name = "Priority Alert")]
        PriorityAlert,
            [XmlEnum(Name = "Privacy")]
        Privacy,
            [XmlEnum(Name = "Push to Talk")]
        PushtoTalk,
            [XmlEnum(Name = "Remote Office")]
        RemoteOffice,
            [XmlEnum(Name = "Resource Priority")]
        ResourcePriority,
            [XmlEnum(Name = "Route List")]
        RouteList,
            [XmlEnum(Name = "SMDI Message Desk")]
        SMDIMessageDesk,
            [XmlEnum(Name = "Security Classification")]
        SecurityClassification,
            [XmlEnum(Name = "Selective Call Acceptance")]
        SelectiveCallAcceptance,
            [XmlEnum(Name = "Selective Call Rejection")]
        SelectiveCallRejection,
            [XmlEnum(Name = "Sequential Ring")]
        SequentialRing,
            [XmlEnum(Name = "Service Scripts User")]
        ServiceScriptsUser,
            [XmlEnum(Name = "Shared Call Appearance")]
        SharedCallAppearance,
            [XmlEnum(Name = "Shared Call Appearance 5")]
        SharedCallAppearance5,
            [XmlEnum(Name = "Shared Call Appearance 10")]
        SharedCallAppearance10,
            [XmlEnum(Name = "Shared Call Appearance 15")]
        SharedCallAppearance15,
            [XmlEnum(Name = "Shared Call Appearance 20")]
        SharedCallAppearance20,
            [XmlEnum(Name = "Shared Call Appearance 25")]
        SharedCallAppearance25,
            [XmlEnum(Name = "Shared Call Appearance 30")]
        SharedCallAppearance30,
            [XmlEnum(Name = "Shared Call Appearance 35")]
        SharedCallAppearance35,
            [XmlEnum(Name = "Short Message Service")]
        ShortMessageService,
            [XmlEnum(Name = "Silent Alerting")]
        SilentAlerting,
            [XmlEnum(Name = "Simultaneous Ring Family")]
        SimultaneousRingFamily,
            [XmlEnum(Name = "Simultaneous Ring Personal")]
        SimultaneousRingPersonal,
            [XmlEnum(Name = "Speed Dial 100")]
        SpeedDial100,
            [XmlEnum(Name = "Speed Dial 8")]
        SpeedDial8,
            [XmlEnum(Name = "Terminating Alternate Trunk Identity")]
        TerminatingAlternateTrunkIdentity,
            [XmlEnum(Name = "Third-Party IMP")]
        ThirdPartyIMP,
            [XmlEnum(Name = "Third-Party MWI Control")]
        ThirdPartyMWIControl,
            [XmlEnum(Name = "Third-Party Voice Mail Support")]
        ThirdPartyVoiceMailSupport,
            [XmlEnum(Name = "Three-Way Call")]
        ThreeWayCall,
            [XmlEnum(Name = "Two-Stage Dialing")]
        TwoStageDialing,
            [XmlEnum(Name = "Video Add-On")]
        VideoAddOn,
            [XmlEnum(Name = "Virtual On-Net Enterprise Extensions")]
        VirtualOnNetEnterpriseExtensions,
            [XmlEnum(Name = "Visual Device Management")]
        VisualDeviceManagement,
            [XmlEnum(Name = "Voice Messaging User")]
        VoiceMessagingUser,
            [XmlEnum(Name = "Voice Messaging User - Video")]
        VoiceMessagingUserVideo,
            [XmlEnum(Name = "Voice Portal Calling")]
        VoicePortalCalling,
            [XmlEnum(Name = "Zone Calling Restrictions")]
        ZoneCallingRestrictions,
     }
}
