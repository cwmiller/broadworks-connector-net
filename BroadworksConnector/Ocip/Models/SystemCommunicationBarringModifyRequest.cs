using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "directTransferScreening", IsNullable = false)]
    public bool DirectTransferScreening { get; set; }
    [XmlElement(ElementName = "vmCallbackScreening", IsNullable = false)]
    public bool VmCallbackScreening { get; set; }
 }
}
