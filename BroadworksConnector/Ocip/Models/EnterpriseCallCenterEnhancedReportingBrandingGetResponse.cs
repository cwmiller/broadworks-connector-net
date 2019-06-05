using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterEnhancedReportingBrandingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice BrandingChoice
        {
            get => _brandingChoice;
            set
            {
                BrandingChoiceSpecified = true;
                _brandingChoice = value;
            }
        }

        [XmlIgnore]
        public bool BrandingChoiceSpecified { get; set; }
        private string _brandingFileDescription;

        [XmlElement(ElementName = "brandingFileDescription", IsNullable = false, Namespace = "")]
        public string BrandingFileDescription
        {
            get => _brandingFileDescription;
            set
            {
                BrandingFileDescriptionSpecified = true;
                _brandingFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool BrandingFileDescriptionSpecified { get; set; }
    }
}
