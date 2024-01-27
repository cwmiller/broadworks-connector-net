using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Service Provider Number Portability Query Digit Pattern Trigger List information.
    /// The response is either a ServiceProviderNumberPortabilityQueryGetResponse or an ErrorResponse.
    /// <see cref="ServiceProviderNumberPortabilityQueryGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5182""}]")]
    public class ServiceProviderNumberPortabilityQueryGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderNumberPortabilityQueryGetResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5182")]
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

        protected bool _includeDigitPatterns;

        [XmlElement(ElementName = "includeDigitPatterns", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5182")]
        public bool IncludeDigitPatterns
        {
            get => _includeDigitPatterns;
            set
            {
                IncludeDigitPatternsSpecified = true;
                _includeDigitPatterns = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeDigitPatternsSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern> _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5182")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern> SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern
        {
            get => _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern;
            set
            {
                SearchCriteriaServiceProviderNumberPortabilityQueryDigitPatternSpecified = true;
                _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceProviderNumberPortabilityQueryDigitPatternSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5182")]
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

    }
}
