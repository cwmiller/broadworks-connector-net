using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementSwitchDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _svcProviderId;

    [XmlElement(ElementName = "svcProviderId", IsNullable = false, Namespace = "")]
    public string SvcProviderId {
        get => _svcProviderId;
        set {
            SvcProviderIdSpecified = true;
            _svcProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SvcProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private string _fromDeviceType;

    [XmlElement(ElementName = "fromDeviceType", IsNullable = false, Namespace = "")]
    public string FromDeviceType {
        get => _fromDeviceType;
        set {
            FromDeviceTypeSpecified = true;
            _fromDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool FromDeviceTypeSpecified { get; set; }
    private string _toDeviceType;

    [XmlElement(ElementName = "toDeviceType", IsNullable = false, Namespace = "")]
    public string ToDeviceType {
        get => _toDeviceType;
        set {
            ToDeviceTypeSpecified = true;
            _toDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool ToDeviceTypeSpecified { get; set; }
}
}