using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemThirdPartyIMPGetRequest19.
    /// The response contains the system Third-Party IMP service attributes.
    /// <see cref="SystemThirdPartyIMPGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""94766dfbb33c7fae7c6022754ea24721:53""}]")]
    public class SystemThirdPartyIMPGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceNetAddress;

        [XmlElement(ElementName = "serviceNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"94766dfbb33c7fae7c6022754ea24721:53")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceNetAddress
        {
            get => _serviceNetAddress;
            set
            {
                ServiceNetAddressSpecified = true;
                _serviceNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceNetAddressSpecified { get; set; }

        private int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"94766dfbb33c7fae7c6022754ea24721:53")]
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
        protected bool ServicePortSpecified { get; set; }

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"94766dfbb33c7fae7c6022754ea24721:53")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BoshURL
        {
            get => _boshURL;
            set
            {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        protected bool BoshURLSpecified { get; set; }

    }
}
