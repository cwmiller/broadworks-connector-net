using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingBrandingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice _brandingChoice;

    [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice BrandingChoice {
        get => _brandingChoice;
        set {
            BrandingChoiceSpecified = true;
            _brandingChoice = value;
        }
    }

    [XmlIgnore]
    public bool BrandingChoiceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _customBrandingFile;

    [XmlElement(ElementName = "customBrandingFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource CustomBrandingFile {
        get => _customBrandingFile;
        set {
            CustomBrandingFileSpecified = true;
            _customBrandingFile = value;
        }
    }

    [XmlIgnore]
    public bool CustomBrandingFileSpecified { get; set; }
}
}
