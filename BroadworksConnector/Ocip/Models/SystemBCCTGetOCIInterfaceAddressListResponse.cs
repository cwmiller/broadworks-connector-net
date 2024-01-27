using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBCCTGetOCIInterfaceAddressListRequest.
    /// <see cref="SystemBCCTGetOCIInterfaceAddressListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20815""}]")]
    public class SystemBCCTGetOCIInterfaceAddressListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _interfaceNetAddress = new List<string>();

        [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:20815")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> InterfaceNetAddress
        {
            get => _interfaceNetAddress;
            set
            {
                InterfaceNetAddressSpecified = true;
                _interfaceNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool InterfaceNetAddressSpecified { get; set; }

    }
}
