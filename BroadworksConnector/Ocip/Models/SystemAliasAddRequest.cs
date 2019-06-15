using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system-level Application Server alias to the system.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAliasAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _aliasNetAddress;

        [XmlElement(ElementName = "aliasNetAddress", IsNullable = false, Namespace = "")]
        public string AliasNetAddress {
            get => _aliasNetAddress;
            set {
                AliasNetAddressSpecified = true;
                _aliasNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool AliasNetAddressSpecified { get; set; }
        
    }
}
