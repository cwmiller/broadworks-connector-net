using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeFileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderDeviceTypeFilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeFilesTable { get; set; }
    [XmlElement(ElementName = "serviceProviderHasCustomizableDynamicFiles", IsNullable = false)]
    public bool ServiceProviderHasCustomizableDynamicFiles { get; set; }
 }
}
