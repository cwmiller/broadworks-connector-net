using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false)]
    public int TotalNumberOfRows { get; set; }
    [XmlElement(ElementName = "personalPhoneListTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PersonalPhoneListTable { get; set; }
 }
}
