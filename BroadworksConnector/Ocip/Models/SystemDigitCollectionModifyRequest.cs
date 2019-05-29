using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDigitCollectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "accessCode", IsNullable = true)]
    public string AccessCode { get; set; }
    [XmlElement(ElementName = "publicDigitMap", IsNullable = false)]
    public string PublicDigitMap { get; set; }
    [XmlElement(ElementName = "privateDigitMap", IsNullable = true)]
    public string PrivateDigitMap { get; set; }
 }
}
