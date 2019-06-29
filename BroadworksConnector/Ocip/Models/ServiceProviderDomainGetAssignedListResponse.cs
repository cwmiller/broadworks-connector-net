using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of all service provider domain names.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3309""}]")]
    public class ServiceProviderDomainGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceProviderDefaultDomain;

        [XmlElement(ElementName = "serviceProviderDefaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3309")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceProviderDefaultDomain
        {
            get => _serviceProviderDefaultDomain;
            set
            {
                ServiceProviderDefaultDomainSpecified = true;
                _serviceProviderDefaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderDefaultDomainSpecified { get; set; }

        private List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3309")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> Domain
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

    }
}
