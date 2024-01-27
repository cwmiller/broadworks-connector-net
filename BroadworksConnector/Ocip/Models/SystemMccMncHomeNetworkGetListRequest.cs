using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Mcc/Mnc home networks at the system level.
    /// The response is either SystemMccMncHomeNetworkGetListResponse or ErrorResponse.
    /// <see cref="SystemMccMncHomeNetworkGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemMccMncHomeNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMccMncHomeNetworkGetListResponse>
    {

    }
}
