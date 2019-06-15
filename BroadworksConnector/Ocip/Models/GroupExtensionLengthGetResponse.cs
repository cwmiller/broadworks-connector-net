using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExtensionLengthGetRequest.
        /// <see cref="GroupExtensionLengthGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupExtensionLengthGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
        public int ExtensionLength {
            get => _extensionLength;
            set {
                ExtensionLengthSpecified = true;
                _extensionLength = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionLengthSpecified { get; set; }
        
    }
}
