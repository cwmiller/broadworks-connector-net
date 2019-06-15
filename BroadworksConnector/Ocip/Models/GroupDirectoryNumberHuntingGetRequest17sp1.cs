using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the properties of the DNH service for a specified serviceUserId.
    /// It gets the agents of a call center or hunt group that are members
    /// of a directory number hunting group.  They are agents that are not already
    /// assigned to any other directory number hunting group.
    /// The response is either GroupDirectoryNumberHuntingGetResponse or ErrorResponse.
        /// <see cref="GroupDirectoryNumberHuntingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDirectoryNumberHuntingGetRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
