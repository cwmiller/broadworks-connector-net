using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPolycomPhoneServicesGetRequest.
        /// <see cref="GroupPolycomPhoneServicesGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupPolycomPhoneServicesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _includeGroupCommonPhoneListInDirectory;

        [XmlElement(ElementName = "includeGroupCommonPhoneListInDirectory", IsNullable = false, Namespace = "")]
        public bool IncludeGroupCommonPhoneListInDirectory {
            get => _includeGroupCommonPhoneListInDirectory;
            set {
                IncludeGroupCommonPhoneListInDirectorySpecified = true;
                _includeGroupCommonPhoneListInDirectory = value;
            }
        }

        [XmlIgnore]
        public bool IncludeGroupCommonPhoneListInDirectorySpecified { get; set; }
        
        private bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        public bool IncludeGroupCustomContactDirectoryInDirectory {
            get => _includeGroupCustomContactDirectoryInDirectory;
            set {
                IncludeGroupCustomContactDirectoryInDirectorySpecified = true;
                _includeGroupCustomContactDirectoryInDirectory = value;
            }
        }

        [XmlIgnore]
        public bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }
        
        private string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false, Namespace = "")]
        public string GroupCustomContactDirectory {
            get => _groupCustomContactDirectory;
            set {
                GroupCustomContactDirectorySpecified = true;
                _groupCustomContactDirectory = value;
            }
        }

        [XmlIgnore]
        public bool GroupCustomContactDirectorySpecified { get; set; }
        
    }
}
