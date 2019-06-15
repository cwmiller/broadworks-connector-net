using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemFeatureAccessCodeGetListRequest20.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: SystemFeatureAccessCodeGetListResponse21
        /// <see cref="SystemFeatureAccessCodeGetListRequest20"/>
        /// <see cref="SystemFeatureAccessCodeGetListResponse21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFeatureAccessCodeGetListResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode;

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode {
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
