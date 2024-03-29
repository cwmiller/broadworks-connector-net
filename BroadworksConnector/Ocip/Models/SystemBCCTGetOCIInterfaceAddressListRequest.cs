using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI entries from the Broadworks Common Communication Transport (BCCT) protocol to interface mapping list.
    /// The response is SystemBCCTGetOCIInterfaceAddressListResponse or ErrorResponse.
    /// <see cref="SystemBCCTGetOCIInterfaceAddressListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20802""}]")]
    public class SystemBCCTGetOCIInterfaceAddressListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBCCTGetOCIInterfaceAddressListResponse>
    {

    }
}
