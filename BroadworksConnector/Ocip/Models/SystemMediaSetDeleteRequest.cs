using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a Media Set.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaSetDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        public string SetName {
            get => _setName;
            set {
                SetNameSpecified = true;
                _setName = value;
            }
        }

        [XmlIgnore]
        public bool SetNameSpecified { get; set; }
        
    }
}
