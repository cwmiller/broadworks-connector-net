using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListRequest17sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "callLogType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType CallLogType { get; set; }
    [XmlElement(ElementName = "dateTimeRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsTimeRange DateTimeRange { get; set; }
    [XmlElement(ElementName = "numberFilter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsNumberFilter NumberFilter { get; set; }
    [XmlElement(ElementName = "redirectedNumberFilter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter RedirectedNumberFilter { get; set; }
    [XmlElement(ElementName = "accountAuthorizationCodeFilter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter AccountAuthorizationCodeFilter { get; set; }
    [XmlElement(ElementName = "subscriberType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsSubscriberType SubscriberType { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
 }
}
