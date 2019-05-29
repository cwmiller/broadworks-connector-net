using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdminGetPolicyResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "profileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminProfileAccess ProfileAccess { get; set; }
    [XmlElement(ElementName = "userAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminUserAccess UserAccess { get; set; }
    [XmlElement(ElementName = "adminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAdminAccess AdminAccess { get; set; }
    [XmlElement(ElementName = "departmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess DepartmentAccess { get; set; }
    [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess AccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess EnhancedServiceInstanceAccess { get; set; }
    [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess FeatureAccessCodeAccess { get; set; }
    [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess CallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "serviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminServiceAccess ServiceAccess { get; set; }
    [XmlElement(ElementName = "trunkGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess TrunkGroupAccess { get; set; }
    [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess SessionAdmissionControlAccess { get; set; }
    [XmlElement(ElementName = "officeZoneAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess OfficeZoneAccess { get; set; }
    [XmlElement(ElementName = "numberActivationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess NumberActivationAccess { get; set; }
    [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess DialableCallerIDAccess { get; set; }
    [XmlElement(ElementName = "communicationBarringUserProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess CommunicationBarringUserProfileAccess { get; set; }
 }
}
