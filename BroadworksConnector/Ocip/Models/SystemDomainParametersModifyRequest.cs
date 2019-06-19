using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify system Domain parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useAliasForDomain
    /// 
    /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
    /// defaultDomain
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8551""}]")]
    public class SystemDomainParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _useAliasForDomain;

        [XmlElement(ElementName = "useAliasForDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8551")]
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
        public bool UseAliasForDomainSpecified { get; set; }

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8551")]
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
        public bool DefaultDomainSpecified { get; set; }

    }
}
