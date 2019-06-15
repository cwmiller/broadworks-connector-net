using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceTagSetGetRequest.
    /// The response includes a tag set name defined in the access device.
        /// <see cref="GroupAccessDeviceTagSetGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceTagSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
    }
}
