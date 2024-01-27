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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:3082""}]")]
    public class GroupCallCenterCurrentAndPastCallCenterGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterCurrentAndPastCallCenterGetListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3082")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected bool _isPremiumOnly;

        [XmlElement(ElementName = "isPremiumOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3082")]
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
        protected bool IsPremiumOnlySpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3082")]
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
        protected bool GroupIdSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3082")]
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
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName _searchCriteriaCallCenterName;

        [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3082")]
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
        protected bool SearchCriteriaCallCenterNameSpecified { get; set; }

    }
}
