using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify default Feature Access Codes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: SystemFeatureAccessCodeModifyListRequest21
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemFeatureAccessCodeModifyListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34702""}]")]
    public class SystemFeatureAccessCodeModifyListRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34702")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode
        {
            get => _featureAccessCode;
            set
            {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeSpecified { get; set; }

    }
}
