using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of device family managed by the Device Management System.
    /// If includeSystemLevel is specified, all system level device families and the reseller device families matching search criteria
    /// are returned even when searchCriteriaResellerId is specified.
    /// If reseller administrator sends the request, searchCriteriaResellerId is ignored and automatically set to the administrator's reseller.
    /// 
    /// The response is either SystemDeviceFamilyGetListResponse or ErrorResponse.
    /// <see cref="SystemDeviceFamilyGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7563""}]")]
    public class SystemDeviceFamilyGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceFamilyGetListResponse>
    {

        protected bool _includeSystemLevel;

        [XmlElement(ElementName = "includeSystemLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7563")]
        public bool IncludeSystemLevel
        {
            get => _includeSystemLevel;
            set
            {
                IncludeSystemLevelSpecified = true;
                _includeSystemLevel = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeSystemLevelSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7563")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId
        {
            get => _searchCriteriaResellerId;
            set
            {
                SearchCriteriaResellerIdSpecified = true;
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaResellerIdSpecified { get; set; }

    }
}
