using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDomainParametersGetRequest.
    /// Contains the system Domain parameters.
    /// 
    /// The following elements are only used in AS data mode:
    /// useAliasForDomain, value "false" is returned in XS data mode.
    /// <see cref="SystemDomainParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9677""}]")]
    public class SystemDomainParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useAliasForDomain;

        [XmlElement(ElementName = "useAliasForDomain", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9677")]
        public bool UseAliasForDomain
        {
            get => _useAliasForDomain;
            set
            {
                UseAliasForDomainSpecified = true;
                _useAliasForDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UseAliasForDomainSpecified { get; set; }

        protected string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9677")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDomain
        {
            get => _defaultDomain;
            set
            {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDomainSpecified { get; set; }

    }
}
