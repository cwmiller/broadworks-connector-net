using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an OCI entry in the Broadworks Common Communication Transport (BCCT) protocol to interface mapping table.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20786""}]")]
    public class SystemBCCTDeleteOCIInterfaceAddressRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _interfaceNetAddress;

        [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20786")]
        [MinLength(1)]
        [MaxLength(80)]
        public string InterfaceNetAddress
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
