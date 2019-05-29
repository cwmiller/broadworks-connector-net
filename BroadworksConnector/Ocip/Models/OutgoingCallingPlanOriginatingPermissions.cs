using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanOriginatingPermissions 
{
    [XmlElement(ElementName = "group", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Group { get; set; }
    [XmlElement(ElementName = "local", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Local { get; set; }
    [XmlElement(ElementName = "tollFree", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission TollFree { get; set; }
    [XmlElement(ElementName = "toll", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Toll { get; set; }
    [XmlElement(ElementName = "international", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission International { get; set; }
    [XmlElement(ElementName = "operatorAssisted", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission OperatorAssisted { get; set; }
    [XmlElement(ElementName = "chargeableDirectoryAssisted", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission ChargeableDirectoryAssisted { get; set; }
    [XmlElement(ElementName = "specialServicesI", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission SpecialServicesI { get; set; }
    [XmlElement(ElementName = "specialServicesII", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission SpecialServicesII { get; set; }
    [XmlElement(ElementName = "premiumServicesI", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission PremiumServicesI { get; set; }
    [XmlElement(ElementName = "premiumServicesII", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission PremiumServicesII { get; set; }
    [XmlElement(ElementName = "casual", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Casual { get; set; }
    [XmlElement(ElementName = "urlDialing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission UrlDialing { get; set; }
    [XmlElement(ElementName = "unknown", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Unknown { get; set; }
 }
}
