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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1225""}]")]
    public class EnterpriseCallCenterEnhancedReportingBrandingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice _brandingChoice;

        [XmlElement(ElementName = "brandingChoice", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1225")]
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

        private string _brandingFileDescription;

        [XmlElement(ElementName = "brandingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1225")]
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
