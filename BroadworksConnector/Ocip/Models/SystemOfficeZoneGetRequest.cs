using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Office Zone.
    /// The response is either a SystemOfficeZoneGetResponse
    /// or an ErrorResponse.
        /// <see cref="SystemOfficeZoneGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOfficeZoneGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        public string OfficeZoneName {
            get => _officeZoneName;
            set {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneNameSpecified { get; set; }
        
    }
}
