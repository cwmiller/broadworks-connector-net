using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCallCenterEnhancedReportingBrandingGetRequest.
    /// <see cref="SystemCallCenterEnhancedReportingBrandingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5986""}]")]
    public class SystemCallCenterEnhancedReportingBrandingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5986")]
        public BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice BrandingChoice
        {
            get => _brandingChoice;
            set
            {
                BrandingChoiceSpecified = true;
                _brandingChoice = value;
            }
        }

        [XmlIgnore]
        protected bool BrandingChoiceSpecified { get; set; }

        private string _customBrandingFileDescription;

        [XmlElement(ElementName = "customBrandingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5986")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CustomBrandingFileDescription
        {
            get => _customBrandingFileDescription;
            set
            {
                CustomBrandingFileDescriptionSpecified = true;
                _customBrandingFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool CustomBrandingFileDescriptionSpecified { get; set; }

    }
}
