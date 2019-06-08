using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIRequest))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIResponse))]
public abstract class OCICommand 
{
}
}
