using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingBrandingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice _brandingChoice;

    [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice BrandingChoice {
        get => _brandingChoice;
        set {
            BrandingChoiceSpecified = true;
            _brandingChoice = value;
        }
    }

    [XmlIgnore]
    public bool BrandingChoiceSpecified { get; set; }
    private string _customBrandingFileDescription;

    [XmlElement(ElementName = "customBrandingFileDescription", IsNullable = false, Namespace = "")]
    public string CustomBrandingFileDescription {
        get => _customBrandingFileDescription;
        set {
            CustomBrandingFileDescriptionSpecified = true;
            _customBrandingFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool CustomBrandingFileDescriptionSpecified { get; set; }
}
}
