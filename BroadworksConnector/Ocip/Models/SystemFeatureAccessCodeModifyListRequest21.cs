using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify default Feature Access Codes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFeatureAccessCodeModifyListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> _featureAccessCode;

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> FeatureAccessCode {
            get => _featureAccessCode;
            set {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        public bool FeatureAccessCodeSpecified { get; set; }
        
    }
}
