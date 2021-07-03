using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:11854""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
