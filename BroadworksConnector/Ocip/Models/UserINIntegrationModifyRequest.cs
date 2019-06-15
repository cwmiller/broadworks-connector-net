using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the user level IN Integration service attributes
    /// The response is either SuccessResponse or ErrorResponse
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserINIntegrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private int? _originatingServiceKey;

        [XmlElement(ElementName = "originatingServiceKey", IsNullable = true, Namespace = "")]
        public int? OriginatingServiceKey {
            get => _originatingServiceKey;
            set {
                OriginatingServiceKeySpecified = true;
                _originatingServiceKey = value;
            }
        }

        [XmlIgnore]
        public bool OriginatingServiceKeySpecified { get; set; }
        
        private int? _terminatingServiceKey;

        [XmlElement(ElementName = "terminatingServiceKey", IsNullable = true, Namespace = "")]
        public int? TerminatingServiceKey {
            get => _terminatingServiceKey;
            set {
                TerminatingServiceKeySpecified = true;
                _terminatingServiceKey = value;
            }
        }

        [XmlIgnore]
        public bool TerminatingServiceKeySpecified { get; set; }
        
    }
}
