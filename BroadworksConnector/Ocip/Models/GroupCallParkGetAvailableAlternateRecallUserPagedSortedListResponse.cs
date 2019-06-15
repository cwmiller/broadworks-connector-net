using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// “Phone Number”, “Extension”, “Department”, “Email Address”. The Email Address will never be populated, since Hunt Groups don't
    /// have Email Addresses.
        /// <see cref="GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

        [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableHuntGroupTable {
            get => _availableHuntGroupTable;
            set {
                AvailableHuntGroupTableSpecified = true;
                _availableHuntGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool AvailableHuntGroupTableSpecified { get; set; }
        
    }
}
