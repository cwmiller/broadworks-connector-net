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
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode.
    /// defaultDomain
    /// <see cref="SystemDomainParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9557""}]")]
    public class SystemDomainParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useAliasForDomain;

        [XmlElement(ElementName = "useAliasForDomain", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9557")]
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

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9557")]
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
