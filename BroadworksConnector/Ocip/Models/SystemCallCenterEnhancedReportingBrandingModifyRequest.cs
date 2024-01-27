using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system branding configuration.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5999""}]")]
    public class SystemCallCenterEnhancedReportingBrandingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5999")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledFileResource _customBrandingFile;

        [XmlElement(ElementName = "customBrandingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5999")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource CustomBrandingFile
        {
            get => _customBrandingFile;
            set
            {
                CustomBrandingFileSpecified = true;
                _customBrandingFile = value;
            }
        }

        [XmlIgnore]
        protected bool CustomBrandingFileSpecified { get; set; }

    }
}
