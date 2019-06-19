using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the current and past call centers for the group.
    /// The response is either GroupCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
    /// <see cref="GroupCallCenterCurrentAndPastCallCenterGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3072""}]")]
    public class GroupCallCenterCurrentAndPastCallCenterGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3072")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private bool _isPremiumOnly;

        [XmlElement(ElementName = "isPremiumOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3072")]
        public bool IsPremiumOnly
        {
            get => _isPremiumOnly;
            set
            {
                IsPremiumOnlySpecified = true;
                _isPremiumOnly = value;
            }
        }

        [XmlIgnore]
        public bool IsPremiumOnlySpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3072")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3072")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName _searchCriteriaCallCenterName;

        [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3072")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName SearchCriteriaCallCenterName
        {
            get => _searchCriteriaCallCenterName;
            set
            {
                SearchCriteriaCallCenterNameSpecified = true;
                _searchCriteriaCallCenterName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallCenterNameSpecified { get; set; }

    }
}
