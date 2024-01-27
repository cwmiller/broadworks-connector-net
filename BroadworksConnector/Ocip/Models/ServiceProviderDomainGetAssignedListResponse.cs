using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of service provider domain names.
    /// 
    /// Replaced by ServiceProviderDomainGetAssignedListResponse22
    /// <see cref="ServiceProviderDomainGetAssignedListResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:6659""}]")]
    public class ServiceProviderDomainGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceProviderDefaultDomain;

        [XmlElement(ElementName = "serviceProviderDefaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:6659")]
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

        protected List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:6659")]
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
