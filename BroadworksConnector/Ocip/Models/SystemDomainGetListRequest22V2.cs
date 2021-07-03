using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all matching system-level domains and all matching reseller level domains.
    /// If excludeReseller is specified, returns all matching system-level domain names only.
    /// If resellerId is specified, returns all matching system-level domain names and the given reseller's domains.
    /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// 
    /// The response is either SystemDomainGetListResponse22V2 or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and will be ingored in XS data mode:
    /// includeReseller
    /// resellerId
    /// responseSizeLimit
    /// searchCriteriaDomainName
    /// searchCriteriaResellerId
    /// searchCriteriaExactDomainLevel
    /// <see cref="SystemDomainGetListResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9495"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9496""}]}]")]
    public class SystemDomainGetListRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9496")]
        public bool ExcludeReseller
        {
            get => _excludeReseller;
            set
            {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeResellerSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9496")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9495")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> _searchCriteriaDomainName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName>();

        [XmlElement(ElementName = "searchCriteriaDomainName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9495")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> SearchCriteriaDomainName
        {
            get => _searchCriteriaDomainName;
            set
            {
                SearchCriteriaDomainNameSpecified = true;
                _searchCriteriaDomainName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDomainNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9495")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDomainLevel> _searchCriteriaExactDomainLevel = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDomainLevel>();

        [XmlElement(ElementName = "searchCriteriaExactDomainLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9495")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDomainLevel> SearchCriteriaExactDomainLevel
        {
            get => _searchCriteriaExactDomainLevel;
            set
            {
                SearchCriteriaExactDomainLevelSpecified = true;
                _searchCriteriaExactDomainLevel = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactDomainLevelSpecified { get; set; }

    }
}
