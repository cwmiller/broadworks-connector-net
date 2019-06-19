using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemIntegratedIMPGetRequest.
    /// The response contains the system Integrated IMP service attributes.
    /// 
    /// Replaced by SystemIntegratedIMPGetResponse19.
    /// <see cref="SystemIntegratedIMPGetRequest"/>
    /// <see cref="SystemIntegratedIMPGetResponse19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26218""}]")]
    public class SystemIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26218")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        public bool ServiceDomainSpecified { get; set; }

        private int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26218")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int ServicePort
        {
            get => _servicePort;
            set
            {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        public bool ServicePortSpecified { get; set; }

        private bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26218")]
        public bool AddServiceProviderInIMPUserId
        {
            get => _addServiceProviderInIMPUserId;
            set
            {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        public bool AddServiceProviderInIMPUserIdSpecified { get; set; }

    }
}
