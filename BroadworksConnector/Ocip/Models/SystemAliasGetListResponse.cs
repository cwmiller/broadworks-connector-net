using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAliasGetListRequest. Contains the list of all network alias' for
    /// the Application Server.
        /// <see cref="SystemAliasGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAliasGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _aliasNetAddress;

        [XmlElement(ElementName = "aliasNetAddress", IsNullable = false, Namespace = "")]
        public List<string> AliasNetAddress {
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
