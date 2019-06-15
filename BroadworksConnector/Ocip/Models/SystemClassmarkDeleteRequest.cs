using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Class Mark from system. It cannot be deleted if it is in use by any users.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClassmarkDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        public string Classmark {
            get => _classmark;
            set {
                ClassmarkSpecified = true;
                _classmark = value;
            }
        }

        [XmlIgnore]
        public bool ClassmarkSpecified { get; set; }
        
    }
}
