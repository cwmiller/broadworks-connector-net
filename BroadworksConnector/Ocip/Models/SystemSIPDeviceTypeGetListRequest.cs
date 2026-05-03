using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of sip device types in the system.
    /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
    /// are returned even when searchCriteriaResellerId is specified.
    /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
    /// types and the device types in the administrator's reseller meeting the search criteria are returned.
    /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
    /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// searchCriteriaExactDeviceTypeConfigurationOptionType
    /// <see cref="SystemDeviceTypeGetAvailableListRequest22"/>
    /// <see cref="SystemDeviceTypeGetAvailableListRequest19"/>
    /// <see cref="SystemSIPDeviceTypeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17561""}]")]
    public class SystemSIPDeviceTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSIPDeviceTypeGetListResponse>
    {

        protected int? _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        [MinInclusive(1)]
        public int? ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = (value != null);
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceType> _searchCriteriaDeviceType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceType>();

        [XmlElement(ElementName = "searchCriteriaDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceType> SearchCriteriaDeviceType
        {
            get => _searchCriteriaDeviceType;
            set
            {
                SearchCriteriaDeviceTypeSpecified = (value != null);
                _searchCriteriaDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType _searchCriteriaExactSignalingAddressType;

        [XmlElement(ElementName = "searchCriteriaExactSignalingAddressType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType SearchCriteriaExactSignalingAddressType
        {
            get => _searchCriteriaExactSignalingAddressType;
            set
            {
                SearchCriteriaExactSignalingAddressTypeSpecified = (value != null);
                _searchCriteriaExactSignalingAddressType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactSignalingAddressTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId
        {
            get => _searchCriteriaResellerId;
            set
            {
                SearchCriteriaResellerIdSpecified = (value != null);
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaResellerIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceTypeConfigurationOptionType> _searchCriteriaDeviceConfigurationOptions = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceTypeConfigurationOptionType>();

        [XmlElement(ElementName = "searchCriteriaDeviceConfigurationOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceTypeConfigurationOptionType> SearchCriteriaDeviceConfigurationOptions
        {
            get => _searchCriteriaDeviceConfigurationOptions;
            set
            {
                SearchCriteriaDeviceConfigurationOptionsSpecified = (value != null);
                _searchCriteriaDeviceConfigurationOptions = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceConfigurationOptionsSpecified { get; set; }

        protected bool? _includeSystemLevel;

        [XmlElement(ElementName = "includeSystemLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17561")]
        public bool? IncludeSystemLevel
        {
            get => _includeSystemLevel;
            set
            {
                IncludeSystemLevelSpecified = (value != null);
                _includeSystemLevel = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeSystemLevelSpecified { get; set; }

    }
}
