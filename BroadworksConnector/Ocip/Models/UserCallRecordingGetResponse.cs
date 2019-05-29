using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallRecordingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "recordingOption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecordingOption RecordingOption { get; set; }
 }
}
