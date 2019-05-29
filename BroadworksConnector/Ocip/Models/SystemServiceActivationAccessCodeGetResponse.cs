using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceActivationAccessCodeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "terminatingAccessCode", IsNullable = false)]
    public string TerminatingAccessCode { get; set; }
    [XmlElement(ElementName = "redirectingAccessCode", IsNullable = false)]
    public string RedirectingAccessCode { get; set; }
    [XmlElement(ElementName = "clickToDialAccessCode", IsNullable = false)]
    public string ClickToDialAccessCode { get; set; }
 }
}
