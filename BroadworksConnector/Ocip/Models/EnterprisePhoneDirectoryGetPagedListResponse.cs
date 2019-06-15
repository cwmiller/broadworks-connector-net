using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterprisePhoneDirectoryGetPagedListRequest.
    /// Contains a table with a row for each phone number and column headings :
    /// "Name", "Number", "Extension", "Mobile", "Email Address",
    /// "Department", "Hiragana Name", "Group Id", "Yahoo Id", "User Id", "IMP Id", "Is Virtual On-Net User".
    /// If extended directory information is requested, the following columns are also included:
    /// "First Name", "Last Name", "Pager", "Title", "Time Zone",
    /// "Location", "Address Line 1", "Address Line 2",
    /// "City", "State", "Zip", "Country", "Service Name".
    /// The Service Name represents the localized service name for service instances. The localized values are
    /// taken from the BroadworksLabel.properties file.
    /// Service Name is currently supporting:
    /// AutoAttendant, AutoAttendantStandard, AutoAttendantVideo, CallCenter, CallCenterStandard,
    /// CallCenterPremium
    /// HuntGroup, InstantGroupCall, VoiceMessagingGroup, RoutePoint, BroadWorksAnywhere, GroupPaging,
    /// FindmeFollowme,
    /// VoiceXML, FlexibleSeatingGuest, CollaborateAudio, MeetMeConferencing.
    /// For a Regular User or a Virtual On Network Enterprise Extensions, the Service Name is empty.
    /// 
    /// The following columns are returned in AS data mode only:
    /// "Service Name"
    /// 
    /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListResponse
        /// <see cref="EnterprisePhoneDirectoryGetPagedListRequest"/>
        /// <see cref="EnterprisePhoneDirectoryGetPagedSortedListResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterprisePhoneDirectoryGetPagedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        public int TotalNumberOfRows {
            get => _totalNumberOfRows;
            set {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfRowsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DirectoryTable {
            get => _directoryTable;
            set {
                DirectoryTableSpecified = true;
                _directoryTable = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryTableSpecified { get; set; }
        
    }
}
