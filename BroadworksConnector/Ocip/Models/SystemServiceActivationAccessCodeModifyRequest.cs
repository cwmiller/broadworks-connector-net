using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceActivationAccessCodeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "terminatingAccessCode", IsNullable = true)]
    public string TerminatingAccessCode { get; set; }
    [XmlElement(ElementName = "redirectingAccessCode", IsNullable = true)]
    public string RedirectingAccessCode { get; set; }
    [XmlElement(ElementName = "clickToDialAccessCode", IsNullable = true)]
    public string ClickToDialAccessCode { get; set; }
 }
}
