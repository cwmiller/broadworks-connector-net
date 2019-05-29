using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnterpriseCommonPhoneListGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false)]
    public int TotalNumberOfRows { get; set; }
    [XmlElement(ElementName = "enterpriseCommonPhoneListTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EnterpriseCommonPhoneListTable { get; set; }
 }
}
