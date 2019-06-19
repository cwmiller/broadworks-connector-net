using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies whether sort is ascending or descending,
    /// and	whether the sort is case sensitive. Sort order defaults to
    /// ascending and case sensitive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAdminFirstName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAdminId))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAdminLastName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAgentThresholdProfile))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAnnouncementFileName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByCallCenterName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByCallCenterType))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByCallParkName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByCallPickupName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDepartmentName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDeviceMACAddress))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDeviceName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDeviceNetAddress))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDeviceType))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDn))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDnActivated))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByDnAvailable))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByEmailAddress))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByEnabled))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByExtension))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByForwardedToNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByGroupId))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByGroupLocationCode))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByGroupName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByHuntPolicy))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByImpId))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByLocation))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByMobileDirectoryNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByMobilePhoneNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByReceptionistNote))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByScheduleName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByServiceProviderId))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByServiceProviderName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByServiceStatus))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserDepartment))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserFirstName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserId))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserLastName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByYahooId))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""58293b6da8bb02a6430b3eb1beb91194:723""}]")]
    public abstract class SortCriteria
    {

        private bool _isAscending;

        [XmlElement(ElementName = "isAscending", IsNullable = false, Namespace = "")]
        [Group(@"58293b6da8bb02a6430b3eb1beb91194:723")]
        public bool IsAscending
        {
            get => _isAscending;
            set
            {
                IsAscendingSpecified = true;
                _isAscending = value;
            }
        }

        [XmlIgnore]
        public bool IsAscendingSpecified { get; set; }

        private bool _isCaseSensitive;

        [XmlElement(ElementName = "isCaseSensitive", IsNullable = false, Namespace = "")]
        [Group(@"58293b6da8bb02a6430b3eb1beb91194:723")]
        public bool IsCaseSensitive
        {
            get => _isCaseSensitive;
            set
            {
                IsCaseSensitiveSpecified = true;
                _isCaseSensitive = value;
            }
        }

        [XmlIgnore]
        public bool IsCaseSensitiveSpecified { get; set; }

    }
}
