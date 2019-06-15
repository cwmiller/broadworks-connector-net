using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a static configuration tag set.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceManagementTagSetModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        public string TagSetName {
            get => _tagSetName;
            set {
                TagSetNameSpecified = true;
                _tagSetName = value;
            }
        }

        [XmlIgnore]
        public bool TagSetNameSpecified { get; set; }
        
        private string _newTagSetName;

        [XmlElement(ElementName = "newTagSetName", IsNullable = false, Namespace = "")]
        public string NewTagSetName {
            get => _newTagSetName;
            set {
                NewTagSetNameSpecified = true;
                _newTagSetName = value;
            }
        }

        [XmlIgnore]
        public bool NewTagSetNameSpecified { get; set; }
        
    }
}
