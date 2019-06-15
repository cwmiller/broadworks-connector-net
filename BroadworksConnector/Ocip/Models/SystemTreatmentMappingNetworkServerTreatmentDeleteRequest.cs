using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a NS Treatment mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingNetworkServerTreatmentDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _nsTreatment;

        [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
        public string NsTreatment {
            get => _nsTreatment;
            set {
                NsTreatmentSpecified = true;
                _nsTreatment = value;
            }
        }

        [XmlIgnore]
        public bool NsTreatmentSpecified { get; set; }
        
    }
}
