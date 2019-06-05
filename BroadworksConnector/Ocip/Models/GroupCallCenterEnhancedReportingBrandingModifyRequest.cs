using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingBrandingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
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
        private BroadworksConnector.Ocip.Models.LabeledFileResource _brandingFile;

        [XmlElement(ElementName = "brandingFile", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.LabeledFileResource BrandingFile
        {
            get => _brandingFile;
            set
            {
                BrandingFileSpecified = true;
                _brandingFile = value;
            }
        }

        [XmlIgnore]
        public bool BrandingFileSpecified { get; set; }
    }
}
