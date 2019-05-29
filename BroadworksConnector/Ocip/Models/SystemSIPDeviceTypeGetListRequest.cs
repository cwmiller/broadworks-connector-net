using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceType> SearchCriteriaDeviceType { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactSignalingAddressType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType SearchCriteriaExactSignalingAddressType { get; set; }
    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId { get; set; }
    [XmlElement(ElementName = "includeSystemLevel", IsNullable = false)]
    public bool IncludeSystemLevel { get; set; }
 }
}
