using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Removes a BroadWorks Mobility IMRN number from the system.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityDeleteIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<string> _imrnNumber;

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        public List<string> ImrnNumber {
            get => _imrnNumber;
            set {
                ImrnNumberSpecified = true;
                _imrnNumber = value;
            }
        }

        [XmlIgnore]
        public bool ImrnNumberSpecified { get; set; }
        
    }
}
