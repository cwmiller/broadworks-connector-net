using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.C.OCIRequest))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.C.OCIResponse))]
public abstract class OCICommand 
{
 }
}
