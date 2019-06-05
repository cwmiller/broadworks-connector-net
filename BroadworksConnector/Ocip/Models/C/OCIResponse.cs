using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.C.OCIDataResponse))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.C.SuccessResponse))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.C.ErrorResponse))]
public abstract class OCIResponse : BroadworksConnector.Ocip.Models.C.OCICommand
{
}
}
