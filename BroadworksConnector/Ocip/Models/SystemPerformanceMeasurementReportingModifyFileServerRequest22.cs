using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingModifyFileServerRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _repositoryUrl;

    [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
    public string RepositoryUrl {
        get => _repositoryUrl;
        set {
            RepositoryUrlSpecified = true;
            _repositoryUrl = value;
        }
    }

    [XmlIgnore]
    public bool RepositoryUrlSpecified { get; set; }
    private bool _passiveFTP;

    [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
    public bool PassiveFTP {
        get => _passiveFTP;
        set {
            PassiveFTPSpecified = true;
            _passiveFTP = value;
        }
    }

    [XmlIgnore]
    public bool PassiveFTPSpecified { get; set; }
}
}
