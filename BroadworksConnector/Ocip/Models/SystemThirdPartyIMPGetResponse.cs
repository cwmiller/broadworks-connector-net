using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemThirdPartyIMPGetRequest.
    /// The response contains the system Third-Party IMP service attributes.
    /// 
    /// Replaced by SystemThirdPartyIMPGetResponse19.
    /// <see cref="SystemThirdPartyIMPGetRequest"/>
    /// <see cref="SystemThirdPartyIMPGetResponse19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36225""}]")]
    public class SystemThirdPartyIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceNetAddress;

        [XmlElement(ElementName = "serviceNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36225")]
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

        protected int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36225")]
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

    }
}
