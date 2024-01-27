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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5982""}]")]
    public class SystemCallCenterEnhancedReportingBrandingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5982")]
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

        protected string _customBrandingFileDescription;

        [XmlElement(ElementName = "customBrandingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5982")]
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
