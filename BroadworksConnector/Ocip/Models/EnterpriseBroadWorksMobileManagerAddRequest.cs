using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobileManagerAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "informationFile", IsNullable = false)]
    public string InformationFile { get; set; }
    [XmlElement(ElementName = "certificateFile", IsNullable = false)]
    public string CertificateFile { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "localToCarrier", IsNullable = false)]
    public bool LocalToCarrier { get; set; }
    [XmlElement(ElementName = "maxTxPerSecondEnabled", IsNullable = false)]
    public bool MaxTxPerSecondEnabled { get; set; }
    [XmlElement(ElementName = "maxTxPerSecond", IsNullable = false)]
    public int MaxTxPerSecond { get; set; }
    [XmlElement(ElementName = "tldnEnabled", IsNullable = false)]
    public bool TldnEnabled { get; set; }
    [XmlElement(ElementName = "genericNumberEnabled", IsNullable = false)]
    public bool GenericNumberEnabled { get; set; }
    [XmlElement(ElementName = "mobileStateCheckEnabled", IsNullable = false)]
    public bool MobileStateCheckEnabled { get; set; }
    [XmlElement(ElementName = "locationBasedServicesEnabled", IsNullable = false)]
    public bool LocationBasedServicesEnabled { get; set; }
 }
}
