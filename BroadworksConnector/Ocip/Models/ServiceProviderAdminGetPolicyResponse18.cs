using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetPolicyResponse18 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "profileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ProfileAccess { get; set; }
    [XmlElement(ElementName = "groupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess GroupAccess { get; set; }
    [XmlElement(ElementName = "userAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess UserAccess { get; set; }
    [XmlElement(ElementName = "adminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess AdminAccess { get; set; }
    [XmlElement(ElementName = "departmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess DepartmentAccess { get; set; }
    [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess AccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess CallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "serviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceAccess { get; set; }
    [XmlElement(ElementName = "servicePackAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServicePackAccess { get; set; }
    [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess SessionAdmissionControlAccess { get; set; }
    [XmlElement(ElementName = "webBrandingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess WebBrandingAccess { get; set; }
    [XmlElement(ElementName = "officeZoneAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess OfficeZoneAccess { get; set; }
    [XmlElement(ElementName = "communicationBarringAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess CommunicationBarringAccess { get; set; }
    [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess NetworkPolicyAccess { get; set; }
    [XmlElement(ElementName = "numberActivationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess NumberActivationAccess { get; set; }
    [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess DialableCallerIDAccess { get; set; }
 }
}
