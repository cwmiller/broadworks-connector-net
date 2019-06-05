using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAdminFirstName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAdminId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAdminLastName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAgentThresholdProfile))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAnnouncementFileName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByCallCenterName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByCallCenterType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByCallParkName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByCallPickupName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDepartmentName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDeviceMACAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDeviceName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDeviceNetAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDeviceType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDn))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDnActivated))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByDnAvailable))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByEmailAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByEnabled))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByExtension))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByForwardedToNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByGroupCommonPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByGroupId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByGroupLocationCode))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByGroupName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByHuntPolicy))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByImpId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByLocation))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByMobileDirectoryNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByMobilePhoneNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByReceptionistNote))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByScheduleName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByServiceProviderId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByServiceProviderName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByServiceStatus))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserDepartment))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserFirstName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserLastName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserPersonalPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByYahooId))]
public abstract class SortCriteria 
{
    private bool _isAscending;

    [XmlElement(ElementName = "isAscending", IsNullable = false, Namespace = "")]
    public bool IsAscending {
        get => _isAscending;
        set {
            IsAscendingSpecified = true;
            _isAscending = value;
        }
    }

    [XmlIgnore]
    public bool IsAscendingSpecified { get; set; }
    private bool _isCaseSensitive;

    [XmlElement(ElementName = "isCaseSensitive", IsNullable = false, Namespace = "")]
    public bool IsCaseSensitive {
        get => _isCaseSensitive;
        set {
            IsCaseSensitiveSpecified = true;
            _isCaseSensitive = value;
        }
    }

    [XmlIgnore]
    public bool IsCaseSensitiveSpecified { get; set; }
}
}
