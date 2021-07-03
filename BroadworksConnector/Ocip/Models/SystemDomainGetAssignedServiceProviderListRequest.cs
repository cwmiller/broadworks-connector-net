using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of service providers that have a given domain assigned.
    /// If resellerId is specified, only the service providers within the reseller should be returned.
    /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// 
    /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// resellerId
    /// <see cref="SystemDomainGetAssignedServiceProviderListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9448""}]")]
    public class SystemDomainGetAssignedServiceProviderListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _domain;

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9448")]
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
        protected bool DomainSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9448")]
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

    }
}
