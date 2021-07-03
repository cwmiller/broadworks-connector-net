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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20052""}]")]
    public class SystemBCCTDeleteOCIInterfaceAddressRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _interfaceNetAddress;

        [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20052")]
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
