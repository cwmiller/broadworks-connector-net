using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI entries from the Broadworks Common Communication Transport (BCCT) protocol to interface
    /// mapping list.
    /// The response is SystemBCCTGetOCIInterfaceAddressListResponse or ErrorResponse.
    /// <see cref="SystemBCCTGetOCIInterfaceAddressListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4361""}]")]
    public class SystemBCCTGetOCIInterfaceAddressListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
