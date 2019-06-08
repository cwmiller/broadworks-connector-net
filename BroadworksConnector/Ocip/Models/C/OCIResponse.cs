using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIDataResponse))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.SuccessResponse))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.ErrorResponse))]
public abstract class OCIResponse : BroadWorksConnector.Ocip.Models.C.OCICommand
{
}
}
