using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing Office Zone.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOfficeZoneModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _newOfficeZoneName;

        [XmlElement(ElementName = "newOfficeZoneName", IsNullable = false, Namespace = "")]
        public string NewOfficeZoneName {
            get => _newOfficeZoneName;
            set {
                NewOfficeZoneNameSpecified = true;
                _newOfficeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool NewOfficeZoneNameSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementZoneList _replacementZoneList;

        [XmlElement(ElementName = "replacementZoneList", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementZoneList ReplacementZoneList {
            get => _replacementZoneList;
            set {
                ReplacementZoneListSpecified = true;
                _replacementZoneList = value;
            }
        }

        [XmlIgnore]
        public bool ReplacementZoneListSpecified { get; set; }
        
        private string _primaryZoneName;

        [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
        public string PrimaryZoneName {
            get => _primaryZoneName;
            set {
                PrimaryZoneNameSpecified = true;
                _primaryZoneName = value;
            }
        }

        [XmlIgnore]
        public bool PrimaryZoneNameSpecified { get; set; }
        
    }
}
