using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPolicyGetDefaultResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.GroupCallingPlanAccess _groupCallingPlanAccess;

    [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupCallingPlanAccess GroupCallingPlanAccess {
        get => _groupCallingPlanAccess;
        set {
            GroupCallingPlanAccessSpecified = true;
            _groupCallingPlanAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupCallingPlanAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupExtensionAccess _groupExtensionAccess;

    [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupExtensionAccess GroupExtensionAccess {
        get => _groupExtensionAccess;
        set {
            GroupExtensionAccessSpecified = true;
            _groupExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess _groupLDAPIntegrationAccess;

    [XmlElement(ElementName = "groupLDAPIntegrationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess GroupLDAPIntegrationAccess {
        get => _groupLDAPIntegrationAccess;
        set {
            GroupLDAPIntegrationAccessSpecified = true;
            _groupLDAPIntegrationAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupLDAPIntegrationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess _groupVoiceMessagingAccess;

    [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess GroupVoiceMessagingAccess {
        get => _groupVoiceMessagingAccess;
        set {
            GroupVoiceMessagingAccessSpecified = true;
            _groupVoiceMessagingAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupVoiceMessagingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _groupDepartmentAdminUserAccess;

    [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess GroupDepartmentAdminUserAccess {
        get => _groupDepartmentAdminUserAccess;
        set {
            GroupDepartmentAdminUserAccessSpecified = true;
            _groupDepartmentAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentAdminUserAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _groupDepartmentAdminTrunkGroupAccess;

    [XmlElement(ElementName = "groupDepartmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess GroupDepartmentAdminTrunkGroupAccess {
        get => _groupDepartmentAdminTrunkGroupAccess;
        set {
            GroupDepartmentAdminTrunkGroupAccessSpecified = true;
            _groupDepartmentAdminTrunkGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentAdminTrunkGroupAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess _groupDepartmentAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "groupDepartmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess GroupDepartmentAdminPhoneNumberExtensionAccess {
        get => _groupDepartmentAdminPhoneNumberExtensionAccess;
        set {
            GroupDepartmentAdminPhoneNumberExtensionAccessSpecified = true;
            _groupDepartmentAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess _groupDepartmentAdminCallingLineIdNumberAccess;

    [XmlElement(ElementName = "groupDepartmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess GroupDepartmentAdminCallingLineIdNumberAccess {
        get => _groupDepartmentAdminCallingLineIdNumberAccess;
        set {
            GroupDepartmentAdminCallingLineIdNumberAccessSpecified = true;
            _groupDepartmentAdminCallingLineIdNumberAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentAdminCallingLineIdNumberAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess _groupUserAuthenticationAccess;

    [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess GroupUserAuthenticationAccess {
        get => _groupUserAuthenticationAccess;
        set {
            GroupUserAuthenticationAccessSpecified = true;
            _groupUserAuthenticationAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserAuthenticationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _groupUserGroupDirectoryAccess;

    [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess GroupUserGroupDirectoryAccess {
        get => _groupUserGroupDirectoryAccess;
        set {
            GroupUserGroupDirectoryAccessSpecified = true;
            _groupUserGroupDirectoryAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserGroupDirectoryAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserProfileAccess _groupUserProfileAccess;

    [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserProfileAccess GroupUserProfileAccess {
        get => _groupUserProfileAccess;
        set {
            GroupUserProfileAccessSpecified = true;
            _groupUserProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserCallLogAccess _groupUserEnhancedCallLogsAccess;

    [XmlElement(ElementName = "groupUserEnhancedCallLogsAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserCallLogAccess GroupUserEnhancedCallLogsAccess {
        get => _groupUserEnhancedCallLogsAccess;
        set {
            GroupUserEnhancedCallLogsAccessSpecified = true;
            _groupUserEnhancedCallLogsAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserEnhancedCallLogsAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess _groupUserAutoAttendantNameDialingAccess;

    [XmlElement(ElementName = "groupUserAutoAttendantNameDialingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess GroupUserAutoAttendantNameDialingAccess {
        get => _groupUserAutoAttendantNameDialingAccess;
        set {
            GroupUserAutoAttendantNameDialingAccessSpecified = true;
            _groupUserAutoAttendantNameDialingAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserAutoAttendantNameDialingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminProfileAccess _groupAdminProfileAccess;

    [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminProfileAccess GroupAdminProfileAccess {
        get => _groupAdminProfileAccess;
        set {
            GroupAdminProfileAccessSpecified = true;
            _groupAdminProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminUserAccess _groupAdminUserAccess;

    [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminUserAccess GroupAdminUserAccess {
        get => _groupAdminUserAccess;
        set {
            GroupAdminUserAccessSpecified = true;
            _groupAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminUserAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminAdminAccess _groupAdminAdminAccess;

    [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminAdminAccess GroupAdminAdminAccess {
        get => _groupAdminAdminAccess;
        set {
            GroupAdminAdminAccessSpecified = true;
            _groupAdminAdminAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminAdminAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess _groupAdminDepartmentAccess;

    [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess GroupAdminDepartmentAccess {
        get => _groupAdminDepartmentAccess;
        set {
            GroupAdminDepartmentAccessSpecified = true;
            _groupAdminDepartmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminDepartmentAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _groupAdminAccessDeviceAccess;

    [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess GroupAdminAccessDeviceAccess {
        get => _groupAdminAccessDeviceAccess;
        set {
            GroupAdminAccessDeviceAccessSpecified = true;
            _groupAdminAccessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminAccessDeviceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _groupAdminEnhancedServiceInstanceAccess;

    [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess GroupAdminEnhancedServiceInstanceAccess {
        get => _groupAdminEnhancedServiceInstanceAccess;
        set {
            GroupAdminEnhancedServiceInstanceAccessSpecified = true;
            _groupAdminEnhancedServiceInstanceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminEnhancedServiceInstanceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _groupAdminFeatureAccessCodeAccess;

    [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess GroupAdminFeatureAccessCodeAccess {
        get => _groupAdminFeatureAccessCodeAccess;
        set {
            GroupAdminFeatureAccessCodeAccessSpecified = true;
            _groupAdminFeatureAccessCodeAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminFeatureAccessCodeAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _groupAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess GroupAdminPhoneNumberExtensionAccess {
        get => _groupAdminPhoneNumberExtensionAccess;
        set {
            GroupAdminPhoneNumberExtensionAccessSpecified = true;
            _groupAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess _groupAdminCallingLineIdNumberAccess;

    [XmlElement(ElementName = "groupAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess GroupAdminCallingLineIdNumberAccess {
        get => _groupAdminCallingLineIdNumberAccess;
        set {
            GroupAdminCallingLineIdNumberAccessSpecified = true;
            _groupAdminCallingLineIdNumberAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminCallingLineIdNumberAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminServiceAccess _groupAdminServiceAccess;

    [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminServiceAccess GroupAdminServiceAccess {
        get => _groupAdminServiceAccess;
        set {
            GroupAdminServiceAccessSpecified = true;
            _groupAdminServiceAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminServiceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _groupAdminTrunkGroupAccess;

    [XmlElement(ElementName = "groupAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess GroupAdminTrunkGroupAccess {
        get => _groupAdminTrunkGroupAccess;
        set {
            GroupAdminTrunkGroupAccessSpecified = true;
            _groupAdminTrunkGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminTrunkGroupAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess _groupAdminVerifyTranslationAndRoutingAccess;

    [XmlElement(ElementName = "groupAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess GroupAdminVerifyTranslationAndRoutingAccess {
        get => _groupAdminVerifyTranslationAndRoutingAccess;
        set {
            GroupAdminVerifyTranslationAndRoutingAccessSpecified = true;
            _groupAdminVerifyTranslationAndRoutingAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess _groupAdminSessionAdmissionControlAccess;

    [XmlElement(ElementName = "groupAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess GroupAdminSessionAdmissionControlAccess {
        get => _groupAdminSessionAdmissionControlAccess;
        set {
            GroupAdminSessionAdmissionControlAccessSpecified = true;
            _groupAdminSessionAdmissionControlAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminSessionAdmissionControlAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess _groupAdminOfficeZoneAccess;

    [XmlElement(ElementName = "groupAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess GroupAdminOfficeZoneAccess {
        get => _groupAdminOfficeZoneAccess;
        set {
            GroupAdminOfficeZoneAccessSpecified = true;
            _groupAdminOfficeZoneAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminOfficeZoneAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess _groupAdminNumberActivationAccess;

    [XmlElement(ElementName = "groupAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess GroupAdminNumberActivationAccess {
        get => _groupAdminNumberActivationAccess;
        set {
            GroupAdminNumberActivationAccessSpecified = true;
            _groupAdminNumberActivationAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminNumberActivationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess _groupAdminDialableCallerIDAccess;

    [XmlElement(ElementName = "groupAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess GroupAdminDialableCallerIDAccess {
        get => _groupAdminDialableCallerIDAccess;
        set {
            GroupAdminDialableCallerIDAccessSpecified = true;
            _groupAdminDialableCallerIDAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminDialableCallerIDAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess _groupAdminCommunicationBarringUserProfileAccess;

    [XmlElement(ElementName = "groupAdminCommunicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess GroupAdminCommunicationBarringUserProfileAccess {
        get => _groupAdminCommunicationBarringUserProfileAccess;
        set {
            GroupAdminCommunicationBarringUserProfileAccessSpecified = true;
            _groupAdminCommunicationBarringUserProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminCommunicationBarringUserProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _serviceProviderAdminProfileAccess;

    [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ServiceProviderAdminProfileAccess {
        get => _serviceProviderAdminProfileAccess;
        set {
            ServiceProviderAdminProfileAccessSpecified = true;
            _serviceProviderAdminProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _serviceProviderAdminGroupAccess;

    [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess ServiceProviderAdminGroupAccess {
        get => _serviceProviderAdminGroupAccess;
        set {
            ServiceProviderAdminGroupAccessSpecified = true;
            _serviceProviderAdminGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminGroupAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess _serviceProviderAdminUserAccess;

    [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess ServiceProviderAdminUserAccess {
        get => _serviceProviderAdminUserAccess;
        set {
            ServiceProviderAdminUserAccessSpecified = true;
            _serviceProviderAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminUserAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _serviceProviderAdminAdminAccess;

    [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess ServiceProviderAdminAdminAccess {
        get => _serviceProviderAdminAdminAccess;
        set {
            ServiceProviderAdminAdminAccessSpecified = true;
            _serviceProviderAdminAdminAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminAdminAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _serviceProviderAdminDepartmentAccess;

    [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess ServiceProviderAdminDepartmentAccess {
        get => _serviceProviderAdminDepartmentAccess;
        set {
            ServiceProviderAdminDepartmentAccessSpecified = true;
            _serviceProviderAdminDepartmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminDepartmentAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _serviceProviderAdminAccessDeviceAccess;

    [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess ServiceProviderAdminAccessDeviceAccess {
        get => _serviceProviderAdminAccessDeviceAccess;
        set {
            ServiceProviderAdminAccessDeviceAccessSpecified = true;
            _serviceProviderAdminAccessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminAccessDeviceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _serviceProviderAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess ServiceProviderAdminPhoneNumberExtensionAccess {
        get => _serviceProviderAdminPhoneNumberExtensionAccess;
        set {
            ServiceProviderAdminPhoneNumberExtensionAccessSpecified = true;
            _serviceProviderAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess _serviceProviderAdminCallingLineIdNumberAccess;

    [XmlElement(ElementName = "serviceProviderAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess ServiceProviderAdminCallingLineIdNumberAccess {
        get => _serviceProviderAdminCallingLineIdNumberAccess;
        set {
            ServiceProviderAdminCallingLineIdNumberAccessSpecified = true;
            _serviceProviderAdminCallingLineIdNumberAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminCallingLineIdNumberAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceProviderAdminServiceAccess;

    [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceProviderAdminServiceAccess {
        get => _serviceProviderAdminServiceAccess;
        set {
            ServiceProviderAdminServiceAccessSpecified = true;
            _serviceProviderAdminServiceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminServiceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _serviceProviderAdminServicePackAccess;

    [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServiceProviderAdminServicePackAccess {
        get => _serviceProviderAdminServicePackAccess;
        set {
            ServiceProviderAdminServicePackAccessSpecified = true;
            _serviceProviderAdminServicePackAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminServicePackAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess _serviceProviderAdminSessionAdmissionControlAccess;

    [XmlElement(ElementName = "serviceProviderAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess ServiceProviderAdminSessionAdmissionControlAccess {
        get => _serviceProviderAdminSessionAdmissionControlAccess;
        set {
            ServiceProviderAdminSessionAdmissionControlAccessSpecified = true;
            _serviceProviderAdminSessionAdmissionControlAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminSessionAdmissionControlAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess _serviceProviderAdminVerifyTranslationAndRoutingAccess;

    [XmlElement(ElementName = "serviceProviderAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess ServiceProviderAdminVerifyTranslationAndRoutingAccess {
        get => _serviceProviderAdminVerifyTranslationAndRoutingAccess;
        set {
            ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified = true;
            _serviceProviderAdminVerifyTranslationAndRoutingAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _serviceProviderAdminWebBrandingAccess;

    [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess ServiceProviderAdminWebBrandingAccess {
        get => _serviceProviderAdminWebBrandingAccess;
        set {
            ServiceProviderAdminWebBrandingAccessSpecified = true;
            _serviceProviderAdminWebBrandingAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminWebBrandingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess _serviceProviderAdminOfficeZoneAccess;

    [XmlElement(ElementName = "serviceProviderAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess ServiceProviderAdminOfficeZoneAccess {
        get => _serviceProviderAdminOfficeZoneAccess;
        set {
            ServiceProviderAdminOfficeZoneAccessSpecified = true;
            _serviceProviderAdminOfficeZoneAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminOfficeZoneAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess _serviceProviderAdminCommunicationBarringAccess;

    [XmlElement(ElementName = "serviceProviderAdminCommunicationBarringAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess ServiceProviderAdminCommunicationBarringAccess {
        get => _serviceProviderAdminCommunicationBarringAccess;
        set {
            ServiceProviderAdminCommunicationBarringAccessSpecified = true;
            _serviceProviderAdminCommunicationBarringAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminCommunicationBarringAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _enterpriseAdminNetworkPolicyAccess;

    [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess EnterpriseAdminNetworkPolicyAccess {
        get => _enterpriseAdminNetworkPolicyAccess;
        set {
            EnterpriseAdminNetworkPolicyAccessSpecified = true;
            _enterpriseAdminNetworkPolicyAccess = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseAdminNetworkPolicyAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess _enterpriseAdminNumberActivationAccess;

    [XmlElement(ElementName = "enterpriseAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess EnterpriseAdminNumberActivationAccess {
        get => _enterpriseAdminNumberActivationAccess;
        set {
            EnterpriseAdminNumberActivationAccessSpecified = true;
            _enterpriseAdminNumberActivationAccess = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseAdminNumberActivationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess _serviceProviderAdminDialableCallerIDAccess;

    [XmlElement(ElementName = "serviceProviderAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess ServiceProviderAdminDialableCallerIDAccess {
        get => _serviceProviderAdminDialableCallerIDAccess;
        set {
            ServiceProviderAdminDialableCallerIDAccessSpecified = true;
            _serviceProviderAdminDialableCallerIDAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminDialableCallerIDAccessSpecified { get; set; }
}
}
