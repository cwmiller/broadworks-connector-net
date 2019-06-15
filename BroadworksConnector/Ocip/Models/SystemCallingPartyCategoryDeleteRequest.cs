using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Calling Party Category from system. The category cannot be deleted if it is the default or is in use by any users.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingPartyCategoryDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        public string Category {
            get => _category;
            set {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        public bool CategorySpecified { get; set; }
        
    }
}
