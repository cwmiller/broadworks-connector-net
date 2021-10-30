using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Digit Pattern Criteria.
    /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
    /// <see cref="ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2109""}]")]
    public class ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2109")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2109")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2109")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> _searchCriteriaDigitPattern = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern>();

        [XmlElement(ElementName = "searchCriteriaDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2109")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> SearchCriteriaDigitPattern
        {
            get => _searchCriteriaDigitPattern;
            set
            {
                SearchCriteriaDigitPatternSpecified = true;
                _searchCriteriaDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDigitPatternSpecified { get; set; }

    }
}
