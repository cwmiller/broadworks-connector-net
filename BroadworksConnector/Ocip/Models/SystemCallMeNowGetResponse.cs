using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallMeNowGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "passcodeLength", IsNullable = false)]
    public int PasscodeLength { get; set; }
    [XmlElement(ElementName = "passcodeTimeoutSeconds", IsNullable = false)]
    public int PasscodeTimeoutSeconds { get; set; }
 }
}
