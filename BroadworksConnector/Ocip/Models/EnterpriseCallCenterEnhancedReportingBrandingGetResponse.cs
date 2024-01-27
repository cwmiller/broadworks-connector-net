using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterEnhancedReportingBrandingGetRequest.
    /// <see cref="EnterpriseCallCenterEnhancedReportingBrandingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:1220""}]")]
    public class EnterpriseCallCenterEnhancedReportingBrandingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1220")]
        public BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice BrandingChoice
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

        protected string _brandingFileDescription;

        [XmlElement(ElementName = "brandingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1220")]
        [MinLength(1)]
        [MaxLength(256)]
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
        protected bool BrandingFileDescriptionSpecified { get; set; }

    }
}
