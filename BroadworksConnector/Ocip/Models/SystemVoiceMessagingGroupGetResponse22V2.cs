using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetResponse22V2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "realDeleteForImap", IsNullable = false)]
    public bool RealDeleteForImap { get; set; }
    [XmlElement(ElementName = "useDnInMailBody", IsNullable = false)]
    public bool UseDnInMailBody { get; set; }
    [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false)]
    public bool UseShortSubjectLine { get; set; }
    [XmlElement(ElementName = "maxMessageLengthMinutes", IsNullable = false)]
    public int MaxMessageLengthMinutes { get; set; }
    [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes MaxMailboxLengthMinutes { get; set; }
    [XmlElement(ElementName = "doesMessageAge", IsNullable = false)]
    public bool DoesMessageAge { get; set; }
    [XmlElement(ElementName = "holdPeriodDays", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays HoldPeriodDays { get; set; }
    [XmlElement(ElementName = "mailServerNetAddress", IsNullable = false)]
    public string MailServerNetAddress { get; set; }
    [XmlElement(ElementName = "mailServerProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailServerProtocol MailServerProtocol { get; set; }
    [XmlElement(ElementName = "defaultDeliveryFromAddress", IsNullable = false)]
    public string DefaultDeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "defaultNotificationFromAddress", IsNullable = false)]
    public string DefaultNotificationFromAddress { get; set; }
    [XmlElement(ElementName = "defaultVoicePortalLockoutFromAddress", IsNullable = false)]
    public string DefaultVoicePortalLockoutFromAddress { get; set; }
    [XmlElement(ElementName = "useOutgoingMWIOnSMDI", IsNullable = false)]
    public bool UseOutgoingMWIOnSMDI { get; set; }
    [XmlElement(ElementName = "mwiDelayInSeconds", IsNullable = false)]
    public int MwiDelayInSeconds { get; set; }
    [XmlElement(ElementName = "voicePortalScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoicePortalScope VoicePortalScope { get; set; }
    [XmlElement(ElementName = "enterpriseVoicePortalLicensed", IsNullable = false)]
    public bool EnterpriseVoicePortalLicensed { get; set; }
    [XmlElement(ElementName = "networkWideMessaging", IsNullable = false)]
    public bool NetworkWideMessaging { get; set; }
    [XmlElement(ElementName = "useExternalRouting", IsNullable = false)]
    public bool UseExternalRouting { get; set; }
    [XmlElement(ElementName = "defaultExternalRoutingAddress", IsNullable = false)]
    public string DefaultExternalRoutingAddress { get; set; }
    [XmlElement(ElementName = "vmOnlySystem", IsNullable = false)]
    public bool VmOnlySystem { get; set; }
    [XmlElement(ElementName = "clientInitiatedMailServerSessionTimeoutMinutes", IsNullable = false)]
    public int ClientInitiatedMailServerSessionTimeoutMinutes { get; set; }
    [XmlElement(ElementName = "recordingAudioFileFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingRecordingAudioFileFormat RecordingAudioFileFormat { get; set; }
    [XmlElement(ElementName = "allowVoicePortalAccessFromVMDepositMenu", IsNullable = false)]
    public bool AllowVoicePortalAccessFromVMDepositMenu { get; set; }
    [XmlElement(ElementName = "storageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingStorageMode StorageSelection { get; set; }
    [XmlElement(ElementName = "vmBucketName", IsNullable = false)]
    public string VmBucketName { get; set; }
 }
}
