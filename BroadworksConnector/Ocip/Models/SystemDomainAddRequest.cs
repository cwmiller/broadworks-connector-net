using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system or reseller domain to the system.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8340""}]")]
    public class SystemDomainAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _domain;

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8340")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Domain
        {
            get => _domain;
            set
            {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        public bool DomainSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8340")]
        [MinLength(1)]
        [MaxLength(30)]
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
        public bool ResellerIdSpecified { get; set; }

    }
}
